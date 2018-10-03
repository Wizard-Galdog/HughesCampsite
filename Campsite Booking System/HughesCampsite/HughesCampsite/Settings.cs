
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

        }


        private void comboBtnColourChange(object sender, EventArgs e) //Event handler that is triggered whenever any combo box on the form has its text changed
        {
            ComboBox combo = (ComboBox)sender; //New combobox with same characteristics as sender

            switch (combo.Name) //Switch-case used to determine what combo box called it and change its respective user setting value to the one selected in the combo box
            {
                case "comboBtnColourIsntOver":
                    Properties.Settings.Default.buttonColourWhenMousingIsntOverIt = combo.Text;
                    break;
                case "comboBtnIsOverIt":
                    Properties.Settings.Default.buttonColourWhenMousingIsOverIt = combo.Text;
                    break;
                case "comboFormColour":
                    Properties.Settings.Default.formColour = combo.Text;
                    this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
                    break;
                case "comboFont":
                    Properties.Settings.Default.Font = combo.Text;
                    Properties.Settings.Default.fontSettingsChanged = true;
                    checkBoxColourBlind.Checked = false;
                    break;
                case "comboFontSize":
                    Properties.Settings.Default.FontSize = Convert.ToInt16(combo.Text);
                    Properties.Settings.Default.fontSettingsChanged = true;
                    checkBoxColourBlind.Checked = false;
                    break;
                case "comboFontType":
                    Properties.Settings.Default.FontType = combo.Text;
                    Properties.Settings.Default.fontSettingsChanged = true;
                    checkBoxColourBlind.Checked = false;
                    break;
                case "comboFontColour":
                    Properties.Settings.Default.FontColour = combo.Text;
                    Properties.Settings.Default.fontSettingsChanged = true;
                    checkBoxColourBlind.Checked = false;
                    break;
                default:
                    break;
            }

            Properties.Settings.Default.Save(); //Saves the new user settings

            unAssociatedMethods.set(this.Controls); //Loads in the new font and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
        }

        private void checkColourBlind(object sender, EventArgs e) //This method sets the colours and font to those recommended by microsoft for colour blind people 
        {
            if (checkBoxColourBlind.CheckState == CheckState.Unchecked) //If the radiobutton is unchecked, then exit this method (This stops the method being run whenever the reset button would uncheck this radiobutton)
            {
                return;
            }

            unAssociatedMethods.loadDefaultProperties(); //resets the font and form settings
            fillTheComboBoxes(); //resets the combo boxes

            Properties.Settings.Default.formColour = "Yellow"; //Changes form colour to that recommended by microsoft
            Properties.Settings.Default.Save(); //Saves the change
            Properties.Settings.Default.fontSettingsChanged = true; //Records the font as having been changed

            unAssociatedMethods.set(this.Controls); //Loads font and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fillTheComboBoxes();//resets the combo boxes
            checkBoxColourBlind.Checked = false; //Sets the colour radio button to be unchecked 
            unAssociatedMethods.loadDefaultProperties(); //Resets the font and form settings
            MessageBox.Show("Values have been reset");

            unAssociatedMethods.set(this.Controls); //Loads font and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
        } //This method resets the font and form settings to their default values


        /// Fill combobox methods
        private void fillTheComboBoxes()
        {
            //Clears all the combo boxes
            comboBtnColourIsntOver.Items.Clear(); 
            comboBtnIsOverIt.Items.Clear();
            comboFont.Items.Clear();
            comboFontColour.Items.Clear();
            comboFontSize.Items.Clear();
            comboFontType.Items.Clear();
            comboFormColour.Items.Clear();

            //Runs the methods that fill the combo boxes
            fillComboBtnColours();
            fillComboFont();
            fillComboFontSize();
            fillFontType();
        } //Clears all the combo boxes and runs all the methods that fill them again

        private void fillComboBtnColours()
        {
            foreach (Color c in new ColorConverter().GetStandardValues()) //Fills all the combo boxes that will contain colours, the foreach statement loops through the visual studio color libary
            {
                comboBtnColourIsntOver.Items.Add(c);
                comboBtnIsOverIt.Items.Add(c);
                comboFormColour.Items.Add(c);
                comboFontColour.Items.Add(c);
            }
        } //Fills all the combo boxes that are related to colour

        private void fillComboFont()
        {
            foreach (FontFamily f in FontFamily.Families) //Fils the combo box, the foreach statement loops through each font in the visual studio font libary
            {
                comboFont.Items.Add(f.Name);
            }
        } //fills all combo boxes that are related to font

        private void fillComboFontSize() //fill the font combo boxes with positive integer values
        {
            for (int i = 1; i < 20; i++) //For i statement up to size 20 font
            {
                comboFontSize.Items.Add(i);
            }
        }

        private void fillFontType()//Fills combo box with "Regular" and "Bold" font type
        {
            comboFontType.Items.Add("Regular");
            comboFontType.Items.Add("Bold");
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            unAssociatedMethods.set(this.Controls); //Loads font and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
            this.Icon = Properties.Resources.hughesLogo;

            fillTheComboBoxes();
        }
    }
}
