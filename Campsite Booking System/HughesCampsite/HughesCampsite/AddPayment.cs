using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HughesCampsite
{
    public partial class AddPayment : Form
    {

        public BOOKINGDetails NewBooking = new BOOKINGDetails(); //These variables are required to be declared in the class, because multiple methods with no relations require access to these variables
        public int customerID;

        public AddPayment(string StaffDetails, int custID, BOOKINGDetails newBooking)
        {
            InitializeComponent();

            toolStripLabel1.Text = StaffDetails;

            lblPaymentPrice.Text = string.Format("Price: £{0}", newBooking.Price);

            NewBooking = newBooking;
            newBooking = null; //Clears the now obsoulte and needless BOOKINGDetails instance from system memory

            customerID = custID;

        }

        private void btnAddPayment_Click(object sender, EventArgs e) //Begins the first stage of processing a payment
        {
            PAYMENTDetails NewPayment = new PAYMENTDetails(); //Creates a new instance of the PAYMENTDetails collection
            try
            {
                NewPayment.PaymentType = comboPaymentType.Text;
                NewPayment.NameOnCard = txtNameOnCard.Text.Trim();
                NewPayment.CardNumber = txtCardNumber.Text.Trim();
                NewPayment.SecurityCode = txtSecurityCode.Text.Trim();
                if (comboPaymentType.Text != "Cash") //Only gives ExpiryDate a value if payment type isnt cash, this way that field will be empty when a cash payment is added to the system. Therefore the field is null in the database
                {
                    NewPayment.ExpiryDate = dtpExpiryDate.Value;
                }
                NewPayment.AmountPaid = NewBooking.Price;
                NewPayment.DatePaid = DateTime.Now;
            }
            catch (Exception)
            {
                unAssociatedMethods.genericErrorMessage("This was caused during the filling of a new payment's data", "50003");
                return;
            }

            var validator = new PAYMENTValidator(); //Creates a new instance of the PAYMENTDetails validator
            if (!validator.Validate(NewPayment)) //If the validator returns false, then the validation process has flagged a validation error
            {
                MessageBox.Show("Payment has not been added or processed");
                return;
            }

            Invoice frm = new Invoice(toolStripLabel1.Text, customerID, NewBooking, NewPayment); //Creates a new instance of the invoice form
            frm.ShowDialog(); //Shows the invoice form
            this.Close();
        }


        private void btnBack_Click(object sender, EventArgs e) //Closes the Add Payment form
        {
            this.Close();
        }

        private void comboPaymentType_TextUpdate(object sender, EventArgs e)  //This event handler is whenever the the payment combo box is updated
        {
            if (comboPaymentType.Text == "Cash") //Disables the input fields that are only relevant to Card Payments
            {
                txtCardNumber.Enabled = false;
                txtNameOnCard.Enabled = false;
                txtSecurityCode.Enabled = false;
                dtpExpiryDate.Enabled = false;

                txtCardNumber.Text = "";
                txtNameOnCard.Text = "";
                txtSecurityCode.Text = "";
            }
            else                                  //Enables the input fields that are relevant to Card Payments
            {
                txtCardNumber.Enabled = true; ;
                txtNameOnCard.Enabled = true;
                txtSecurityCode.Enabled = true;
                dtpExpiryDate.Enabled = true;
            }
        }

        private void AddPayment_Load(object sender, EventArgs e)
        {
            toolStripBtnLock.Tag = toolStripLabel1.Text.ToString();

            unAssociatedMethods.set(this.Controls); //loads font and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
            this.Icon = Properties.Resources.hughesLogo;
        }
    }
}
