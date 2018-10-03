using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.Linq; ///has to add the linq and linq.mapping reference
using System.Data.Linq.Mapping;
using System.Text.RegularExpressions;

namespace HughesCampsite
{

    /// <summary>
    /// Through out these classes, the 'using' statement is used every time the database is being connected to. The 'using' statement disposes of the resource after it is used
    /// </summary>
    class Database
    {
        public static void checkConnection() //Verifys a database connection can be established
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                try
                {
                    con.Open(); //Trys to open connection
                }
                catch (Exception) //IF failed, then that means that the database cant be connected to
                {
                    MessageBox.Show(string.Format("Error connecting to database\nThe system can't load"));
                    Application.Exit(); //Exits the program
                }
            }
            
        }
  
        public static string staffLogin(string UserName, string Password) //Checks the User login credentials
        {
            string StaffMembersDetails = "null"; //Sets to null because null is returned if the credentials arent correct
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select StaffID, FirstName, LastName from STAFF WHERE UserName=@UserName AND Password=@Password", con)) //Fetchs records from staff database
                {
                    cmd.Parameters.AddWithValue("@UserName", UserName); //Adds the 'Where' Parameters to the cmd command
                    cmd.Parameters.AddWithValue("@Password", Password);
                    try
                    {
                        using (SqlDataReader myReader = cmd.ExecuteReader()) //Executes using the Execute Reader
                        {
                            while (myReader.Read()) //'While' executes until their is no more to read
                            {
                                StaffMembersDetails = string.Format("{0} {1} \n Staff ID: {2}", myReader["FirstName"].ToString(), myReader["LastName"].ToString(), Convert.ToInt16(myReader["StaffID"].ToString())); //This is the string returned
                            }
                        }
                    }
                    catch (System.Data.SqlClient.SqlException)  ///this is the only error that can occur during the myReader.read() so any other exception can be trated as a problem with the using (sqldatareader myReader = cmd.ExecuteReader())
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during reading the sqlDataReader", "60001");
                    }
                    catch (Exception)
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during the execution of the command", "60002");
                    }
                }
            }
            return StaffMembersDetails; //Returns
        }

        public static bool loginFromLocked(string staffDetails, string Password) //Used to login from the lock screeen
        {
            int staffID = retrieveIDs.getStaffIdUsingTheString(staffDetails); //Retrieves staffid

            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select Password from STAFF where StaffID=@StaffID ", con)) 
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffID); //Adds StaffId to cmd parameter
                    try
                    {
                        using (SqlDataReader myReader = cmd.ExecuteReader())
                        {
                            while (myReader.Read())  //'While' executes when their is no more to read
                            {
                                if (myReader["Password"].ToString() == Password) //The password for that staffID is 'Fetched' by the SQL command, if it matches with the user input password. Then access is granted
                                {
                                    return true; //True is returned
                                }
                            }
                        }
                    }
                    catch (System.Data.SqlClient.SqlException)  ///this is the only error that can occur during the myReader.read() so any other exception can be trated as a problem with the using (sqldatareader myReader = cmd.ExecuteReader())
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during reading the sqlDataReader", "60003");
                    }
                    catch (Exception)
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during the execution of the command", "60004");
                    }
                }
            }
            return false; //False is returned if the password doesnt match
        }


        public static List<string> checkAvailability(DateTime startdate, DateTime enddate) //Returns a list of CabinNo's that are available for those specific dates passed in
        {
            List<string> cabinNoOFcabinsInUse = new List<string>(); //This list holds the CabinNO's, it is intialised here because it needs to be in scope for the duration of the whole method

            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select CabinNo from BOOKING where @startdate BETWEEN StartDate and EndDate OR @enddate BETWEEN StartDate and EndDate OR StartDate BETWEEN  @startdate and @enddate OR EndDate BETWEEN @startdate AND @enddate", con))  //"Select CabinNo from BOOKING startdate where StartDate BETWEEN StartDate and EndDate OR enddate BETWEEN StartDate and EndDate", con))
                {

                    cmd.Parameters.AddWithValue("@startdate", startdate); //Adds the startdate and enddate parameters to the the sql command
                    cmd.Parameters.AddWithValue("@enddate", enddate);

                    try
                    {
                        using (SqlDataReader myReader = cmd.ExecuteReader())
                        {
                            while (myReader.Read()) //'While' executes when their is no more to read
                            {
                                cabinNoOFcabinsInUse.Add(myReader["CabinNo"].ToString()); //Adds the CabinNo to the list
                            }
                        }
                    }
                    catch (System.Data.SqlClient.SqlException)  ///this is the only error that can occur during the myReader.read() so any other exception can be trated as a problem with the using (sqldatareader myReader = cmd.ExecuteReader())
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during reading the sqlDataReader", "60005");
                    }
                    catch (Exception)
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during the execution of the command", "60006");
                    }
                }
            }
            return cabinNoOFcabinsInUse; //The list is returned to the calling method
        }

        public static List<string> findOutTheCabinNoOfSelectedType(string type, string capacity) //Returns a list of CabinNo's that have the specific cabin type and capacity as those passed in
        {
            List<string> cabinNoOFcabinsOfSelectedType = new List<string>(); //This list holds the CabinNO's, it is intialised here because it needs to be in scope for the duration of the whole method

            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select CabinNo from CABIN where CabinType=@type and CabinCapacity>=@capacity and CabinDesc<>@Inactive", con))
                {
                    cmd.Parameters.AddWithValue("@type", type); //Adds parameters to the sql command
                    cmd.Parameters.AddWithValue("@capacity", capacity);
                    cmd.Parameters.AddWithValue("@Inactive", "Inactive");

                    try
                    {
                        using (SqlDataReader myReader = cmd.ExecuteReader())
                        {
                            while (myReader.Read()) //'While' executes when their is no more to read
                            {
                                
                                cabinNoOFcabinsOfSelectedType.Add(myReader["CabinNo"].ToString()); //Adds the cabin number to the list
                            }
                        }
                    }
                    catch (System.Data.SqlClient.SqlException)  ///this is the only error that can occur during the myReader.read() so any other exception can be trated as a problem with the using (sqldatareader myReader = cmd.ExecuteReader())
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during reading the sqlDataReader", "60007");
                    }
                    catch (Exception)
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during the execution of the command", "60008");
                    }
                }
            }
            return cabinNoOFcabinsOfSelectedType; //Returns the list of cabin numbers to the calling method
        }

        public static Boolean staffPrivileges(string staffMemberDetails) //Checks user privileges
        {
            Boolean adminPrivileges = false; //Automatically set to false
            int staffID = retrieveIDs.getStaffIdUsingTheString(staffMemberDetails); //The staffId is retrieved

            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select Privileges from STAFF where StaffID=@staffID", con)) 
                {
                    cmd.Parameters.AddWithValue("@staffID", staffID); //Adds staffid to the sql command
                    try
                    {
                        using (SqlDataReader myReader = cmd.ExecuteReader())
                        {
                            while (myReader.Read())//'While' executes when their is no more to read
                            {
                                if (myReader["Privileges"].ToString() == "Admin") //If the user has admin privileges, true is returned
                                {
                                    adminPrivileges = true;
                                }


                            }
                        }
                    }
                    catch (System.Data.SqlClient.SqlException)  ///this is the only error that can occur during the myReader.read() so any other exception can be trated as a problem with the using (sqldatareader myReader = cmd.ExecuteReader())
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during reading the sqlDataReader", "60009");
                    }
                    catch (Exception)
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during the execution of the command", "60010");
                    }
                }
            }
            return adminPrivileges; //False is returned, either if the user doesnt have admin priveleges or a error occured.
        }

        public static string customersLastName(int customerID) //Returns the customers Lastname based on the CustomerID
        {
            string returnvalue = " ";
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select LastName from CUSTOMERS where CustomerID = @CustomerID", con))
                {

                    cmd.Parameters.AddWithValue("@CustomerID", customerID); //CustomerId parameter is added to the sql command
                    try
                    {
                        using (SqlDataReader myReader = cmd.ExecuteReader())
                        {
                            while (myReader.Read())//'While' executes when their is no more to read
                            {

                                return returnvalue = myReader["LastName"].ToString(); //Last Name is returned to the calling method
                            }
                        }
                    }
                    catch (System.Data.SqlClient.SqlException)  ///this is the only error that can occur during the myReader.read() so any other exception can be trated as a problem with the using (sqldatareader myReader = cmd.ExecuteReader())
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during reading the sqlDataReader", "60011");
                    }
                    catch (Exception)
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during the execution of the command", "60012");
                    }
                }
                return returnvalue; //In case of error, " " is returned and the calling method acts accordingly
            }
        }

        public static void setACabinInvalid(string stringKeysValue) //Makes a cabin invalid instead of deleting it
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE CABIN SET CabinDesc=@cabindesc WHERE CabinNo=@CabinNo", con)) //Updates the cabinDesc
                {

                    cmd.Parameters.AddWithValue("@cabindesc", "Inactive"); //Adds parameters to the sql command
                    cmd.Parameters.AddWithValue("@CabinNo", stringKeysValue);
                    try
                    {
                        cmd.ExecuteNonQuery(); //The sql command is executed
                    }
                    catch (Exception)
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during the execution of the nonQueryCommand", "60013");
                    }
                }
            }
        }

        public static string findCabinCapacity(string cabinNo) //Finds a cabin capacity based on its cabin number
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open();
                string cmdLine = string.Format("SELECT * from CABIN where CabinNo = {0}", cabinNo); //The sql command is created using string.format
                using (SqlCommand cmd = new SqlCommand(cmdLine, con))
                {
                    try
                    {
                        using (SqlDataReader myReader = cmd.ExecuteReader())
                        {
                            while (myReader.Read())//'While' executes when their is no more to read
                            {
                                return myReader["CabinCapacity"].ToString(); //The cabin capacity is returned
                            }
                        }
                    }
                    catch (System.Data.SqlClient.SqlException)  ///this is the only error that can occur furing the myReader.read() so any other exception can be trated as a problem with the using (sqldatareader myReader = cmd.ExecuteReader())
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during reading the sqlDataReader", "60014");
                    }
                    catch (Exception)
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during the execution of the command", "60015");
                    }
                }
                return "ERROR"; //Error is returned if it didnt work
            }
        }
    }

    class addToDatabase //Contains all the methods that add to records to the database
    {
        
        public static int addCustomer(CUSTOMERDetails newCustomer) //Adds to customer Table, A filled instance of the CUSTOMERDetails collection is passed into the method
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT into CUSTOMERS(Title, FirstName, LastName,DateOfBirth, Address, Town, PostCode, PhoneNo, Email) output INSERTED.CustomerID Values(@Title, @FirstName, @LastName, @DateOfBirth, @Address, @Town, @PostCode, @PhoneNo, @Email)", con))
                {
                    int CustomerID = -1;  ///If a exception is handled, then the customerID = -1 is returned and the if statement at the calling method regonizes this and reacts accordingly
                                          ///
                    cmd.Parameters.AddWithValue("@Title", newCustomer.Title); //Adds values to the parameters
                    cmd.Parameters.AddWithValue("@FirstName", newCustomer.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", newCustomer.LastName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", newCustomer.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Address", newCustomer.Address);
                    cmd.Parameters.AddWithValue("@Town", newCustomer.Town);
                    cmd.Parameters.AddWithValue("@PostCode", newCustomer.PostCode);
                    cmd.Parameters.AddWithValue("@PhoneNo", newCustomer.PhoneNo);
                    cmd.Parameters.AddWithValue("@Email", newCustomer.Email);

                    try
                    {
                        CustomerID = (int)cmd.ExecuteScalar(); //Executes the command and returns the auto incremented CustomerID
                        MessageBox.Show("The customer was successfully added");
                    }
                    catch (Exception)
                    {
                        unAssociatedMethods.genericErrorMessage(string.Format("Problem  arisen when trying to add the new Customer\nPlease retry"), "61001");
                    }
                    return CustomerID; //Returns the customerID to the calling method
                }
            }
        }

        public static int addBooking(BOOKINGDetails newBooking) //Adds to the Booking Table, A filled instance of the BOOKINGDetails collection is passed into the method
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT into BOOKING(CabinNo, NumOfAdults, NumOfChildren, StartDate, EndDate, Season, Price) output INSERTED.BookingID Values(@CabinNo, @NumOfAdults, @NumOfChildren, @StartDate, @EndDate, @Season, @Price)", con))
                {
                    int bookingID = -1; //if payment error aries, the booking process must be cancelled. Hence a -1 is returned to the caller to notify that method
                    cmd.Parameters.AddWithValue("@CabinNo", newBooking.CabinNo); //Adds values to the parameters
                    cmd.Parameters.AddWithValue("@NumOfAdults", newBooking.NumOfAdults);
                    cmd.Parameters.AddWithValue("@NumOfChildren", newBooking.NumOfChildren);
                    cmd.Parameters.AddWithValue("@StartDate", newBooking.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", newBooking.EndDate);
                    cmd.Parameters.AddWithValue("@Season", newBooking.Season);
                    cmd.Parameters.AddWithValue("@Price", newBooking.Price);
                    try
                    {
                        bookingID = (int)cmd.ExecuteScalar(); //Executes the sql command and returns the auto incremented bookingID. No message box is shown because further process are still needed to be run before the order is finalised
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage(string.Format("Problem  arisen when trying to add the new Booking\nPlease retry"), "61002");
                    }
                    return bookingID; //Returns the bookingID
                }
            }
        }

        public static int addPayment(PAYMENTDetails newPayment) //Adds to payment table, a filled instance of PAYMENTDetails collection is passed into the method
        {
            if (newPayment.PaymentType == "Cash") //If cash, then no values for card related fields (i.e nameOnCard) are entered and left null on the database. 
            {
                int paymentID = addCashPayment(newPayment); //This adds a new payment without card related fields having any data input. The paymentID is returned
                return paymentID; //The payment id is returned
            }
            using (SqlConnection con = new SqlConnection(constants.connectionString)) 
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT into PAYMENTS(PaymentType, NameOnCard, CardNumber, SecurityCode, ExpiryDate, AmountPaid, DatePaid) output INSERTED.PaymentID Values(@PaymentType, @NameOnCard, @CardNumber, @SecurityCode, @ExpiryDate, @AmountPaid, @DatePaid)", con))
                {
                    int paymentID = -1; //if payment error aries, the booking must be deleted. Hence a -1 is returned to the caller to notify that method
                    cmd.Parameters.AddWithValue("@PaymentType", newPayment.PaymentType); //Adds values to the parameters
                    cmd.Parameters.AddWithValue("@NameOnCard", newPayment.NameOnCard);
                    cmd.Parameters.AddWithValue("@CardNumber", newPayment.CardNumber);
                    cmd.Parameters.AddWithValue("@SecurityCode", newPayment.SecurityCode);
                    cmd.Parameters.AddWithValue("@ExpiryDate", newPayment.ExpiryDate);
                    cmd.Parameters.AddWithValue("@AmountPaid", newPayment.AmountPaid);
                    cmd.Parameters.AddWithValue("@DatePaid", newPayment.DatePaid);
                    try
                    {
                        paymentID = (int)cmd.ExecuteScalar(); //Executes the sql command and returns the auto incremented payment ID
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage(string.Format("Problem  arisen when trying to add the new Payment\nPlease retry"), "61003");
                    }
                    return paymentID; //Returns payment id
                    
                }
            }
        }

        private static int addCashPayment(PAYMENTDetails newPayment) //Adds a cash payment to the payment table
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT into PAYMENTS(PaymentType, AmountPaid, DatePaid) output INSERTED.PaymentID Values(@PaymentType, @AmountPaid, @DatePaid)", con))
                {
                    int paymentID = -1; //if payment error aries, the booking must be deleted. Hence a -1 is returned to the caller to notify that method
                    cmd.Parameters.AddWithValue("@PaymentType", newPayment.PaymentType); //Adds values to the parameters
                    cmd.Parameters.AddWithValue("@AmountPaid", newPayment.AmountPaid);
                    cmd.Parameters.AddWithValue("@DatePaid", newPayment.DatePaid);
                    try
                    {
                        paymentID = (int)cmd.ExecuteScalar(); //The sql command is executed and the auto incremented payment id is returned
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage(string.Format("Problem  arisen when trying to add the new Payment\nPlease retry"), "61007");

                    }
                    return paymentID; //Payment id is returned to calling method

                }
            }
        }

        public static void addLinks(LINKTABLEDetails newLink) //Adds records to the linktable, a filled instance of the LINKTABLEDetails collection is passed into the method
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT into LINKTABLE(CustomerID, BookingID, StaffID, PaymentID) Values(@CustomerID, @BookingID, @StaffID, @PaymentID)", con))
                {

                    cmd.Parameters.AddWithValue("@CustomerID", newLink.CustomerID); //adds value to the parameters
                    cmd.Parameters.AddWithValue("@BookingID", newLink.BookingID);
                    cmd.Parameters.AddWithValue("@StaffID", newLink.StaffID);
                    cmd.Parameters.AddWithValue("@PaymentID", newLink.PaymentID);
                    try
                    {
                        cmd.ExecuteNonQuery(); //Executes the sql command
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage(string.Format("Problem  arisen when trying to add the new Links\nPlease retry\nThe Bookings and Payments will now be deleted\nThe order has not been completed"), "61004");
                        deleteFromDatabase.deleteRecords("BookingID", newLink.BookingID, "BOOKING"); ///DELETE THE BOOKING AND PAYMENT
                        deleteFromDatabase.deleteRecords("PaymentId", newLink.PaymentID, "PAYMENTS");
                    }
                }
            }
               
        }

        public static void addStaff(STAFFDetails newStaffMember) //Adds records to the staff table, a filled instance of the STAFFDetails collection is passed into the method
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open(); //Opens the connection
                using (SqlCommand cmd = new SqlCommand("INSERT into STAFF(Title, FirstName, LastName, DateOfBirth, Address, Town, PostCode, PhoneNo, Email, UserName, Password, [Privileges]) VALUES(@Title, @FirstName, @LastName, @DateOfBirth, @Address, @Town, @PostCode, @PhoneNo, @Email, @UserName, @Password, @Privileges)", con))
                {

                    cmd.Parameters.AddWithValue("@Title", newStaffMember.Title); //Adds values to the parameters
                    cmd.Parameters.AddWithValue("@FirstName", newStaffMember.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", newStaffMember.LastName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", newStaffMember.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Address", newStaffMember.Address);
                    cmd.Parameters.AddWithValue("@Town", newStaffMember.Town);
                    cmd.Parameters.AddWithValue("@PostCode", newStaffMember.PostCode);
                    cmd.Parameters.AddWithValue("@PhoneNo", newStaffMember.PhoneNo);
                    cmd.Parameters.AddWithValue("@Email", newStaffMember.Email);
                    cmd.Parameters.AddWithValue("@UserName", newStaffMember.UserName);
                    cmd.Parameters.AddWithValue("@Password", newStaffMember.Password);
                    cmd.Parameters.AddWithValue("@Privileges", newStaffMember.Privileges);

                    try
                    {
                        cmd.ExecuteNonQuery(); //Executes the sql command
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage(string.Format("Problem  arisen when trying to add the new Staff\nPlease retry"), "61005");
                        return; //Exits the execution of this method
                    }
                    MessageBox.Show("The Staff Member was successfully added!");     
                }
            }
        }

        public static void addCabin(CABINDetails newCabin) //Adds records to the cabin table, a filled instance of the CABINDetails collection is passed into the method
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open(); //Connection is opened
                using (SqlCommand cmd = new SqlCommand("INSERT into CABIN(CabinDesc, CabinCapacity, CabinType) VALUES(@CabinDesc, @CabinCapacity, @CabinType)", con))
                {

                   cmd.Parameters.AddWithValue("@CabinDesc", newCabin.CabinDesc); //Adds values to the parameters
                   cmd.Parameters.AddWithValue("@CabinCapacity", newCabin.CabinCapacity);
                   cmd.Parameters.AddWithValue("@CabinType", newCabin.CabinType);
                   try
                   {
                       cmd.ExecuteNonQuery(); //Executes the sql command
                   }
                   catch
                   {
                       unAssociatedMethods.genericErrorMessage(string.Format("Problem  arisen when trying to add the new Cabin\nPlease retry"), "61006");
                       return; //Stops further execution of this method
                   }
                    MessageBox.Show("The Cabin was successfully added!"); 
                }
            }
        }
    }

    class deleteFromDatabase //Contains all methods that delete records from the database
    {
        public static void deleteLinks(string keysName, string keysValue) //Deletes records from the mainlinktable
        {
            LINKTABLEDetails linkToDelete = returnDATAinTable(keysName, keysValue); //Gets a filled instance of the LINKTABLEDetails collection, containing the records to be deleted

            if (linkToDelete == null) //Doesnt continue execution if the table is null
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open();
                string cmdLine = string.Format("DELETE FROM LINKTABLE WHERE {0}={1}", keysName, keysValue); //Formats the sql command string. KeysName is the name of the key(i.e BookingID) and keysValue is the value of that keyname(i.e 4). Therefore the bookingId is 4
                using (SqlCommand cmd = new SqlCommand(cmdLine, con))
                {
                    try
                    {
                        cmd.ExecuteNonQuery(); //Executes the sql command
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage(string.Format("Problem  arisen when trying to delete the links\nPlease retry\nThe records have not been deleted"), "62001");
                        return; //Stops further execution of the method
                    }

                }
            }

            if (keysName == "CustomerID") //can assume that since the column name is customerID, the person want to delete their customer records and all its records. Where as if it isnt, then we dont delete the customer Record. For example, if a person wants their booking deleted, that doesnt mean they want their customer record deleted

            {
                deleteRecords("CustomerID", linkToDelete.CustomerID, "CUSTOMERS");
            }

            if (keysName == "StaffID") //Can assume that if column name is staffID, we delete the staff members table and records related,  For example, if a person wants their booking deleted, that doesnt mean that the staff record should be deleted
            {
                deleteRecords("StaffID", linkToDelete.StaffID, "STAFF");
                MessageBox.Show("Records succesfully deleted!");
                return;
            }

            deleteRecords("BookingID", linkToDelete.BookingID, "BOOKING");
            deleteRecords("PaymentID", linkToDelete.PaymentID, "PAYMENTS");
            MessageBox.Show("Records succesfully deleted!");

        }

        private  static LINKTABLEDetails returnDATAinTable(string keysName, string keysValue) //Fills a LINKTABLEDetails instance with fields
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open();
                string cmdLine = string.Format("SELECT * FROM LINKTABLE WHERE {0}={1}", keysName, keysValue); //Formats the sql command string. The '*' is used since all fields in a record must be fetched
                using (SqlCommand cmd = new SqlCommand(cmdLine, con))
                {
                    LINKTABLEDetails linkToDelete = new LINKTABLEDetails(); //Creates a new instance of the LINKTABLEDetails collection

                    try
                    {
                        using (SqlDataReader myReader = cmd.ExecuteReader()) //executes a sqldatareader
                        {

                            while (myReader.Read()) //Will keep reading until their is no more for the sqldatareader to read
                            {

                                linkToDelete.CustomerID = Convert.ToInt16(myReader["CustomerID"].ToString()); //fills the new instance of the LINKTABLEDetails collection
                                linkToDelete.BookingID = Convert.ToInt16(myReader["BookingID"].ToString());
                                linkToDelete.StaffID = Convert.ToInt16(myReader["StaffID"].ToString());
                                linkToDelete.PaymentID = Convert.ToInt16(myReader["PaymentID"].ToString());
                                return linkToDelete;
                            }
                        }
                    }
                    catch (System.Data.SqlClient.SqlException)  ///this is the only error that can occur during the myReader.read() so any other exception can be trated as a problem with the using (sqldatareader myReader = cmd.ExecuteReader())
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during reading the sqlDataReader", "62002");
                    }
                    catch (Exception)
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during the execution of the command", "62003");
                    }

                    return linkToDelete; //Returns the LINKTABLEDetails collection to the calling method
                }
            }
                

        }

        public static void deleteRecords(string keysName, int keysValue, string table) //This is the default method used to delete records
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open(); //connection is opened
                string cmdLine = string.Format("DELETE FROM {2} WHERE {0}={1}", keysName, keysValue.ToString(), table); //Formats the sql command string. KeysName example = BookingID, KeysValue example = 4, table example = BOOKING
                using (SqlCommand cmd = new SqlCommand(cmdLine, con))
                {
                    try
                    {
                        cmd.ExecuteNonQuery(); //Executes the sql command
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage(string.Format("Problem arisen while trying to execute the nonQueryCommand\nRecords being used:\nTable:{0}\nColumn Name:{1}\nColumn Value:{2}", table, keysName, keysValue), "62004");
                    }
                }
            }
        }

        public static void findAllBookingIdsForThatCabin(string stringKeysValue) //Finds all the bookings that have used this cabin
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open(); //opens connection
                string cmdLine = string.Format("SELECT * FROM BOOKING WHERE CabinNo={0}", stringKeysValue); //Formats sql command string. If the CabinNo was 4, then stringKeysValue = 4
                using (SqlCommand cmd = new SqlCommand(cmdLine, con))
                {
                    try
                    {
                        using (SqlDataReader myReader = cmd.ExecuteReader()) //Executes the sql command using a sqldatareader
                        {
                            while (myReader.Read()) //Reads 'while' their is still records to read
                            {
                                deleteLinks("BookingID", myReader["BookingID"].ToString()); //Deletes the booking 
                            }
                        }
                    }
                    catch (System.Data.SqlClient.SqlException)  ///this is the only error that can occur during the myReader.read() so any other exception can be trated as a problem with the using (sqldatareader myReader = cmd.ExecuteReader())
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during reading the sqlDataReader", "62005");
                    }
                    catch (Exception)
                    {
                        unAssociatedMethods.genericErrorMessage("Problem  arisen during the execution of the command", "62006");
                    }
                }

                //After all bookings related to that cabin are deleted, The cabin is deleted
                cmdLine = string.Format("DELETE FROM CABIN WHERE CabinNo = {0}", stringKeysValue); //Formats the sql command string
                using (SqlCommand cmd = new SqlCommand(cmdLine, con))
                {
                    try
                    {
                        cmd.ExecuteNonQuery(); //Executes the sql command
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage(string.Format("Problem arisen while trying to execute the nonQueryCommand\nRecords being used:\nCabin No:{0}", stringKeysValue), "62007");
                    }
                }
            }
        }
    }

    class updateDatabase //Contains all methods that update database records
    {
        public static void updateTable(string changeToBeSaved, string nameOfColumnChanged, string keysName, string stringKeysValue) //This is the default method used to update records
        {
            //ChangeToBeSaved Example = Johnathan, nameOfColumnChanged = FirstName, keysName = CustomerID, stringKeysValue = 5
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open(); //Connection is opened
                string table = returnsTable(keysName); //Find out what table to use
                string cmdLine = string.Format("UPDATE {0} SET {1}=@change WHERE {2}={3}", table, nameOfColumnChanged, keysName, stringKeysValue); //Example) UPDATE CUSTOMERS SET FirstName=Johnathan WHERE CustomerID=5

                using (SqlCommand cmd = new SqlCommand(cmdLine, con))
                {

                    cmd.Parameters.AddWithValue("@change", changeToBeSaved); //Adds the change to the parameters
                    try
                    {
                        cmd.ExecuteNonQuery(); //Executes the sql command
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage(string.Format("Problem arisen while trying to execute the nonQueryCommand\nProcess=UpdateTable\nRecords being used:\nChange {0} in {1} to {2}", nameOfColumnChanged, table,changeToBeSaved ), "63001");
                    }
                }
            }
        }
        
        private static string returnsTable(string keysName) //Returns the name of the table to be used during the update process
        {
            switch (keysName) //Keysname example = CustomerID
            {
                case "CustomerID":
                    return "CUSTOMERS";
                case "BookingID":
                    return "BOOKING";
                case "PaymentID":
                    return "PAYMENTS";
                case "StaffID":
                    return "STAFF";
                case "CabinNo":
                    return "CABIN";
                default:
                    return "ERROR";
                    break;
            }
        }



    }

    class dataGridViewStuff //Contains all methods that are used for datagridview datasources
    {

        //OverView DATAGRIDVIEWS
        public static DataTable showStaffsMostRecentBookings(int staffid) //Shows the most recent bookings for that staff member
        {
            DataTable dt = new DataTable(); //Creates a new datatable instance
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open(); //connects to database

                using (SqlDataAdapter da = new SqlDataAdapter("SELECT LINKTABLE.StaffID, BOOKING.CabinNo, BOOKING.StartDate, BOOKING.EndDate FROM LINKTABLE INNER JOIN BOOKING ON LINKTABLE.BookingID = BOOKING.BookingID where LINKTABLE.StaffID=" + staffid, con)) //Uses inner join to get most recent bookings
                {
                    try
                    {
                        da.Fill(dt); //Fills the datatable
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage("Error occured when tryng to show most recent staff member's bookings", "64001");
                    }

                    return dt; //The datatable is returned
                }

            }
        }

        public static DataTable todaysDepartures() //Shows todays departures
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open(); //Opens sql connection 
                using (SqlDataAdapter da = new SqlDataAdapter("Select * from BOOKING", con))
                {
                    DataTable dt = new DataTable(); //Creates a new instance of a data table
                    try
                    {
                        da.Fill(dt); //Fills the datatable
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage("Error occured when tryng to show today's departures bookings", "64002");
                    }

                    DateTime EndDate = DateTime.Now; //Sets enddate
                    string stringEndDate = EndDate.ToString("dd/MM/yyyy"); //Formats the enddate to same format of that in the database

                    foreach (DataRow dr in dt.Rows) //Loops through the datatable
                    {
                        if (dr["EndDate"].ToString().Substring(0, 10) != stringEndDate) //Records in the datatable that dont have a enddate equal to today are deleted from the datatable
                        {
                            dr.Delete();
                        }
                    }

                    return dt; //Returns the datatable
                }
            }
        }

        public static DataTable todaysArrivals() //Shows todays arrivals
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open(); //Connects to database
                using (SqlDataAdapter da = new SqlDataAdapter("Select * from BOOKING", con))
                {

                    DataTable dt = new DataTable(); //Creates a new instance of a datatable
                    try
                    {
                        da.Fill(dt);//Fills the datatable
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage("Error occured when tryng to show today's arrivals bookings", "64003");
                    }

                    DateTime startDate = DateTime.Now; //Sets startdate
                    string stringStartDate = startDate.ToString("dd/MM/yyyy");//Formats the startdate to that of the database format

                    foreach (DataRow dr in dt.Rows)//Loops through the datatable
                    {
                        if (dr["StartDate"].ToString().Substring(0,10) != stringStartDate)//Records in the datatable that dont have a startdate equal to today are deleted from the datatable
                        {
                            dr.Delete();
                        }
                    }

                    return dt; //returns the datatable
                }
            }
        }

        //MAKEABOOKING DATAGRIDVIEWS
        public static DataTable customerDetails(string lastname, DateTime DOB) //Returns a datatable that contains customer details
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open(); //connects to database
                using (SqlDataAdapter da = new SqlDataAdapter("select * from CUSTOMERS", con))
                {
                    DataTable dt = new DataTable(); //Creates a new instance of a datatable
                    try
                    {
                        da.Fill(dt); //fills the data table
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage("Error occured when tryng to show Customer Details", "64004");
                    }

                    string stringDOB = DOB.ToString("dd/MM/yyyy"); //Formats the date into the same format as the database

                    foreach (DataRow dr in dt.Rows)//Loops through the datatable
                    {
                        if (dr["DateOfBirth"].ToString().Substring(0, 10) != stringDOB || dr["LastName"].ToString() != lastname) //If Requirements arent met, then the record is deleted
                        {
                            dr.Delete();
                        }
                    }

                    return (dt);//returns the datatable
                }
            }
        }

        ///LOOKUP DATAGRIDVIEWS
        public static DataTable staffDetails(string lastname, DateTime DOB) //Returns a datatable that contains Staff details
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open(); //connects to database
                using (SqlDataAdapter da = new SqlDataAdapter("select * from STAFF", con))
                {


                    DataTable dt = new DataTable(); //Creates a new instance of a databale
                    try
                    {
                        da.Fill(dt); //fills the datatable
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage("Error occured when tryng to show Staff Details", "64005");
                    }

                    string stringDOB = DOB.ToString("dd/MM/yyyy"); //Formats the date into the format used in the database

                    foreach (DataRow dr in dt.Rows) //loops through the datatable
                    {
                        if (dr["DateOfBirth"].ToString().Substring(0, 10) != stringDOB || dr["LastName"].ToString() != lastname) //if requirments arent met, then the record is deleted
                        {
                            dr.Delete();
                        }
                    }

                    return (dt); //returns datatable to calling method
                }
            }
        }

        public static DataTable cabinDetails(string cabinType) //Returns a datatable that contains cabin details
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open(); //Connects to database
                using (SqlDataAdapter da = new SqlDataAdapter("select * from CABIN", con))
                {


                    DataTable dt = new DataTable(); //Creates a new instance of a datatable
                    try
                    {
                        da.Fill(dt); //fills the datatabel
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage("Error occured when tryng to show Cabin Details", "64006");
                    }


                    foreach (DataRow dr in dt.Rows) //loops through the datatable
                    {
                        if (dr["CabinType"].ToString() != cabinType) //if the Cabin's cabintype doesnt match the cabin type searched for, then it is deleted from the datatable
                        {
                            dr.Delete();
                        }
                    }

                    return (dt); //return the datatable to the calling method
                }
            }


        }

        public static DataTable paymentDetails(string nameOnCard, string cardNumber) //Returns a datatable that contains payment details
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open(); //connects to database
                using (SqlDataAdapter da = new SqlDataAdapter("select * from PAYMENTS", con))
                {


                    DataTable dt = new DataTable(); //creates a new instance of a datatable
                    try
                    {
                        da.Fill(dt); //fill the datatable
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage("Error occured when tryng to show Payment Details", "64007");
                    }


                    foreach (DataRow dr in dt.Rows) //loops through the datatbale
                    { 
                        if (dr["NameOnCard"].ToString() != nameOnCard || dr["CardNumber"].ToString() != cardNumber) //If search requirmenets arent met, then the record is deleted from the datatable
                        {
                            dr.Delete();
                        }
                    }

                    return (dt); //returns the datatable
                }
            }
        }

        public static DataTable bookingDetails(DateTime startDate, DateTime endDate) //returns a datatable that contains booking details
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open(); //connects to the database
                using (SqlDataAdapter da = new SqlDataAdapter("select * from BOOKING", con))
                {


                    DataTable dt = new DataTable(); //creates a new instance of the datatable
                    try
                    {
                        da.Fill(dt); //fills the datatable
                    }
                    catch
                    {
                        unAssociatedMethods.genericErrorMessage("Error occured when tryng to show Booking Details", "64008");
                    }

                    string stringStartDate = startDate.ToString("dd/MM/yyyy"); //formats the dates into the format used on the database
                    string stringEndDate = endDate.ToString("dd/MM/yyyy");

                    foreach (DataRow dr in dt.Rows) //loops through the datatable
                    {
                        if (dr["StartDate"].ToString().Substring(0, 10) != stringStartDate || dr["EndDate"].ToString().Substring(0, 10) != stringEndDate)  //if the search requirments arent met, the record is deleted from the datatable
                        {
                            dr.Delete();
                        }
                    }

                    return (dt); //return the datatable
                }
            }
        }

        public static DataTable showSelectedTableDetails(string keysName, int keysValue, string targetTable, string targetKeysName, string whatToGetFromTable, string tableToLinkTo) //Used to 'jump' along the relationships to other tables and display that table
        {
            using (SqlConnection con = new SqlConnection(constants.connectionString))
            {
                con.Open(); //connects to database
                string dataAdapterCommand = string.Format("SELECT {4} FROM {5} INNER JOIN {0} ON {5}.{1} = {0}.{1} where {5}.{2}={3}", targetTable, targetKeysName, keysName, keysValue, whatToGetFromTable, tableToLinkTo); 
                //Ex) SELECT BOOKING.FirstName, BOOKING.LastName etc FROM LINKTABLE INNER JOIN BOOKING ON LINKTABLE.BookingID=BOOKING.BookingID where LINKTABLE.CustomerID=3
                using (SqlDataAdapter da = new SqlDataAdapter(dataAdapterCommand, con))
                {

                    DataTable dt = new DataTable(); //Creates a new instance of the datatable
                    try
                    {
                        da.Fill(dt); //fills the datatable
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        if (targetTable == "Cabin") //This error can be caused by the target table = cabin because cabin table has a relationship with the booking table. So trying to jump from customer table to the cabin table will cause a error. Can only jump from booking to cabin
                        {
                            unAssociatedMethods.genericErrorMessage("Can't jump straight to Cabin Records \nPlease navigate to the Bookings Table and select a Booking", "64009");
                        }
                        else
                        {
                            unAssociatedMethods.genericErrorMessage("Can't jump straight from Cabin Records \nPlease navigate to the Bookings Table from the CabinNo first", "64010");
                        }

                        return null;
                        throw;
                    }
                    return (dt); //Returns the datatable
                }
            }
        }
    }
}


