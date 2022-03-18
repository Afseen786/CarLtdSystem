using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarLtdClasses
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //clsDataConnection DBConnection;
        //private data member thisCustomers
        clsCustomer mThisCustomer = new clsCustomer();
        //constructor for the class
        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DBConnection = new clsDataConnection();
            //execute the stored procedure 
            DBConnection.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DBConnection);
        }
        

        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //public property for count
        public Int32 Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
        }
        //public property for thiscustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data 
                return mThisCustomer;
            }
            set
            {
                //set the private data 
                mThisCustomer = value;
            }
        }
        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DBConnection = new clsDataConnection();
            //set the parameters for the stored procedure 
            DBConnection.AddParameter("@FirstName", mThisCustomer.FirstName);
            DBConnection.AddParameter("@LastName", mThisCustomer.LastName);
            DBConnection.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DBConnection.AddParameter("@Address", mThisCustomer.Address);
            DBConnection.AddParameter("@PostCode", mThisCustomer.PostCode);
            DBConnection.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DBConnection.AddParameter("@active", mThisCustomer.active);
            //execute the query returning the primary key value
            return DBConnection.Execute("sproc_tblCustomer_Insert");

        }
        public void Delete()
        {
            //deletes the record pointed to by ThisCustomer
            //connect to the database
            clsDataConnection DBConnection = new clsDataConnection();
            //set the parameters for the stored procedure 
            DBConnection.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure 
            DBConnection.Execute("sproc_tblCustomer_Delete");
        }
        public void Update()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DBConnection = new clsDataConnection();
            //set the parameters for the stored procedure 
            DBConnection.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DBConnection.AddParameter("@FirstName", mThisCustomer.FirstName);
            DBConnection.AddParameter("@LastName", mThisCustomer.LastName);
            DBConnection.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DBConnection.AddParameter("@Address", mThisCustomer.Address);
            DBConnection.AddParameter("@PostCode", mThisCustomer.PostCode);
            DBConnection.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DBConnection.AddParameter("@active", mThisCustomer.active);
            //execute the query returning the primary key value
            DBConnection.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByPostCode(string PostCode)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DBConnection = new clsDataConnection();
            //send the postcode parameter to the database
            DBConnection.AddParameter("@PostCode", PostCode);
            //execute the stored procedure
            DBConnection.Execute("sproc_tblCustomer_FilterByPostCode");
            //populate the array list with the data table 
            PopulateArray(DBConnection);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                ACustomer.active = Convert.ToBoolean(DB.DataTable.Rows[Index]["active"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }
    }
}
