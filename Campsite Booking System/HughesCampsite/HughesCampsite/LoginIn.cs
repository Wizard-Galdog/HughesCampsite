using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HughesCampsite
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {

            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            using (SplashScreen frm = new SplashScreen())  //Loads up the splashscreen before the login menu is loaded
            {
                frm.ShowDialog();
                SplashScreen fc = Application.OpenForms["SplashScreen"] != null ? (SplashScreen)Application.OpenForms["SplashScreen"] : null;
                while (fc != null)
                {
                    continue;
                }
            }

            Database.checkConnection();

            unAssociatedMethods.loadDefaultProperties();     //resets the user font settings during startup  
            this.Icon = Properties.Resources.hughesLogo;

            unAssociatedMethods.set(this.Controls);          //Loads the font settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);

        }

        private void btnMainMenuLogIn_Click(object sender, EventArgs e)
        {
            if ((txtUserName.Text == "") || (txtPassWord.Text == "")) //Validation on the User & Password inputs
            {
                MessageBox.Show("Please fill in data for the UserName and Password");
                return;
            }

            string StaffMembersDetails = Database.staffLogin(txtUserName.Text, txtPassWord.Text); //Checks login details & if correct, returns the Staff members Name and StaffID
            if ( StaffMembersDetails == "null")  //The Database.staffLogin method returns null if the login creditentials are incorrect.        ////The Database.StaffLogin method returns string, hence the reason null is returned and not false
            {
                MessageBox.Show("Incorrect UserName and Password combination");
                return;
            }

            MainMenu newMainMenu = new MainMenu(StaffMembersDetails); //Loads up the MainMenu form
            newMainMenu.Show();
            this.Hide();
        }

    }
}
