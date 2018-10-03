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
    public partial class AddCustomer : Form
    {

        public int CustIDofMadeCustomer;

        public AddCustomer(String StaffMembersDetails)
        {
            InitializeComponent();

            toolStripLabel1.Text = StaffMembersDetails;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Today;

            toolStripBtnLock.Tag = toolStripLabel1.Text.ToString();

            unAssociatedMethods.set(this.Controls); //loads the font and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
            this.Icon = Properties.Resources.hughesLogo;
        }

        private void btnAdd_Click(object sender, EventArgs e) //Begins the first stage of adding the customer to the database
        {

            CUSTOMERDetails newCustomer = new CUSTOMERDetails(); //Creates a new instance of the CUSTOMERDetails collection
           try
           {
               newCustomer.Title = txtTitle.Text.Trim();
               newCustomer.FirstName = txtFirstName.Text.Trim();
               newCustomer.LastName = txtLastName.Text.Trim();
               newCustomer.DateOfBirth = dtpDOB.Value;
               newCustomer.Address = txtAddress.Text.Trim();
               newCustomer.Town = txtTown.Text.Trim();
               newCustomer.PostCode = txtPostCode.Text.Trim();
               newCustomer.PhoneNo = txtPhoneNo.Text.Trim();
               newCustomer.Email = txtEmail.Text.Trim();
           }
           catch (Exception)
           {
               unAssociatedMethods.genericErrorMessage("This was caused during the filling of a new customer's data", "50001");
               return;
           }

           var validator = new CUSTOMERValidator(); //Creates a new instance of the add customer validator
           if (!validator.Validate(newCustomer)) //If the validator returns false, then the process of adding customers to database is cancelled
           {
               MessageBox.Show("CUSTOMER has not been added or processed");
               return;
           }

           CustIDofMadeCustomer = addToDatabase.addCustomer(newCustomer); ///Passes the CUSTOMERDetails to the second stage of adding to the database, The method also returns the auto-incremented customerID for the new record

           if (CustIDofMadeCustomer != -1) ///When the form closes, the customerID is returned to a method if it was called by a method. 
           {
               this.Close();
               return;
           }
        }

        private void btnBack_Click(object sender, EventArgs e) //Closes the add customer form
        {
            this.Close();
        }
    }
}
