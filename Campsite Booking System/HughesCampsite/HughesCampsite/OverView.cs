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
    public partial class OverView : Form
    {
        public OverView(string staffMembersDetails)
        {
            InitializeComponent();
            toolStripLabel1.Text = staffMembersDetails;

        }

        private void OverView_Load(object sender, EventArgs e)
        {
            unAssociatedMethods.set(this.Controls); //Loads fonts and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
            this.Icon = Properties.Resources.hughesLogo;

            int staffid = retrieveIDs.getStaffIdUsingTheString(toolStripLabel1.Text);
            dgvMainMenuRecentBookings.DataSource = dataGridViewStuff.showStaffsMostRecentBookings(staffid); //Sets datasource of the datagridview to display the staffmembers most recent bookings
            dgvMainMenuDepartures.DataSource = dataGridViewStuff.todaysDepartures(); //Sets the datasource of the datagridview to display todays departures
            dgvMainMenuTodayArrivals.DataSource = dataGridViewStuff.todaysArrivals(); //Sets the datasource of the datagridview to display todays arrivals

            toolStripBtnLock.Tag = toolStripLabel1.Text.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e) //Event handler that closes the form
        {
            this.Close();
        }


    }
}
