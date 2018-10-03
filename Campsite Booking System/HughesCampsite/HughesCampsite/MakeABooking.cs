using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel.DataAnnotations;


namespace HughesCampsite
{
    public partial class MakeABooking : Form   
    {
        int custID;

        public MakeABooking(string StaffMembersDetails)
        {
            InitializeComponent();

            toolStripLabel1.Text = StaffMembersDetails;

        }

        private void btnMakeABookingCA_Click(object sender, EventArgs e) //Event handler for step 1 of the booking process
        {
            if (dtpMakeABookingCAEndDate.Value <= dtpMakeABookingCAStartDate.Value) //Validates that the user input end date is after the user input start date
            {
                MessageBox.Show("Enter a validate start date and end date");
                return;
            }
            List<string> CabinNoInUse = Database.checkAvailability(dtpMakeABookingCAStartDate.Value, dtpMakeABookingCAEndDate.Value); ///CabinNoInUse can be misleading, CabinNoInUse means the Cabin numbers off all the cabins unavailable

            List<string> CabinNoOfSelectedtype = Database.findOutTheCabinNoOfSelectedType(comboMakeABookingType.Text, comboCapacity.Text); ///Gets a list of all the Cabin numbers matching the user input cabin type. ex) all the cabinNo's of type = "Gold"

            findCabinsNotInUse(CabinNoInUse, CabinNoOfSelectedtype); //Compares the 2 list<string> collections

            if (comboMakeABookingCabinNo.Items.Count == 0)  //Validates that their is indeed a cabin available matching the criteria
            {
                MessageBox.Show("No Pitchs available matching that criteria");
                return;
            }

            grpMakeABooking.Visible = true; //Makes step 2 of the booking form visible 
        }

        private void findCabinsNotInUse(List<string> CabinNoInUse, List<string> CabinNoOfSelectedType) //Calculates and displays the available cabin numbers in a combobox
        {

            foreach (string n in CabinNoInUse)   ///n is a cabinNo in the CabinNoInUse collection
            {
                foreach (string i in CabinNoOfSelectedType) ///i is a cabinNo in the CabinNoOfSelectedType collection
                {
                    if (n == i) //If both match, then that cabin type is not available and is removed from the CabinNoOfSelectedType list
                    {
                        CabinNoOfSelectedType.Remove(i);
                        break;
                    }
                }
            }

            comboMakeABookingCabinNo.Items.Clear(); //Makes sure that duplictes dont occur when the button is pressed twice

            foreach (string n in CabinNoOfSelectedType) //The CabinNoOfSelectedType collection now only contains the cabin numbers matching the user input criteria
            {
                int value = Convert.ToInt16(n);
                comboMakeABookingCabinNo.Items.Add(value); //Adds to the combobox
            }


        }

        private void btnMakeABookingGetAQuote_Click(object sender, EventArgs e) //Event handler for step 2 of the booking process
        {

            string cabinCapacity = Database.findCabinCapacity(comboMakeABookingCabinNo.Text); //Fetchs the capacity of the user selected cabin

            if ((txtMakeABookingAdults.Text == "") || (txtMakeABookingChildren.Text == "")) //Validates that both fields arent empty
            {
                MessageBox.Show("Please enter valid numbers for adults and children");
                btnMakeABookingPay.Enabled = false;//This button is disbale to remove the bug that allows the user to circumvent some of the systems validation and lead to huge errors later on. EX)Getting pay button to appear then changing number of adults and then clicking the pay button would have allowed you to begin payment process
                return;
            }

            try
            {
                if ((Convert.ToInt16(txtMakeABookingAdults.Text) + Convert.ToInt16(txtMakeABookingChildren.Text)) > Convert.ToInt16(cabinCapacity)) //Checks that capacity isnt exceeded
                {
                    MessageBox.Show(string.Format("Extended Capacity\nThe capacity of this Cabin is {0}", cabinCapacity));
                    btnMakeABookingPay.Enabled = false;
                    return;
                }
            }
            catch //If a error occurs, it is caused by one of the user inputs for adults/children containing letters and/or special characters
            {
                MessageBox.Show("Please remove all letters and other characters from the adults and children fields");
                btnMakeABookingPay.Enabled = false;
                return;
            }

            decimal price = CalculatePriceORSeason.CalculatePrice(dtpMakeABookingCAStartDate.Value, dtpMakeABookingCAEndDate.Value, comboMakeABookingType.Text, txtMakeABookingAdults.Text, txtMakeABookingChildren.Text); //Calls the calculate price method

            lblQuotePrice.Text = string.Format("Price = £{0}", price.ToString()); //Displays the price on a label
            btnMakeABookingPay.Enabled = true;

            grpMakeABookingSelectCustomer.Visible = true; //Makes step 3 of the booking form visible
        }

        private void btnMakeABookingBook_Click(object sender, EventArgs e)//Event handler for finding a existing customer, Sets the datasource of the datagridview equal to the search results
        {
            dgvMakeABookingCustomerAccount.DataSource = dataGridViewStuff.customerDetails(txtMakeABookingLastName.Text, dtpMakeABookingDOB.Value); 
            dgvMakeABookingCustomerAccount.Visible = true; 
        }

        private void btnMakeABookingAddCustomer_Click(object sender, EventArgs e) //Event handler for creating a new customer
        {
            AddCustomer frm = new AddCustomer(lblMakeABookingStaffDetails.Text); //Creates a new instance of the AddCustomer form
            frm.ShowDialog(); //Shows the form

            custID = frm.CustIDofMadeCustomer; //Sets custoID equal to the auto-incremented CustomerId that is returned from the Add Customer form
            frm.Close(); //CLoses the form

            if (custID == 0) //This if statement stops a error that can arises whenever the Add Customer form is opened, then closed again without any further interaction with Add Customer form
            {
                MessageBox.Show(string.Format("An error occured while trying to retrieve the CustomerID\nPlease retry adding the customer"));
            }

            lblMakeABookingCustIDSelected.Text = string.Format("Customer ID: {0}", custID); //Shows the CustomerID on a label
            btnMakeABookingPay.Visible = true; //Makes the final stage of the booking process visible
        }

        private void btnMakeABookingPay_Click(object sender, EventArgs e) //Event handler that begins the start of the payment process
        {
            BOOKINGDetails newBooking = new BOOKINGDetails(); //Creates a new instance of the BOOKINGSDetails collection
            try
            {
                newBooking.CabinNo = Convert.ToInt16(comboMakeABookingCabinNo.Text.Trim());
                newBooking.NumOfAdults = txtMakeABookingAdults.Text.Trim();
                newBooking.NumOfChildren = txtMakeABookingChildren.Text.Trim();
                newBooking.StartDate = dtpMakeABookingCAStartDate.Value;
                newBooking.EndDate = dtpMakeABookingCAEndDate.Value;
                newBooking.Season = CalculatePriceORSeason.findOutSeason(dtpMakeABookingCAStartDate.Value);
                newBooking.Price = retrieveIDs.getAmountPaid(lblQuotePrice.Text.Trim());
            }
            catch (Exception)
            {
                unAssociatedMethods.genericErrorMessage("This was caused during the filling of a new booking's data", "50006");
                return;
            }


            var validator = new BOOKINGValidator(); //Creates a new instance of the BOOKINGDetails validator
            if (!validator.Validate(newBooking)) //If the BOOKINGDetails validator returns false, then a validator fault was detected
            {
                MessageBox.Show("BOOKING has not been added or processed");
                return;
            }

            AddPayment frm = new AddPayment(toolStripLabel1.Text, custID, newBooking); //Creates a new instance of the Add Payment form

            frm.ShowDialog();
            this.Close();
        }

        private void txtBack_Click(object sender, EventArgs e) //closes the Make a Booking form
        {
            this.Close();
        }

        private void dgvMakeABookingCustomerAccount_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) //Event handler that is triggered by a row header being selected
        {
            custID = Convert.ToInt16(dgvMakeABookingCustomerAccount.SelectedRows[0].Cells[0].Value.ToString()); //Converts the CustomerID of the selected row to integer
            lblMakeABookingCustIDSelected.Text = string.Format("Customer ID: {0}", custID); //Displays the customerId on a label

            btnMakeABookingPay.Visible = true;//Makes the final stage of the Booking Process visible
        }

        private void stepOneComboUpdates(object sender, EventArgs e)///Updates the groupboxes that contains data relietent on those inputs.
        {
            if (grpMakeABooking.Visible == true)
            {
                btnMakeABookingCA.PerformClick();
                txtMakeABookingAdults.Text = "";
                txtMakeABookingChildren.Text = "";
            }
        }

        private void stepTwoComboUpdates(object sender, EventArgs e)///Updates the groupboxes that contains data relietent on those inputs
        {
            if (grpMakeABookingSelectCustomer.Visible == true)
            {
                btnMakeABookingGetAQuote.PerformClick();
            }
        }                                  

        private void MakeABooking_Load(object sender, EventArgs e)
        {
            unAssociatedMethods.set(this.Controls); //Loads fonts and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
            this.Icon = Properties.Resources.hughesLogo;

            toolStripBtnLock.Tag = toolStripLabel1.Text.ToString();

            dtpMakeABookingCAStartDate.Value = DateTime.Now; //Sets the datetimepickers on the form
            dtpMakeABookingCAEndDate.Value = DateTime.Now.AddDays(1);
        }

    }

    class CalculatePriceORSeason
    {
        public static decimal CalculatePrice(DateTime startDate, DateTime endDate, string cabinType, string stringNumOfAdults, string stringNumOfChildren) //Main public method of the class
        {

            ///price per day = (((num of adult * priceOfAdults) + (num of children * priceOfChild)) * type) + season
            ///price for wholetrip = (price per day * totaldays)

            string season = findOutSeason(startDate); //Fetchs season
            decimal seasonPrice = findOutSeasonPrice(season); //Fetchs season price according to the Season

            double totalDays = findTotalDays(startDate, endDate); //Fetchs number of days the trip lasts
            decimal priceOfCabinType = cabinPrice(cabinType); //Fetchs the cabin Price for that cabin type

            int numOfAdults = Convert.ToInt16(stringNumOfAdults);//Converts number of adults to integer
            int numOfChildren = Convert.ToInt16(stringNumOfChildren); //converts number of children to integer

            decimal pricePerDay = Convert.ToDecimal(((((numOfAdults * Properties.Settings.Default.priceOfAdult) + (numOfChildren * Properties.Settings.Default.priceOfChild)) * priceOfCabinType) + seasonPrice)); //Caculates the price of one day (The properties.Settings.Default.... are user defined constants for the price formula. They can be changed at any time by a admin)
            decimal decTotalDays = Convert.ToDecimal(totalDays); ///HAD TO CONVERT TO DECIMAL BECAUSE DOUBLE CANT MULITPLY A DECIMAL
            decimal priceForWholeTrip = (pricePerDay * decTotalDays); //Calculates price for whole trip

            priceForWholeTrip = decimal.Round(priceForWholeTrip, 2); //Rounds to 2 decimal points
            return priceForWholeTrip; //Returns the price to calling method

        }

        public static string findOutSeason(DateTime startDate)  /////the season is calculated using the startdate, so even if you stay long enough that it changes season, the customer is still priced for their stating season rate
        {

            int month = Convert.ToInt16(startDate.ToString("MM"));
            string season;
            ///spring, summer, autumn, winter
            ///feb-april,june-aug, sept-jan
            ///low season = sept-jan
            ///mid season = feb-may
            ///high season = june-aug

            if ((month >= 02) && (month <= 05)) //The numbers, i.e 02 & 05 are months, febuary and may respectively
            {
                season = "mid";
            }
            else
            {
                if ((month >= 06) && (month <= 08))
                {
                    season = "high";
                }
                else
                {
                    season = "low";
                }

            }

            return season; //Returns the season that the trip takes place in
        }

        private static double findTotalDays(DateTime startDate, DateTime endDate) //Calculates the total days the trip lasts and returns the value in dobule format
        {
            double totalDays = (endDate - startDate).TotalDays;
            return totalDays;
        }

        private static decimal cabinPrice(string type) //Calculates cabinPrice of cabin type using a switch-case statement. Returns price in decimal format
        {

            switch (type)
            {
                case "Master":
                    return Properties.Settings.Default.masterCabinPrice;
                case "Platinum":
                    return Properties.Settings.Default.platinumCabinPrice;
                case "Gold":
                    return Properties.Settings.Default.goldCabinPrice;
                case "Silver":
                    return Properties.Settings.Default.silverCabinPrice;
                case "Bronze":
                    return Properties.Settings.Default.bronzeCabinPrice;
                default:
                    MessageBox.Show("error finding the type price, price has been set to £20"); ///have a input box to manually enter instead
                    return 20;
            }
        }

        private static decimal findOutSeasonPrice(string season) //Calculates Season price using a switch-case statement
        {
            switch (season)
            {
                case "low":
                    return Properties.Settings.Default.lowSeasonPrice;
                case "mid":
                    return Properties.Settings.Default.midSeasonPrice;
                case "high":
                    return Properties.Settings.Default.highSeasonPrice;
                default:
                    MessageBox.Show("Error finding season, price set to mid season"); ///have a input box to manually enter instead
                    return 5;
            }
        }

    }
}
