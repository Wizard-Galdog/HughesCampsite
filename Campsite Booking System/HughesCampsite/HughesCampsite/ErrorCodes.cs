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
    public partial class ErrorCodes : Form
    {
        public ErrorCodes()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e) //Event handler that closes the form
        {
            this.Close();
        }

        private void txtErrorCode_TextChanged(object sender, EventArgs e) //When the text is changed in the error code search textbox, the code will search while the user is typing and display realtime results
        {
            if (txtErrorCode.Text.Length < 2) //Need first 2 charcters of error code in order to find the area from which the code originated
            {
                return;
            }

            List<string> errorCodes = findClassWhereErrorOriginated(txtErrorCode.Text); //the errorCodes collection consists of all possible error codes matching the users search criteria
            addToListBoxForeach(errorCodes); //Adds to listbox
        }

        private void listErrorCodes_SelectedIndexChanged(object sender, EventArgs e)  //Event handler triggered whenever a index in the listbox is clicked on
        {
            List<string> errorCodes = findClassWhereErrorOriginated(listErrorCodes.SelectedItem.ToString());
            messageBoxOfErrorForeach(errorCodes, listErrorCodes.SelectedItem.ToString()); //Displays the detailed error message
        }


        private List<string> findClassWhereErrorOriginated(string code) //Consists of switch-case that requires first 2 characters of error code to determine the family of error codes it belongs to
        {
            List<string> errorCodes = new List<string>();

            switch (code.Substring(0, 2))
            {
                case "50":
                    errorCodes = classCollectionErrorCodesList();
                    break;
                case "60":
                    errorCodes = databaseCLassErrorCodesList();
                    break;
                case "61":
                    errorCodes = addToDatabaseClassErrorCodesList();
                    break;
                case "62":
                    errorCodes = deleteFromDatabaseClassErrorCodes();
                    break;
                case "63":
                    errorCodes = updateDatabaseCLassErrorCodesList();//I know their is only one error code for this class, so going to the effort of running another method with another list return is wasting resources, however this is only here for the future, incase further error codes are to be implemented!!!.
                    break;
                case "64":
                    errorCodes = databaseCLassErrorCodesList();
                    break;
            }
            return errorCodes;
        }        //This method is used by txtErrorCode_Changed and listErrorCodes_SelectedIndexChanged

        private void addToListBoxForeach(List<string> errorCodes) //Clears listbox, then runs a foreach. Looping though each item in the errorCodes collection and adding it to the listbox
        {
            listErrorCodes.Items.Clear();

            foreach (string n in errorCodes)
            {
                if (txtErrorCode.Text.Substring(0, txtErrorCode.Text.Length) == n.Substring(0, txtErrorCode.Text.Length)) //Was going to do .Contains but this is wasteful since i knowe the error code is at the very start
                {
                    listErrorCodes.Items.Add(n.Substring(0,5));
                }
            }
        }

        private void messageBoxOfErrorForeach(List<string> errorCodes, string theSelectedCode) //Loops though each item in the error code family, comparing it to the user selected error code and then displaying the detailed error code message when found
        {
            foreach (string n in errorCodes) //n represents a error code in that spefic error code famil
            {
                if (theSelectedCode.Substring(0, 5) == n.Substring(0,  5)) //Was going to do .Contains but this is wasteful since i knowe the error code is at the very start
                {
                    MessageBox.Show(theSelectedCode);
                }
            }
        }


        //RETURN LIST METHODS (This is simply 5 lists, all with error codes and their explaniations)
        //The general layout of these methods are:
        //              List<string> errorCodes = new List<String>
        //              errorCodes.Add("....");
        //              errorCodes.Add("...."); 
        //              and so on...
        //              return errorCodes;

        private List<string> classCollectionErrorCodesList()
        {
            List<string> errorCodes = new List<string>();
            errorCodes.Add("50001 ");
            errorCodes.Add("50002 ");
            errorCodes.Add("50003 ");
            errorCodes.Add("50004 ");
            errorCodes.Add("50005 ");
            errorCodes.Add("50006 ");
            return errorCodes;
        }

        private List<string> databaseCLassErrorCodesList()
        {
            List<string> errorCodes = new List<string>();
            errorCodes.Add("60001 ");
            errorCodes.Add("60002 ");
            errorCodes.Add("60003 ");
            errorCodes.Add("60004 ");
            errorCodes.Add("60005 ");
            errorCodes.Add("60006 ");
            errorCodes.Add("60007 ");
            errorCodes.Add("60008 ");
            errorCodes.Add("60009 ");
            errorCodes.Add("60010 ");
            errorCodes.Add("60011 ");
            errorCodes.Add("60012 ");
            errorCodes.Add("60013 ");
            errorCodes.Add("60014 ");
            errorCodes.Add("60015 ");
            return errorCodes;
        }

        private List<string> addToDatabaseClassErrorCodesList()
        {
            List<string> errorCodes = new List<string>();
            errorCodes.Add("61001 ");
            errorCodes.Add("61002 ");
            errorCodes.Add("61003 ");
            errorCodes.Add("61004 ");
            errorCodes.Add("61005 ");
            errorCodes.Add("61006 ");
            return errorCodes;
        }

        private List<string> deleteFromDatabaseClassErrorCodes()
        {
            List<string> errorCodes = new List<string>();
            errorCodes.Add("62001 ");
            errorCodes.Add("62002 ");
            errorCodes.Add("62003 ");
            errorCodes.Add("62004 ");
            errorCodes.Add("62005 ");
            errorCodes.Add("62006 ");
            errorCodes.Add("62007 ");
            return errorCodes;
        }

        private List<string> updateDatabaseCLassErrorCodesList()
        {
            List<string> errorCodes = new List<string>();
            errorCodes.Add("63001 ");
            return errorCodes;
        }

        private List<string> dataGridViewStuffCLassErrorCodesList()
        {
            List<string> errorCodes = new List<string>();
            errorCodes.Add("64001 ");
            errorCodes.Add("64002 ");
            errorCodes.Add("64003 ");
            errorCodes.Add("64004 ");
            errorCodes.Add("64005 ");
            errorCodes.Add("64006 ");
            errorCodes.Add("64007 ");
            errorCodes.Add("64008 ");
            errorCodes.Add("64009 ");
            errorCodes.Add("64010 ");
            return errorCodes;
        }
        //END OF RETURN LIST METHODS


        private void ErrorCodes_Load(object sender, EventArgs e)
        {
            unAssociatedMethods.set(this.Controls); //Loads font and form settings
            this.BackColor = Color.FromName(Properties.Settings.Default.formColour);
            this.Icon = Properties.Resources.hughesLogo;
        }

    }
}
