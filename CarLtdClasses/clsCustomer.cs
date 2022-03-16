using ClassLibrary;
using System;

namespace CarLtdClasses
{

    public class clsCustomer
    {
        //private data member for the active property
        private Boolean mactive;
        public bool active
        {
            get
            {
                //return the private data
                return mactive;
            }
            set
            {
                //set the private data 
                mactive = value;
            }
        }
        //private data member for the date of birth property
        private DateTime mDateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the private data 
                mDateOfBirth = value;
            }
        }
        //private data member for the customer ID property
        private Int32 mCustomerID;
        public int CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the private data 
                mCustomerID = value;
            }
        }
        //private data member for the firstname property
        private string mFirstName;
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the private data 
                mFirstName = value;
            }
        }
        //private data member for the phonenumber property
        private string mPhoneNumber;
        public string PhoneNumber
        {
            get
            {
                //return the private data
                return mPhoneNumber;
            }
            set
            {
                //set the private data 
                mPhoneNumber = value;
            }
        }
        //private data member for the lastname property
        private string mLastName;
        public string LastName
        {
            get
            {
                //return the private data
                return mLastName;
            }
            set
            {
                //set the private data 
                mLastName = value;
            }
        }
        //private data member for the Postcode property
        private string mPostCode;
        public string PostCode
        {
            get
            {
                //return the private data
                return mPostCode;
            }
            set
            {
                //set the private data 
                mPostCode = value;
            }
        }
        //private data member for the address property
        private string mAddress;
        public string Address
        {
            get
            {
                //return the private data
                return mAddress;
            }
            set
            {
                //set the private data 
                mAddress = value;
            }
        }

        public bool Find(int CustomerID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found ( there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mactive = Convert.ToBoolean(DB.DataTable.Rows[0]["active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string firstName, string lastName, string dateOfBirth, string address, string postCode, string phoneNumber)
        {
                //create a string varibale to store the error 
                String Error = "";
                //create a temporary variable to store date values 
                DateTime DateTemp;
                //if the firstname is blank
                if (firstName.Length == 0)
                {
                    //record the error
                    Error = Error + "The first name should not be blank :";
                }
                //if the firstname is greater than 21 characters 
                if (firstName.Length > 20)
                {
                    //record the error
                    Error = Error + "The first name must be less than 20 characters :";
                }
                //if the lastname  is blank
                if (lastName.Length == 0)
                {
                    //record the error
                    Error = Error + "The last name should not be blank :";
                }
                //if the last name is greater than 31 characters 
                if (lastName.Length > 30)
                {
                    //record the error
                    Error = Error + "The last name must be less than 30 characters :";
                }
                try
                {
                    //copy the date of birth value to the datetemp variable 
                    DateTemp = Convert.ToDateTime(dateOfBirth);
                    if (DateTemp < DateTime.Now.Date)
                    {
                        //record the error
                        Error = Error + "The dateofbirth cannot be in the past : ";
                    }
                    //check to see if the date is greater than today's date
                    if (DateTemp > DateTime.Now.Date)
                    {
                        //record the error
                        Error = Error + "The dateofbirth cannot be in the future : ";
                    }
                }
                catch
                {
                    //record the error 
                    Error = Error + "The date was not a valid date : ";
                }
                //if the address  is blank
                if (address.Length == 0)
                {
                    //record the error
                    Error = Error + "The address should not be blank :";
                }
                //if the address is greater than 36 characters 
                if (address.Length > 35)
                {
                    //record the error
                    Error = Error + "The address must be less than 35 characters :";
                }
                //if the postcode is blank 
                if (postCode.Length == 0)
                {
                    //record the error 
                    Error = Error + "The post code may not be blank : ";
                }
                //if the post code is too long 
                if (postCode.Length > 7)
                {
                    //record the error 
                    Error = Error + "The post code must be less than 7 characters : ";
                }
            //if the phone number is blank 
            if (phoneNumber.Length == 0)
            {
                //record the error 
                Error = Error + "The phone number may not be blank : ";
            }
            //if the post code is too long 
            if (phoneNumber.Length > 11)
            {
                //record the error 
                Error = Error + "The phone number must be less than 11 characters : ";
            }
            //return any error message 
            return Error;
            }
    }
    }
