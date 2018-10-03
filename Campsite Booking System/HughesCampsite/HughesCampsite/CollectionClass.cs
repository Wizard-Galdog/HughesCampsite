using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
using System.Drawing; //use for color.fromname
using System.ComponentModel;
using System.Reflection; //Used for property info

namespace HughesCampsite
{

    interface IValidator<T>
    {
        bool Validate(T t);
    } 


    public class CUSTOMERDetails //////Elements of the CUSTOMERDetails collection
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
    }
    class CUSTOMERValidator : IValidator<CUSTOMERDetails> ///Validation for the CUSTOMERDetails Collection Elements
    {
        public bool Validate(CUSTOMERDetails t)
        {
            foreach (PropertyInfo propInfo in t.GetType().GetProperties()) //Discovers the attributes of a property and provides access to property metadata. The foreach statment loops through each element in the collection, getting its propertyinfo
            {
                string currentField = propInfo.GetValue(t, null).ToString();  ///made string instead of var because it would be converted to string at the if statment and then again and again. The currentField value is the value of the property (i.e if the FirstName is 'john', then currentField has a value = john)
                string[] datatypeAndPropertyName = propInfo.ToString().Split(' '); //datatypeAndPropertyName[0] is the data type of the element (i.e system.string), and datatypeAndPropertyName[1] is the name of the element (i.e FirstName)

                if (string.IsNullOrWhiteSpace(currentField) == true) //Checks if the elements value is empty
                {
                    MessageBox.Show(string.Format("{0} is empty", datatypeAndPropertyName[1]));
                    return false;
                }

                if ((datatypeAndPropertyName[0] == "System.String") && (currentField.Length > 50)) //Checks if the elements value exceeds 50 characters (on the database, data is stored in varchar(50))
                {
                    MessageBox.Show(string.Format("The data entered in {0} is too long\nData = {1}\nPlease ensure the data doesn't exceed 50 characters", datatypeAndPropertyName[1], currentField));
                    return false;
                }

                if (validationMethods.validateDobEmailPhoneNoPostCode(datatypeAndPropertyName[1], currentField) == false) //Validates email, dob, phone & postcode
                {
                    return false;
                }
            }
            return true; //true is returned if the validation process was successful
        }
    }


    public class BOOKINGDetails //////Elements of the BOOKINGDetails collection
    {
        public int CabinNo { get; set; }
        public string NumOfAdults { get; set; }
        public string NumOfChildren { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Season { get; set; }
        public decimal Price { get; set; }

    }
    class BOOKINGValidator : IValidator<BOOKINGDetails>///Validation for the BOOKINGDetails Collection Elements                                                   
    {
        public bool Validate(BOOKINGDetails t)
        {

            foreach (PropertyInfo propInfo in t.GetType().GetProperties()) //Discovers the attributes of a property and provides access to property metadata. The foreach statment loops through each element in the collection, getting its propertyinfo
            {
                string[] datatypeAndPropertyName = propInfo.ToString().Split(' '); //datatypeAndPropertyName[0] is the data type of the element (i.e system.string), and datatypeAndPropertyName[1] is the name of the element
                string currentField = propInfo.GetValue(t, null).ToString();  ///made string instead of var because it would be converted to string at the if statment and then again and again. The currentField value is the value of the property

                if (string.IsNullOrWhiteSpace(currentField) == true)//Checks if the elements value is empty
                {
                    MessageBox.Show(string.Format("{0} is empty", datatypeAndPropertyName[1]));
                    return false;
                }

                if ((datatypeAndPropertyName[0] == "System.String") && (currentField.Length > 50)) //Checks if the elements value exceeds 50 characters (on the database, data is stored in varchar(50))
                {
                    MessageBox.Show(string.Format("The data entered in {0} is too long\nData = {1}\nPlease ensure the data doesn't exceed 50 characters", datatypeAndPropertyName[1], currentField));
                    return false;
                }
            }
            return true; //true is returned if the validation process was successful
        }
    }

    public class PAYMENTDetails //////Elements of the PAYMENTDetails collection
    {
        public string PaymentType { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public string SecurityCode { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime DatePaid { get; set; }
    }
    class PAYMENTValidator : IValidator<PAYMENTDetails>///Validation for the PAYMENTDetails Collection Elements
    {
        public bool Validate(PAYMENTDetails t)
        {

            foreach (PropertyInfo propInfo in t.GetType().GetProperties())//Discovers the attributes of a property and provides access to property metadata. The foreach statment loops through each element in the collection, getting its propertyinfo
            {
                string[] datatypeAndPropertyName = propInfo.ToString().Split(' '); //datatypeAndPropertyName[0] is the data type of the element (i.e system.string), and datatypeAndPropertyName[1] is the name of the element
                string currentField = propInfo.GetValue(t, null).ToString();  ///made string instead of var because it would be converted to string at the if statment and then again and again. The currentField value is the value of the property

                if (t.PaymentType == "Cash") //Card number etc will all be empty if payment type is cash, therefore this will skip that execution of code if payment type is cash
                {
                    continue; //This will start the next iteration of the foreach
                }

                if (string.IsNullOrWhiteSpace(currentField) == true)//Checks if the elements value is empty
                {
                    MessageBox.Show(string.Format("{0} is empty", datatypeAndPropertyName[1]));
                    return false;
                }

                if ((datatypeAndPropertyName[0] == "System.String") && (currentField.Length > 50)) //Checks if the elements value exceeds 50 characters (on the database, data is stored in varchar(50))
                {
                    MessageBox.Show(string.Format("The data entered in {0} is too long\nData = {1}\nPlease ensure the data doesn't exceed 50 characters", datatypeAndPropertyName[1], currentField));
                    return false;
                }

                switch (datatypeAndPropertyName[1]) //Switch-case for the element name (i.e CardNumber)
                {
                    case "CardNumber":
                        if ((currentField.Length != 16) || (currentField.All(Char.IsDigit) == false)) //Card number should only be 16 numbers
                        {
                            MessageBox.Show("Card number must be 16 numbers");
                            return false;
                        }
                        break;
                    case "SecurityCode":
                        if ((currentField.Length != 3) || (currentField.All(Char.IsDigit))) //Security code should only be 3 numbers
                        {
                            MessageBox.Show("Security code must be 3 numbers");
                            return false;
                        }
                        break;
                    case "ExpiryDate":
                        if (DateTime.Parse(currentField) < DateTime.Today) //Expiry date should be in the 'past'
                        {
                            MessageBox.Show("The expiry date is invalid");
                            return false;
                        }
                        break;
                    default:
                        break;
                }
            }
            return true; //true is returned if the validation process was successful
        }
    }


    public class STAFFDetails//////Elements of the STAFFDetails collection
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Privileges { get; set; }
    }
    class STAFFValidator : IValidator<STAFFDetails> ///Validation for the STAFFDetails Collection Elements
    {
        public bool Validate(STAFFDetails t)
        {

            foreach (PropertyInfo propInfo in t.GetType().GetProperties())//Discovers the attributes of a property and provides access to property metadata. The foreach statment loops through each element in the collection, getting its propertyinfo
            {
                string[] datatypeAndPropertyName = propInfo.ToString().Split(' '); //datatypeAndPropertyName[0] is the data type of the element (i.e system.string), and datatypeAndPropertyName[1] is the name of the element
                string currentField = propInfo.GetValue(t, null).ToString();  ///made string instead of var because it would be converted to string at the if statment and then again and again. The currentField value is the value of the property

                if (string.IsNullOrWhiteSpace(currentField) == true) //Checks if the elements value is empty
                {
                    MessageBox.Show(string.Format("{0} is empty", datatypeAndPropertyName[1]));
                    return false;
                }

                if ((datatypeAndPropertyName[0] == "System.String") && (currentField.Length > 50)) //Checks if the elements value exceeds 50 characters (on the database, data is stored in varchar(50))
                {
                    MessageBox.Show(string.Format("The data entered in {0} is too long\nData = {1}\nPlease ensure the data doesn't exceed 50 characters", datatypeAndPropertyName[1], currentField));
                    return false;
                }

                if (validationMethods.validateDobEmailPhoneNoPostCode(datatypeAndPropertyName[1], currentField) == false) //Validates email, dob, phone & postcode
                {
                    return false;
                }

            }
            return true; //true is returned if the validation process was successful
        }
    }


    public class CABINDetails//////Elements of the CABINDetails collection
    {
        public string CabinDesc { get; set; }
        public string CabinCapacity { get; set; }
        public string CabinType { get; set; }

    }
    class CABINValidator : IValidator<CABINDetails>///Validation for the CABINDetails Collection Elements
    {
        public bool Validate(CABINDetails t)
        {
            foreach (PropertyInfo propInfo in t.GetType().GetProperties())//Discovers the attributes of a property and provides access to property metadata. The foreach statment loops through each element in the collection, getting its propertyinfo
            {
                string[] datatypeAndPropertyName = propInfo.ToString().Split(' ');//datatypeAndPropertyName[0] is the data type of the element (i.e system.string), and datatypeAndPropertyName[1] is the name of the element
                string currentField = propInfo.GetValue(t, null).ToString();  ///made string instead of var because it would be converted to string at the if statment and then again and again. The currentField value is the value of the property

                if (string.IsNullOrWhiteSpace(currentField) == true) //Checks if the elements value is empty
                {
                    if (datatypeAndPropertyName[1] != "CabinDesc") //CabinDesc is optional
                    {
                        MessageBox.Show(string.Format("{0} is empty", datatypeAndPropertyName[1]));
                        return false;
                    }
                }

                if ((datatypeAndPropertyName[0] == "System.String") && (currentField.Length > 50))//Checks if the elements value exceeds 50 characters (on the database, data is stored in varchar(50))
                {
                    MessageBox.Show(string.Format("The data entered in {0} is too long\nData = {1}\nPlease ensure the data doesn't exceed 50 characters", datatypeAndPropertyName[1], currentField));
                    return false;
                }
                 if ((datatypeAndPropertyName[1] == "CabinCapacity") && (currentField.All(char.IsDigit) == false)) //CabinCapacity has to consist of only numbers
                 {
                     MessageBox.Show("Please remove the letters and/or special characters from the Cabin Capacity field");
                     return false;
                 }

            }
            return true;//true is returned if the validation process was successful
        }
    }


    public class LINKTABLEDetails//////Elements of the LINKTABLEDetails collection
    {
        public int CustomerID { get; set; }
        public int BookingID { get; set; }
        public int StaffID { get; set; }
        public int PaymentID { get; set; }
    }
    class LINKTABLEValidator : IValidator<LINKTABLEDetails>///Validation for the LINKTABLEDetails Collection Elements
    {
        public bool Validate(LINKTABLEDetails t)
        {
            foreach (PropertyInfo propInfo in t.GetType().GetProperties())//Discovers the attributes of a property and provides access to property metadata. The foreach statment loops through each element in the collection, getting its propertyinfo
            {
                string[] datatypeAndPropertyName = propInfo.ToString().Split(' ');//datatypeAndPropertyName[0] is the data type of the element (i.e system.string), and datatypeAndPropertyName[1] is the name of the element 
                string currentField = propInfo.GetValue(t, null).ToString();  ///made string instead of var because it would be converted to string at the if statment and then again and again. The currentField value is the value of the property

                if (currentField == null) //Makes sure that no element is empty, since in the database, these are set as not allowed nulls
                {
                        MessageBox.Show(string.Format("{0} is empty", datatypeAndPropertyName[1]));
                        return false;
                }
            }
            return true;//true is returned if the validation process was successful
        }
    }

    class validationMethods ////CONTAINS VALIDATION FOR POSTCODE, DOB, EMAIL AND PHONE NUMBER
    {
        private static bool validatePostcode(string postcode) //Validates the postcode using regex
        {
            if (!(
                Regex.IsMatch(postcode, "(^[A-PR-UWYZa-pr-uwyz][0-9][ ]*[0-9][ABD-HJLNP-UW-Zabd-hjlnp-uw-z]{2}$)") ||
                Regex.IsMatch(postcode, "(^[A-PR-UWYZa-pr-uwyz][0-9][0-9][ ]*[0-9][ABD-HJLNP-UW-Zabd-hjlnp-uw-z]{2}$)") ||
                Regex.IsMatch(postcode, "(^[A-PR-UWYZa-pr-uwyz][A-HK-Ya-hk-y][0-9][ ]*[0-9][ABD-HJLNP-UW-Zabd-hjlnp-uw-z]{2}$)") ||
                Regex.IsMatch(postcode, "(^[A-PR-UWYZa-pr-uwyz][A-HK-Ya-hk-y][0-9][0-9][ ]*[0-9][ABD-HJLNP-UW-Zabd-hjlnp-uw-z]{2}$)") ||
                Regex.IsMatch(postcode, "(^[A-PR-UWYZa-pr-uwyz][0-9][A-HJKS-UWa-hjks-uw][ ]*[0-9][ABD-HJLNP-UW-Zabd-hjlnp-uw-z]{2}$)") ||
                Regex.IsMatch(postcode, "(^[A-PR-UWYZa-pr-uwyz][A-HK-Ya-hk-y][0-9][A-Za-z][ ]*[0-9][ABD-HJLNP-UW-Zabd-hjlnp-uw-z]{2}$)") ||
                Regex.IsMatch(postcode, "(^[Gg][Ii][Rr][]*0[Aa][Aa]$)")
                ))   ///There is a huge combination of uk postcodes, hence the huge if regex statement
            {
                return false;
            }
            return true; //true is returned if the psotcode is valid
        }

        public static bool validateDobEmailPhoneNoPostCode(string propertyName, string currentField)
        {
            switch (propertyName)
            {
                case "DateOfBirth":
                    if (DateTime.Parse(currentField) >= DateTime.Now.AddYears(-18)) ///age can't be younger than 18
                    {
                        MessageBox.Show("The date of birth must be 18 years or older!");
                        return false;
                    }
                    break;
                case "Email":
                    if ((currentField.Contains("@") == false) || ((currentField.Contains(".co.uk") == false) && (currentField.Contains(".com") == false)) == true) //Must contain a '@' AND either a '.com' or '.co.uk'
                    {
                        MessageBox.Show("Please enter a valid email address with a '@' symbol and either '.com' or '.co.uk'");
                        return false;
                    }
                    break;
                case "PhoneNo":
                    if ((currentField.Length != 11) || (currentField.All(char.IsDigit) == false)) //Phone number must be 11 numbers long
                    {
                        MessageBox.Show("The phone number is invalid");
                        return false;
                    }
                    break;
                case "PostCode":
                    if (validatePostcode(currentField) == false) //Runs the check postcode method
                    {
                        MessageBox.Show("Postcode is invalid");
                        return false;
                    }
                    break;
                default:
                    break;
            }
            return true; //true is returned if the validation process was successful
        }
    }

    ///END OF VALIDATION AND CLASS COLLECTION


    public class constants ///This stores the data connection string
    {
        public const string connectionString = @"Data Source=DESKTOP-6R3IU0O\SQLEXPRESS;Initial Catalog=newDB;Integrated Security=True";
        //new home pc = @"Data Source=DESKTOP-6R3IU0O\SQLEXPRESS;Initial Catalog=newDB;Integrated Security=True"
        //home pc = @"Data Source=DESKTOP-6R3IU0O\SQLEXPRESS;Initial Catalog=Bookings;Integrated Security=True"
        //school pc = @"Data Source=COMPUTER14-PC\SQLEXPRESS;Initial Catalog=HughesDatabase;Integrated Security=True"
        //halloween home = @"Data Source=DESKTOP-6R3IU0O\SQLEXPRESS;Initial Catalog="halloween DONT TAKE BACK NOR MAKE CHANGES";Integrated Security=True
    }

    class unAssociatedMethods //Consists of methods with very little links or relations. CONTAINS LOG OUT, GENERIC ERROR MESSAGE, FONT & FORM SETTINGS
    {
        public static void logOut() //Called whenever the user clicks the log out button
        {
            DialogResult result = MessageBox.Show("In order to log out, the program must reboot. \n This is for security reasons \n sorry for the inconveince \n Would you like to continue?", "Log Out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) //The message box has a 'yes' or 'no' button, if yes is clicked, then the application reboots
            {
                Application.Restart();
            }
        }

        public static void genericErrorMessage(string basicExplanination, string errorCode) //Provies a basic template for error messages
        {
            string message = string.Format("An error has occured\n{0}\nError Code:{1}", basicExplanination, errorCode);
            MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void mouseEnter(object sender, EventArgs e) //MAINLY JUST HERE INCASE I WANT TO DO FURTHER PROCESSES DURING MOUSE HOVERING OVER A BUTTON, Currently changes backcolor wehen mouse enters the button
        {
            Button btn = (Button)sender; 
            btn.BackColor = Color.FromName(Properties.Settings.Default.buttonColourWhenMousingIsOverIt);
        }

        public static void mouseLeave(object sender, EventArgs e) //MAINLY JUST HERE INCASE I WANT TO DO FURTHER PROCESSES DURING MOUSE NOT HOVERING OVER A BUTTON, Currently changes the backcolor when mouse leaves the button
        {

            Button btn = (Button)sender;
            btn.BackColor = Color.FromName(Properties.Settings.Default.buttonColourWhenMousingIsntOverIt);
        }

        public static void loadDefaultProperties() //used to reset font and forms values on bootup and during runtime
        {
            Properties.Settings.Default.buttonColourWhenMousingIsntOverIt = "Pink";
            Properties.Settings.Default.buttonColourWhenMousingIsOverIt = "Red";
            Properties.Settings.Default.formColour = "Control";
            Properties.Settings.Default.Font = "Microsoft Sans Serif";
            Properties.Settings.Default.FontSize = 8;
            Properties.Settings.Default.FontType = "Regular";
            Properties.Settings.Default.FontColour = "ControlText";
            Properties.Settings.Default.fontSettingsChanged = false;

            Properties.Settings.Default.Save(); //Saves the changes
        }

        public static void set(Control.ControlCollection ctrl) //Used to load font and form settings
        {
            Font fo = getUserSelectedFont(); //Is need for basically every loop in the foreach, so thier is no point re calling every time

            foreach (Control c in ctrl) //ctrl is the control collecion passed from the form
            {
                if (checkControlPriotity(c) == true) //If the control has a tag = P1, then it is excluded from the settings manipulation. This stops labels that are bold etc being over rode
                {
                    string control = c.GetType().ToString();
                    switch (control)
                    {
                        case "System.Windows.Forms.Label": //Sets labels font and colour
                            setTheControlsFont(c, fo);
                            break;
                        case "System.Windows.Forms.Button"://Sets buttons font, colour and adds mouse enter/leave events
                            setTheControlsFont(c, fo);
                            c.BackColor = Color.FromName(Properties.Settings.Default.buttonColourWhenMousingIsntOverIt);
                            c.MouseEnter += new System.EventHandler(unAssociatedMethods.mouseEnter);
                            c.MouseLeave += new System.EventHandler(unAssociatedMethods.mouseLeave);
                            break;
                        case "System.Windows.Forms.ComboBox": //Sets the combo box to follow a certain characteristic
                            setCombo(c);
                            break;
                        case "System.Windows.Forms.GroupBox": //////The control on the form is a groupbox, now the controls int the groupbox (buttons, labels etc) must be looped through similiar to how the forms controls are looped through
                            foreach (Control ct in c.Controls) //Loops through every control in the groupbox
                            {
                                if (ct.GetType().ToString() == "System.Windows.Forms.ComboBox")//if true, Sets the combo box to follow a certain characteristic
                                {
                                    setCombo(ct);
                                }
                                switch (ct.GetType().ToString()) //ct.gettype.tostring is the full control name(i.e system.windows.forms.buttons)
                                {
                                    case "System.Windows.Forms.Button"://Sets buttons font, colour and adds mouse enter/leave events
                                        setTheControlsFont(ct, fo);
                                        ct.BackColor = Color.FromName(Properties.Settings.Default.buttonColourWhenMousingIsntOverIt);
                                        ct.MouseEnter += new System.EventHandler(unAssociatedMethods.mouseEnter);
                                        ct.MouseLeave += new System.EventHandler(unAssociatedMethods.mouseLeave);
                                        break;
                                    case "System.Windows.Forms.Label"://Sets labels font and colour
                                        setTheControlsFont(ct, fo);
                                        break;
                                }
                            }
                            break;
                        case "System.Windows.Forms.ToolStrip":  //Similar to how groupbox works, all the controls on the toolstrip must be looped through. Adds the event handlers to the respective buttons
                            foreach (ToolStripItem item in ((ToolStrip)c).Items)///loops through every item in the toolstrip
                            {
                                switch (item.Name.ToString()) //In this case, unlike the groupbox, the names of the toolstrip buttons are limited. Thereford the names are used for the switch-case
                                {
                                    case "toolStripBtnAboutUs":
                                        item.Click -= new System.EventHandler(toolStripHandler.aboutUsHandler);  ///done cause of a recursion issue where the event would just run again after closed
                                        item.Click += new System.EventHandler(toolStripHandler.aboutUsHandler);
                                        break;
                                    case "toolStripBtnHelp":
                                        item.Click -= new System.EventHandler(toolStripHandler.helpHandler);    ///done cause of a recursion issue where the event would just run again after closed
                                        item.Click += new System.EventHandler(toolStripHandler.helpHandler);
                                        break;
                                    case "toolStripBtnSettings":
                                        item.Click -= new System.EventHandler(toolStripHandler.settingsHandler);   ///done cause of a recursion issue where the event would just run again after closed
                                        item.Click += new System.EventHandler(toolStripHandler.settingsHandler);
                                        break;
                                    case "toolStripBtnLock":
                                        item.Click -= new System.EventHandler(toolStripHandler.lockHandler);    ///done cause of a recursion issue where the event would just run again after closed
                                        item.Click += new System.EventHandler(toolStripHandler.lockHandler);
                                        break;
                                    case "toolStripBtnLogOut":
                                        item.Click -= new System.EventHandler(toolStripHandler.logOutHandler);   ///done cause of a recursion issue where the event would just run again after closed
                                        item.Click += new System.EventHandler(toolStripHandler.logOutHandler);
                                        break;
                                    case "toolStripBtnExitProgram":
                                        item.Click -= new System.EventHandler(toolStripHandler.exitProgramHandler);   ///done cause of a recursion issue where the event would just run again after closed
                                        item.Click += new System.EventHandler(toolStripHandler.exitProgramHandler);
                                        break;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

        }

        private static Boolean checkControlPriotity(Control ct)   ///IF the controls tag has a value of 'P1', then that means it has a prority 1 and shouldnt be changed.
        {
            try
            {
                var crt = (Control)ct;//Var is used because different types of controls are passed into this. Like buttons and labels
                if (crt.Tag.ToString() == "P1")
                {
                    return false;
                }
            }
            catch //Doesnt need to return any errorm if a exception occurs then that means the control has no tag and is thereford just taken as have standard priority
            {

            }
            return true;
        }

        private static void setCombo(Control ct) //Sets the default characteristics for all combo boxes
        {
            ComboBox co = (ComboBox)ct;
            co.DropDownStyle = ComboBoxStyle.DropDownList; ///Makes the combo box have a drop down list
        }

        public static Font getUserSelectedFont() //Uses a font converter to generate a font based on the user font settings
        {
            var cvt = new FontConverter(); //Creates new instance of font converter
            string font = string.Format("{0}, {1}, style={2}", Properties.Settings.Default.Font, Properties.Settings.Default.FontSize, Properties.Settings.Default.FontType);
            Font f = cvt.ConvertFromString(font) as Font; //converts string to font
            return f; //returns font
        }

        private static void setTheControlsFont(Control c, Font fo) //Sets the controls font to the user font settings and sets the controls forecolor to the user fore color settings
        {
            c.Font = fo;
            c.ForeColor = Color.FromName(Properties.Settings.Default.FontColour);
        }
    }

    class retrieveIDs //used to get the IDs from strings
    {
        public static int getStaffIdUsingTheString(string theLabel) ///Uses int.parse to get staffID asnd return it
        {
            string resultString = Regex.Match(theLabel, @"\d+").Value;
            int staffID = int.Parse(resultString);
            return staffID;
        }

        public static decimal getAmountPaid(string theLabel)///although not a id being retrieved, i felt it was best for organisation of my methods. Fetchs the price number for a piece of text (ex. 'The price is £25' and fetchs 25)
        {
            string resultString = theLabel.Substring(theLabel.IndexOf("£") + 1);
            decimal amountPaid = Convert.ToDecimal(resultString);
            return amountPaid;
        }

    }

    class toolStripHandler ////Contains the event handlers for the buttons in the main program toolstrip
    {
        public static void aboutUsHandler(object sender, EventArgs e) ///Opens about us form
        {
            AboutUs frm = new AboutUs(); //Creates a new instance of the about us form
            frm.ShowDialog(); //Shows the about us form
        }

        public static void helpHandler(object sender, EventArgs e) ///Opens the help form
        {
            ErrorCodes frm = new ErrorCodes(); //Creates a new instance of the error codes form
            frm.ShowDialog(); //Shows the error codes form
        }

        public static void settingsHandler(object sender, EventArgs e) ///Opens the settings form and then reloads font and form settings for all currently open form
        {
            Settings frm = new Settings(); //Creates a new instance of the settings form
            frm.ShowDialog(); //Shows the settings form

            FormCollection fc = Application.OpenForms; //fc is a collection containing all open forms

            foreach (Form frmo in fc) //Foreach statement loops through every form in the fc collection
            {
                unAssociatedMethods.set(frmo.Controls); ///Reloads the font and form settings
                frmo.BackColor = Color.FromName(Properties.Settings.Default.formColour);
            }
        }

        public static void lockHandler(object sender, EventArgs e) ///Locks the program
        {
            ToolStripButton lockButton = (ToolStripButton)sender; //The lockButton.tag is the the staffID, this is used by the lock screen.
            LockScreen frm = new LockScreen(lockButton.Tag.ToString()); //Creates a new instance of the lock screen form
            frm.ShowDialog(); //shows the lock screeen form
        }

        public static void logOutHandler(object sender, EventArgs e) ///Runs the log out method
        {
            unAssociatedMethods.logOut();
        }

        public static void exitProgramHandler(object sender, EventArgs e) //Exits the program
        {
            Application.Exit();
        }
    }

}
    


