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
    public partial class LockScreen : Form
    {
        public LockScreen(string staffDetails)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            lblUserName.Text = staffDetails;

        }

        private void btnSignIn_Click(object sender, EventArgs e) //Checks UserName and password creditientals
        {
            if (Database.loginFromLocked(lblUserName.Text, txtLockScreenPassword.Text) == true) //If true is returned, then the login crenditenals are correct and the lock form is closed
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
        }

        private void LockScreen_Load(object sender, EventArgs e)
        {
            unAssociatedMethods.set(this.Controls); //Loads font and form settings
            this.Icon = Properties.Resources.hughesLogo;

            System.Windows.Forms.Screen src = System.Windows.Forms.Screen.PrimaryScreen; //Sets this form as the main form, and cant be changed
        }

        private void LockScreen_Click(object sender, EventArgs e) //Eventhandler that is called when ever the lock screen is clicked. It makes all labels on the invoice form visible
        {
            lblUserName.Visible = true;
            lblPassword.Visible = true;
            txtLockScreenPassword.Visible = true;
            btnSignIn.Visible = true;
            btnLogOut.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e) //Event handler that calls the logout method, these can be used to 'free' a locked station
        {
            unAssociatedMethods.logOut();
        }
    }
}
