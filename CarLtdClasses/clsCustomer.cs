using ClassLibrary;
using System;

namespace CarLtdClasses
{
    public class clsCustomer
    {
        //private data member for the active property
        private Boolean mactive;
        public bool active {
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
        public string FirstName {
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
    }
}