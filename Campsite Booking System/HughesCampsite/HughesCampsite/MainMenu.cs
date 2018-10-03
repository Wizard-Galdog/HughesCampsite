using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace HughesCampsite
{
    public partial class MainMenu : Form
    {
        List<Image> images = new List<Image>();   ///These 3 lines of code are responsible for intionating the splashscreen on the MainMenu
        int value = 1;
        private static System.Timers.Timer aTimer;


        public MainMenu(string StaffMembersDetails)
        {
            InitializeComponent();

            toolStripLabel1.Text = string.Format("Signed in as: {0}", StaffMembersDetails);
        }

        private void btnMainMenuAddCustomer_Click(object sender, EventArgs e) //Loads up the add customer form
        {
            AddCustomer newCustomer = new AddCustomer(toolStripLabel1.Text);
            newCustomer.ShowDialog();
        }

        private void btnMainMenuMakeABooking_Click(object sender, EventArgs e) //Loads up the Make a Booking form
        {
            MakeABooking newBooking = new MakeABooking(toolStripLabel1.Text);
            newBooking.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (Database.staffPrivileges(toolStripLabel1.Text) == false) //Checks database privileges and disables buttons if the user isnt a admin
            {
                btnMainMenuAddStaff.Enabled = false;
                btnMainMenuAddCabin.Enabled = false;
                btnCabinPrices.Enabled = false;
            }

            toolStripBtnLock.Tag = toolStripLabel1.Text.ToString(); 

            unAssociatedMethods.set(this.Controls);  //Loads the font and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
            this.Icon = Properties.Resources.hughesLogo;

            populateList();  //Fills the image collection

            aTimer = new System.Timers.Timer(5000); //Starts the time
            aTimer.Elapsed += HandleTimerElapsed;
            aTimer.Interval = 10000;
            aTimer.Enabled = true;
        }


        private void btnMainMenuAddStaff_Click(object sender, EventArgs e) //Loads up the add staff form
        {
            AddStaff frm = new AddStaff(toolStripLabel1.Text);
            frm.ShowDialog();

        }

        private void btnMainMenuAddCabin_Click(object sender, EventArgs e) //Loads up the Add Cabin form
        {
            AddCabin frm = new AddCabin(toolStripLabel1.Text);
            frm.Show();
        }

        private void btnMainMenuLookUp_Click(object sender, EventArgs e) //Loads up the Lookup form
        {
            LookUp frm = new LookUp(toolStripLabel1.Text);
            frm.ShowDialog();
        } 

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e) //If the main menu form is closed, this event handler is called. Which exits the application
        {
            Application.Exit();
        } 


        private void btnOverView_Click(object sender, EventArgs e) //Loads up the OverView form
        {
            OverView frm = new OverView(toolStripLabel1.Text);
            frm.ShowDialog();
        }



        private void populateList()  //Populates the image collection with the selected images to be included in the slideshow
        {
            images.Add(HughesCampsite.Properties.Resources.Campsite_1);
            images.Add(HughesCampsite.Properties.Resources.Campsite_2);
            images.Add(HughesCampsite.Properties.Resources.Campsite_3);
        }


        public void HandleTimerElapsed(object sender, ElapsedEventArgs e)  //The event handler called by the timer whenever its programmer defined time has elapsed
        {
            try
            {
                pictureBox1.Image = images[value]; //Replaces image with next image in collection
                value += 1;  //Increments i
            }
            catch   //Whenever the collecition hits the end of its contents, a out of bounds exception will be triggered. This catch will stop that and reset i to the beginning of the collection again
            {
                pictureBox1.Image = images[0];
                value = 0;
            }
        }

        private void btnCabinPrices_Click(object sender, EventArgs e) //Loads up the cabin price form
        {
            cabinPrices frm = new cabinPrices(toolStripLabel1.Text);
            frm.ShowDialog();
        }
    }
}
