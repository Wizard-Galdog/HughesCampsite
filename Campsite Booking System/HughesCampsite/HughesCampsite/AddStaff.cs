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
    public partial class AddStaff : Form
    {
        public AddStaff(string StaffDetails)
        {
            InitializeComponent();

            toolStripLabel1.Text = StaffDetails;


        }

        private void btnAddStaffMember_Click(object sender, EventArgs e) //Event handler triggered by pressing the Add button
        {
            STAFFDetails newStaffMember = new STAFFDetails(); //Creates a new instance of the STAFFDetails collection
            try
            {
                newStaffMember.Title = txtAddStaffTitle.Text.Trim();
                newStaffMember.FirstName = txtAddStaffFirstName.Text.Trim();
                newStaffMember.LastName = txtAddStaffLastName.Text.Trim();
                newStaffMember.DateOfBirth = dtpAddStaffDOB.Value;
                newStaffMember.Address = txtAddStaffAddress.Text.Trim();
                newStaffMember.Town = txtAddStaffTown.Text.Trim();
                newStaffMember.PostCode = txtAddStaffPostCode.Text.Trim();
                newStaffMember.PhoneNo = txtAddStaffPhoneNo.Text.Trim();
                newStaffMember.Email = txtAddStaffEmail.Text.Trim();
                newStaffMember.UserName = txtAddStaffUserName.Text.Trim();
                newStaffMember.Password = txtAddStaffPassword.Text.Trim();
                newStaffMember.Privileges = comboPrivileges.Text.Trim();
            }
            catch (Exception)
            {
                unAssociatedMethods.genericErrorMessage("This was caused during the filling of a new staff member's data", "50004");
                return;
            }

            var validator = new STAFFValidator(); //Creates a new instance of the STAFFDetails validator
            if(!validator.Validate(newStaffMember)) //If the validator returns false, then that means a validation issue was flagged. Adding of the Staff member will be stopped
            {
                MessageBox.Show("Staff member has not been added");
                return;
            }
            
            addToDatabase.addStaff(newStaffMember); //Begins the second process of adding the Staff Member to the database
        }

        private void btnBack_Click(object sender, EventArgs e) //Event handler that closes the form
        {
            this.Close();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            toolStripBtnLock.Tag = toolStripLabel1.Text.ToString();

            unAssociatedMethods.set(this.Controls); //Loads font and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
            this.Icon = Properties.Resources.hughesLogo;
        }
    }
}
