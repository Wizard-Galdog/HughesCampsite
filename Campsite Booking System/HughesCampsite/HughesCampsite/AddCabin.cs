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
    public partial class AddCabin : Form
    {
        public AddCabin(string staffDetails)
        {
            InitializeComponent();

            toolStripLabel1.Text = staffDetails;
        }

        private void btnAddCabin_Click(object sender, EventArgs e) //Processes the first stage of adding the cabin to the database
        {
            CABINDetails newCabin = new CABINDetails();  //Creates a new instance of the CABINDetails collection
            try //Fills the new instance with data, the try catch is used to stop any errors caused by inputting incorrect data. Validation occurs AFTER the collection has been filled
            {
                newCabin.CabinDesc = txtCabinDesc.Text.Trim();
                newCabin.CabinCapacity = txtCabinCapacity.Text.Trim();
                newCabin.CabinType = comboCabinType.Text.Trim();
            }
            catch (Exception)
            {
                unAssociatedMethods.genericErrorMessage("This was caused during the filling of a new cabin's data", "50002");
                return;
            }
            
            var validator = new CABINValidator(); //Creates a new instance of the CABINDetails collection validator
            if (!validator.Validate(newCabin)) //If the validator returns false, that the validate process has failed and the add cabin process is cancelled
            {
                MessageBox.Show("The cabin has not been added");
                return;
            }

            addToDatabase.addCabin(newCabin); //The data colleciton is passed to the second stage of adding the cabin
        }


        private void btnBack_Click(object sender, EventArgs e) //Closes the add cabin form
        {
            this.Close();
        }

        private void AddCabin_Load(object sender, EventArgs e)
        {
            toolStripBtnLock.Tag = toolStripLabel1.Text.ToString();

            unAssociatedMethods.set(this.Controls); //Loads the font and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
            this.Icon = Properties.Resources.hughesLogo;
        }
    }
}
