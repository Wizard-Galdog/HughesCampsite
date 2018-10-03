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
    public partial class cabinPrices : Form
    {
        public cabinPrices(string staffMembersDetails)
        {
            InitializeComponent();

            toolStripLabel1.Text = staffMembersDetails;
        }

        private void cabinPrices_Load(object sender, EventArgs e)
        {
            toolStripBtnLock.Tag = toolStripLabel1.Text.ToString();

            unAssociatedMethods.set(this.Controls); //Loads font and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
            this.Icon = Properties.Resources.hughesLogo;

            loadCabinPrices(); //Loads current user defined values from properties.settings.default...
        }

        private void loadCabinPrices() //Sets the text of every input field on the form equal to its current respective value (i.e the master cabin price is £20 in the default settings, therefore the master cabin price has a text value of £20 on inital loading of the form
        {
            txtLowSeasonPrice.Text = Properties.Settings.Default.lowSeasonPrice.ToString();
            txtMidSeasonPrice.Text = Properties.Settings.Default.midSeasonPrice.ToString();
            txtHighSeasonPrice.Text = Properties.Settings.Default.highSeasonPrice.ToString();

            txtMasterCabinPrice.Text = Properties.Settings.Default.masterCabinPrice.ToString();
            txtPlatinumCabinPrice.Text = Properties.Settings.Default.platinumCabinPrice.ToString();
            txtGoldCabinPrice.Text = Properties.Settings.Default.goldCabinPrice.ToString();
            txtSilverCabinPrice.Text = Properties.Settings.Default.silverCabinPrice.ToString();
            txtBronzeCabinPrice.Text = Properties.Settings.Default.bronzeCabinPrice.ToString();

            txtPriceOfAdult.Text = Properties.Settings.Default.priceOfAdult.ToString();
            txtPriceOfChild.Text = Properties.Settings.Default.priceOfChild.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e) //Event handler that closes the form
        {
            this.Close();
        }

        private void btnUndoChanges_Click(object sender, EventArgs e) //Wipes all unsaved changes and runs the loadcabinprices method
        {
            loadCabinPrices();
        }

        private void btnSave_Click(object sender, EventArgs e) //Saves all the text in the iunput fields to their respective values
        {
            try
            {
                Properties.Settings.Default.lowSeasonPrice = Convert.ToDecimal(txtLowSeasonPrice.Text);
                Properties.Settings.Default.midSeasonPrice = Convert.ToDecimal(txtMidSeasonPrice.Text);
                Properties.Settings.Default.highSeasonPrice = Convert.ToDecimal(txtHighSeasonPrice.Text);

                Properties.Settings.Default.masterCabinPrice = Convert.ToDecimal(txtMasterCabinPrice.Text);
                Properties.Settings.Default.platinumCabinPrice = Convert.ToDecimal(txtPlatinumCabinPrice.Text);
                Properties.Settings.Default.goldCabinPrice = Convert.ToDecimal(txtGoldCabinPrice.Text);
                Properties.Settings.Default.silverCabinPrice = Convert.ToDecimal(txtSilverCabinPrice.Text);
                Properties.Settings.Default.bronzeCabinPrice = Convert.ToDecimal(txtBronzeCabinPrice.Text);

                Properties.Settings.Default.priceOfAdult = Convert.ToDecimal(txtPriceOfAdult.Text);
                Properties.Settings.Default.priceOfChild = Convert.ToDecimal(txtPriceOfChild.Text);


                Properties.Settings.Default.Save(); //Saves
            }
            catch
            {
                MessageBox.Show("Invalid data type was entered");
                return;
            }
            MessageBox.Show("Succesfully saved");
        }
    }
}
