using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace HughesCampsite
{
    ///LOOK INTO PRINTING INVOICE, maybe a save button that saves it as text document or pdf etc
    
    public partial class Invoice : Form
    {
        public BOOKINGDetails NewBooking;
        public PAYMENTDetails NewPayment;
        public int staffID;
        public int CustomerID;


        public Invoice(string staffDetails, int customerID, BOOKINGDetails newBooking, PAYMENTDetails newPayment)
        {
            InitializeComponent();

            toolStripLabel1.Text = staffDetails;

            Font fr = unAssociatedMethods.getUserSelectedFont();
            lblCustomerDetailsCustomerID.Font = fr;
            lblCustomerDetailsLastName.Font = fr;
            fr = null;
             
            staffID = retrieveIDs.getStaffIdUsingTheString(staffDetails); //Gets the Primary key ID's 'prepared'
            CustomerID = customerID;
            NewBooking = newBooking;
            NewPayment = newPayment;

            newBooking = null; //sets these collections to null to avoid wasting memory
            newPayment = null;

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            unAssociatedMethods.set(this.Controls); //Loads font and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
            this.Icon = Properties.Resources.hughesLogo;

            toolStripBtnLock.Tag = toolStripLabel1.Text.ToString();

            loadInLabelsText();

        }

        private void loadInLabelsText() //Sets the text of labels to their respective values (i.e Customer ID: 4)
        {
            //CUSTOMER DETAILS
            lblCustomerDetailsCustomerID.Text = string.Format("Customer ID: {0}", CustomerID.ToString());
            lblCustomerDetailsLastName.Text = string.Format("LastName: {0}", Database.customersLastName(CustomerID));

            //BOOKING DETAILS
            lblCabinNo.Text = string.Format("CabinNo: {0}", NewBooking.CabinNo.ToString());
            lblNumOfAdults.Text = string.Format("Number Of Adults: {0}", NewBooking.NumOfAdults);
            lblNumOfChildren.Text = string.Format("Number Of Children: {0}", NewBooking.NumOfChildren);
            lblStartDate.Text = string.Format("Start Date: {0}", NewBooking.StartDate.ToString("dd-MM-yyyy"));
            lblEndDate.Text = string.Format("End Date: {0}", NewBooking.EndDate.ToString("dd-MM-yyyy"));
            lblSeason.Text = string.Format("Season: {0}", NewBooking.Season);
            lblPrice.Text = string.Format("Price: {0}", NewBooking.Price.ToString());

            //PAYMENT DETAILS
            lblPaymentType.Text = string.Format("Payment type: {0}", NewPayment.PaymentType);
            if (NewPayment.PaymentType == "Cash") //If the paymentType is cash, then the fields that apply to Card payments are set to 'N/A'
            {
                string nl = "N/A";
                lblNameOnCard.Text = string.Format("Name on Card: {0}", nl);
                lblCardNumber.Text = string.Format("Card Number: {0}", nl);
                lblSecurityCode.Text = string.Format("Security Code: {0}", nl);
                lblExpiryDate.Text = string.Format("Expiry Date: {0}", nl);
            }
            else
            {
                lblNameOnCard.Text = string.Format("Name on Card: {0}", NewPayment.NameOnCard);
                lblCardNumber.Text = string.Format("Card Number: {0}", NewPayment.NameOnCard);
                lblSecurityCode.Text = string.Format("Security Code: {0}", NewPayment.SecurityCode);
                lblExpiryDate.Text = string.Format("Expiry Date: {0}", NewPayment.ExpiryDate.ToString("dd-MM-yyyy"));
            }
            lblAmountPaid.Text = string.Format("Amount Paid: {0}", Convert.ToString(Decimal.Round(NewPayment.AmountPaid, 2)));
        }

        private void btnConfirm_Click(object sender, EventArgs e) //Last user dependent process until the order is added to the database with all its links
        {
            int BookingID = addToDatabase.addBooking(NewBooking); //Add Booking to booking table and retrieves its auto-incremented BookingID
            if (BookingID == -1) //If the BookingId is zero, that means that a error occured and the booking wasn't added. The execution of this method is then stopped
            {                      //The reason it returns = -1 and not false is because the addToDatabase.addBooking method only returns integers, and i dont know how to stop execution of this method from the other method
                return;
            }


            int PaymentID = addToDatabase.addPayment(NewPayment); //Add Payment to Payment table and retrieves its auto-incremented PaymentID
            if (PaymentID == -1)//If the PaymentID is zero, that means that a error occured and the Payment wasn't added. The execution of this method is then stopped
            {                   //The reason it returns = -1 and not false is because the addToDatabase.addPayment method only returns integers, and i dont know how to stop execution of this method from the other method
                deleteFromDatabase.deleteRecords("BookingID", BookingID, "BOOKING"); //Must delete booking from booking table, since payment process failed
                return;
            }

            LINKTABLEDetails newLink = new LINKTABLEDetails(); //Creates a new instance of the LINKTABLEDetails collection
            try
            {
            newLink.CustomerID = CustomerID;
            newLink.BookingID = BookingID;
            newLink.StaffID = staffID;
            newLink.PaymentID = PaymentID;
            }
            catch (Exception)
            {
                unAssociatedMethods.genericErrorMessage("This was caused during the filling of a new link's data", "50005");
                return;
            }

            var validator = new LINKTABLEValidator(); //Creates a new instance of the LINKTABLEDetails validator
            if (!validator.Validate(newLink)) //If validator returns false, then the booking and payment must be removed from the database
            {
                MessageBox.Show("Links have not been added\nThe order wasn't added to the database");
                deleteFromDatabase.deleteRecords("BookingID", BookingID, "BOOKING"); ///DELETE THE BOOKING AND PAYMENT
                deleteFromDatabase.deleteRecords("PaymentId", PaymentID, "PAYMENTS");
                                                                                                                
                return;
            }

            addToDatabase.addLinks(newLink); //Add links to the link table & the order is done
            MessageBox.Show("Booking complete!");
        }

        private void btnBack_Click(object sender, EventArgs e) //Event handler for the close button
        {
            this.Close();
        }


        /// <summary>
        /// PRINT CODE
        /// </summary>

        private PrintDocument printDocument1 = new PrintDocument(); //Creates a new instance of printDocument
        Bitmap memoryImage;

        void printButton_Click(object sender, EventArgs e) //Event handler that runs the approaite code to print
        {
            CaptureScreen();
            printDocument1.Print(); //Prints the form using the default printer
        }

        private void CaptureScreen() //Configs and preps the 'Screenshot'
        {
            Graphics myGraphics = this.CreateGraphics(); //Creates new instance of Graphics
            Size s = this.Size; //Sets the size of the 'Screenshot' to be the same size as the invoice form
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e) //Takes a 'Screenshot' of the form
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
