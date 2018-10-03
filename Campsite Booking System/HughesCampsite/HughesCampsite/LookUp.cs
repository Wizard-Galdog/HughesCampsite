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
    public partial class LookUp : Form  /////ONLY ADMINS SHOULD BE ABLE TO DELETE STAFF AND VIEW + EDIT THEIR USERNAME    ////MAKE A REFRESH BUTTON
    {
        //Make accesible to every method in this class because alot of methods require access to these variables, even though they have very little relations to eachother
        public static bool dataTableBeingLoadedIntoDgv = false; //The reason these variable is used, is because the datagridview has a datachanged event, to prevent this being called whenever a new data table is loaded in, this is set to true and the event handler will know that a datatable is being loaded in
        refreshMethodsData refreshDataCollection = new refreshMethodsData();

        public LookUp(string staffDetails)
        {
            InitializeComponent();

            toolStripLabel1.Text = staffDetails;

        }
        
        private void btnSearch_Click(object sender, EventArgs e) //Begins the lengthy process of displaying the search results on the datagridview
        {
            RadioButton selectSearchParameter = findCurrentlySelectedRadioButton(); //Finds curerently selected redio button(Therefore finding out what table the user wants to search)
            
            string stringSelectSearchParameter; //Declare here because if it was declared in the try catch, then it wouldnt be accisble by switch case
            try
            {
                stringSelectSearchParameter = selectSearchParameter.Name; //If search is clicked and yet no radio button is selected, the previous method called(findCurrentlySelectRadioButton) with return null, hence the null reference exception will be caught
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please select a radiobutton");
                return;
            }

            dataTableBeingLoadedIntoDgv = true;
            refreshDataCollection.changeStartingAttributes = true;

            switch (stringSelectSearchParameter) //Determines the set of variables that should be assigned and methods that should be run based on the radio button name
            {
                case "radioCustomer":
                    dgvSearchs.DataSource = dataGridViewStuff.customerDetails(txtCustomerLastName.Text, dtpCustomerDOB.Value); //Displays customer search results
                    refreshDataCollection.startingKeysName = "CustomerID";
                    break;

                case "radioBooking":
                    dgvSearchs.DataSource = dataGridViewStuff.bookingDetails(dtpBookingStartDate.Value, dtpBookingEndDate.Value); //Displays Booking search results
                    refreshDataCollection.startingKeysName = "BookingID";
                    break;

                case "radioPayments":
                    dgvSearchs.DataSource = dataGridViewStuff.paymentDetails(txtPaymentNameOnCard.Text, txtPaymentCardNumber.Text); //Displays Payment search results
                    refreshDataCollection.startingKeysName = "PaymentID";
                    break;

                case "radioStaff":
                    dgvSearchs.DataSource = dataGridViewStuff.staffDetails(txtStaffLastName.Text, dtpStaffDateOfBirth.Value); //Displays staff search records
                    refreshDataCollection.startingKeysName = "StaffID";
                    break;
                    
                case "radioCabin":
                    dgvSearchs.DataSource = dataGridViewStuff.cabinDetails(comboCabinType.Text); //Displays cabin search records
                    refreshDataCollection.startingKeysName = "CabinNO";
                    break;

                default:
                    refreshDataCollection.changeStartingAttributes = false;
                    break;
            }
            dataTableBeingLoadedIntoDgv = false;
        }

        private void radioButtons(object sender, EventArgs e) //A switch case statment that changes radio buttons selected. These event handler is called whenever a 
        {

            RadioButton radioBtn = (RadioButton)sender;
            RadioButton r = findCurrentlySelectedRadioButton();
            try
            {
                r.Checked = false;
            }
            catch (System.NullReferenceException) //If a nullReferenceException is caught, then that means that their was no previous radioButton selected. 
            {

            }
            
            switch (radioBtn.Name) //Determines the RadioButton that triggered this event handler(all the radio buttons share this handler) and then performs a switch case on it's name to check it
            {
                case "radioCustomer":
                    radioCustomer.Checked = true;
                    break;

                case "radioBooking":
                    radioBooking.Checked = true;
                    break;

                case "radioPayments":
                    radioPayments.Checked = true;
                    break;

                case "radioStaff":
                    radioStaff.Checked = true;
                    break;

                case "radioCabin":
                    radioCabin.Checked = true;
                    break;

                default:
                    break;
            }
             
        }

        private RadioButton findCurrentlySelectedRadioButton() //Returns the radioButton that is currently selected
        {
            
            if (radioCustomer.Checked == true)
            {
                return radioCustomer;
            }

            if (radioBooking.Checked == true )
            {
                return radioBooking;
            }

            if (radioPayments.Checked == true)
            {
                return radioPayments;
            }

            if (radioStaff.Checked == true)
            {
                return radioStaff;
            }

            if (radioCabin.Checked == true)
            {
                return radioCabin;
            }
            return null;
        }

        private void showButtons(object sender, EventArgs e) //Main process of these form
        {
            Button btn = (Button)sender; //Creates a new instance of a button ,with exactly same characteristics as the calling button
            string keysName; //This 2 variables are declared here, since they are used ina try catch and must be within scope for other processes that wish to access there data
            string stringKeysValue;

            refreshDataCollection.tableToLinkTo = "LINKTABLE"; //These is default, since the only table that doesnt connect to the linktable is the cabin table

            try
            {
                keysName = dgvSearchs.Columns[0].HeaderText.ToString(); //Finds the keys name (i.e CustomerID, BookingID)
                stringKeysValue = dgvSearchs.SelectedRows[0].Cells[0].Value.ToString(); //Finds the keys value (i.e if the Customer ID is 4, then these variable has a string value of 4)
            }
            catch (System.ArgumentOutOfRangeException) //The index starts at the row header, hence if any other cell is selected, a error code will appear
            {
                MessageBox.Show("Please select a Row Header");
                return;
                throw;
            }

            if (refreshDataCollection.changeStartingAttributes == true)
            {
                refreshDataCollection.startingKeysValue = stringKeysValue;
                refreshDataCollection.changeStartingAttributes = false;
            }



            ///BELOW SWITCH CASE
            //Switch case for the calling button name
            //Runs the respective code for the correct case
            //EX) if btn is btnShowCustomer
            //Its case will be triggered
            //its targetKeysName, targetTable and whatToGetFromTheTable will be updated to its respective values
            
            switch (btn.Name)
            {
                case "btnShowCustomer":
                    refreshDataCollection.targetKeysName = "CustomerID";
                    refreshDataCollection.targetTable = "CUSTOMERS";
                    refreshDataCollection.whatToGetFromTheTable = string.Format("{0}.CustomerID, {0}.FirstName, {0}.LastName, {0}.DateOfBirth, {0}.Address, {0}.Town, {0}.PostCode, {0}.PhoneNo, {0}.Email", "CUSTOMERS");
                    break;

                case "btnShowBooking":

                    if (refreshDataCollection.targetTable == "CABIN")
                    {
                        refreshDataCollection.startingKeysValue = stringKeysValue;
                    }

                    refreshDataCollection.targetKeysName = "BookingID";
                    refreshDataCollection.targetTable = "BOOKING";
                    refreshDataCollection.whatToGetFromTheTable = string.Format("{0}.BookingID, {0}.CabinNo, {0}.NumOfAdults, {0}.NumOfChildren, {0}.StartDate, {0}.EndDate, {0}.Season, {0}.Price", "BOOKING");
                    break;

                case "btnShowPayment":
                    refreshDataCollection.targetKeysName = "PaymentID";
                    refreshDataCollection.targetTable = "PAYMENTS";
                    refreshDataCollection.whatToGetFromTheTable = string.Format("{0}.PaymentID, {0}.PaymentType, {0}.NameOnCard, {0}.CardNumber, {0}.SecurityCode, {0}.ExpiryDate, {0}.AmountPaid, {0}.DatePaid", "PAYMENTS");
                    break;

                case "btnShowStaff":
                    refreshDataCollection.targetKeysName = "StaffID";
                    refreshDataCollection.targetTable = "STAFF";
                    refreshDataCollection.whatToGetFromTheTable = string.Format("{0}.StaffID, {0}.Title, {0}.FirstName, {0}.LastName, {0}.DateOfBirth, {0}.Address, {0}.Town, {0}.PostCode, {0}.PhoneNo, {0}.Email", "STAFF");
                    break;

                case "btnShowCabin":
                    refreshDataCollection.targetKeysName = "CabinNo";
                    refreshDataCollection.targetTable = "CABIN";
                    refreshDataCollection.tableToLinkTo = "BOOKING";
                    refreshDataCollection.whatToGetFromTheTable = string.Format("{0}.CabinNo, {0}.CabinDesc, {0}.CabinCapacity, {0}.CabinType", "CABIN");
                    refreshDataCollection.startingKeysValue = stringKeysValue;
                    break;

                default:
                    MessageBox.Show("An Error has Occured \n Error Code: 0f65");
                    refreshDataCollection.changeStartingAttributes = false;
                    return;
            } 
            

            int keysValue = Convert.ToInt16(stringKeysValue);

            if (keysName == "CabinNo")
            {
                refreshDataCollection.targetKeysName = "CabinNo";
                refreshDataCollection.tableToLinkTo = "CABIN";
                refreshDataCollection.targetTable = "BOOKING";
            }

            dataTableBeingLoadedIntoDgv = true;

            DataTable dt = dataGridViewStuff.showSelectedTableDetails(keysName, keysValue, refreshDataCollection.targetTable, refreshDataCollection.targetKeysName, refreshDataCollection.whatToGetFromTheTable, refreshDataCollection.tableToLinkTo); //Fetchs the datatable
            if (dt != null) ///if the dt is null, then i dont want to basically clear the datagridview because then the person has to search again and i want to try and keep this process calling to a minimuim where possible
            {
                dgvSearchs.DataSource = dt;
            }
            dataTableBeingLoadedIntoDgv = false;
        } 


        private void btnDelete_Click(object sender, EventArgs e) //Event handler that deletes the selected record
        {
            string keysName;
            string stringKeysValue;
            try
            {
                keysName = dgvSearchs.Columns[0].HeaderText.ToString();
                stringKeysValue = dgvSearchs.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (System.ArgumentOutOfRangeException) //The index starts at the row header, hence if any other cell is selected, a error code will appear
            {
                MessageBox.Show("Please select a Row Header");
                return;
                throw;
            }

            if (keysName == "CabinNo") //Its most efficent to make a cabin inactive rather than delete its records
            {
                DialogResult result = MessageBox.Show("Would you rather make the selected CabinNo inactive rather than Delete it? \nDeleting it will cause all its associated bookings and their associted payments to be deleted.\nThis can take a long time depending on how many bookings for this cabin exist", "Delete or make Invalid?", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    deleteFromDatabase.findAllBookingIdsForThatCabin(dgvSearchs.SelectedRows[0].Cells[0].Value.ToString()); //Will delete the record and bookings assoicated with it
                    return;
                }
                Database.setACabinInvalid(dgvSearchs.SelectedRows[0].Cells[0].Value.ToString()); //Sets the field 'CabinDesc' equal to 'inactive', This means that it will never be shown available 
                return;
            }
            
            deleteFromDatabase.deleteLinks(keysName, stringKeysValue);
        }

        private void btnEnableEdit_Click(object sender, EventArgs e) //Simply enables and disables editing based on 2 if statements
        {
            if (btnEnableEdit.Text == "Disable Editing")
            {
                dgvSearchs.ReadOnly = true;
                lblEditingIsEnabled.Visible = false;
                btnEnableEdit.Text = "Enable Editing";
                return;
            }

            DialogResult result = MessageBox.Show("WARNING: Editing is Auto-Saved\nClick outside of the cell to save its changes", "Endable editing mode?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dgvSearchs.ReadOnly = false;
                dgvSearchs.Columns[0].ReadOnly = true;
                lblEditingIsEnabled.Visible = true;
                btnEnableEdit.Text = "Disable Editing";
            }
        }


        private void dgvSearchs_CellValueChanged(object sender, DataGridViewCellEventArgs e) //Event handler that is automatically called whenever data is a call is changed
        {
            if (dataTableBeingLoadedIntoDgv == true) //Checks weather or not a datatable is being loaded in, if one is. Then the rest of this method isnt run
            {
                return;
            }

            string changeToBeSaved = dgvSearchs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(); //Declares and sets variables
            string nameOfColumnChanged = dgvSearchs.Columns[e.ColumnIndex].HeaderText.ToString();
            string keysName = dgvSearchs.Columns[0].HeaderText.ToString();
            string stringKeysValue = dgvSearchs.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (string.IsNullOrEmpty(stringKeysValue) == true) //This detects if the user is trying to add a whole new record into the database using the datagridview editing method, instead of using the in built add form for the respective procedure. If this if statement wasnt here, it would allow users to bypass validation on every table
            {
                dataTableBeingLoadedIntoDgv = true;
                dgvSearchs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                dataTableBeingLoadedIntoDgv = false;
                MessageBox.Show("Please use the default procedures to add data\nThis is because the default procedures obey the database relations");
                return;
            }

            
            updateDatabase.updateTable(changeToBeSaved, nameOfColumnChanged, keysName, stringKeysValue); //Updates the table

            lblChangesSaved.Text = string.Format("Changes to {0} have been saved and updated to {1}", changeToBeSaved, nameOfColumnChanged); //Just a label that confirms to the user what was saved
            lblChangesSaved.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e) //Event handler that closes the form
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e) //Event handler for the refresh button
        {
            dataTableBeingLoadedIntoDgv = true;
            if (refreshDataCollection.targetTable == "CABIN")
            {
                refreshDataCollection.startingKeysName = "BookingID";
            }

            if ((refreshDataCollection.targetTable == "BOOKING") && (dgvSearchs.Columns[1].HeaderText.ToString() == "CabinNo")) //This a a very indirect way of finding out that the current table loaded into the datagridview is the booking table and that the user 'hopped' from the cabin table
            {
                refreshDataCollection.startingKeysName = "CabinNo";
            }

            DataTable dt = dataGridViewStuff.showSelectedTableDetails(refreshDataCollection.startingKeysName, Convert.ToInt16(refreshDataCollection.startingKeysValue), refreshDataCollection.targetTable, refreshDataCollection.targetKeysName, refreshDataCollection.whatToGetFromTheTable, refreshDataCollection.tableToLinkTo); //Simply runs the method that displays the datatable
            if (dt != null) ///if the dt is null, then i dont want to basically clear the datagridview because then the person has to search again and i want to try and keep this process calling to a minimuim where possible
            {
                dgvSearchs.DataSource = dt;
            }

            dataTableBeingLoadedIntoDgv = false;
        }

        private void LookUp_Load(object sender, EventArgs e)
        {
            toolStripBtnLock.Tag = toolStripLabel1.Text.ToString();

            unAssociatedMethods.set(this.Controls); //Loads font and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
            this.Icon = Properties.Resources.hughesLogo;

            if (Database.staffPrivileges(toolStripLabel1.Text) == false) //Checks user privileges and disables the ability to access staff records if not a admin
            {
                grpStaff.Enabled = false;
                btnShowStaff.Enabled = false;
            }

            btnUpRecord.Text = "Up Record " + char.ConvertFromUtf32(8593); //Puts arrows into the text of these buttons
            btnDownRecord.Text = "Down Record " + char.ConvertFromUtf32(8595);
        }

        private void btnUpRecord_Click(object sender, EventArgs e) ///Simply Changes the selected row in the datagridview to the one above the currently selected one
        {
            try
            {
                int index = dgvSearchs.CurrentRow.Index;
                dgvSearchs.Rows[index].Selected = false;
                dgvSearchs.Rows[index - 1].Selected = true;
            }
            catch //Stops the error that arises when the user is at the first('top') record and clicks this button
            {
                MessageBox.Show("Cant go up a record!");
            }
        }

        private void btnDownRecord_Click(object sender, EventArgs e) ///Simply Changes the selected row in the datagridview to the one below the currently selected one
        {
            try
            {
                int index = dgvSearchs.CurrentRow.Index;
                dgvSearchs.Rows[index].Selected = false;
                dgvSearchs.Rows[index + 1].Selected = true;
            }
            catch//Stops the error that arises when the user is at the last('bottom') record and clicks this button
            {
                MessageBox.Show("Cant go down a record!");
            }
        }

    }

    public class refreshMethodsData //This collection class is used store related data variables that are used for searching,editing,deleting and refreshing
        {
        public string startingKeysName { get; set; }
        public string startingKeysValue { get; set; }

        public string targetTable { get; set; }
        public string targetKeysName { get; set; }
        public string targetKeysValue { get; set; }

        public string whatToGetFromTheTable { get; set; }
        public string tableToLinkTo { get; set; }
        public bool changeStartingAttributes { get; set; }

        public refreshMethodsData() //This is the default values of the collection whenever a new instance is delcared
            {
                tableToLinkTo = "LINKTABLE";
                changeStartingAttributes = false;
            }
        }
}
