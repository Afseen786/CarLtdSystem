using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary;

namespace CarLtdClasses
{
    public class clsStaff
    {
        private Boolean mActive; //Private data member for active property
        public bool Active //Public property for active
        {
            get
            {
                return mActive; //Return the private data
            }
            set
            {
                mActive = value; //Set the private data
            }
        }

        private DateTime mDateAdded; //Private data member for date added property
        public DateTime DateAdded //Public property for date added
        {
            get
            {
                return mDateAdded; //Return private data
            }
            set 
            {
                mDateAdded = value; //Set the private data
            }
        }

        private Int32 mStaffID; //Private data for staff id property
        public int StaffID //Public property for staff id
        {
            get
            {
                return mStaffID; //Return private data
            }
            set 
            {
                mStaffID = value; //Set the private data
            }
        }

        private string mFirstName; //Private data member for first name property
        public string FirstName //Public property for first name
        {
            get
            {
                return mFirstName; //Return private data
            }
            set
            {
                mFirstName = value; //Set the private data
            }
        }

        private string mLastName; //Private data member for last name property
        public string LastName //Public property for last name
        {
            get
            {
                return mLastName; //Return private data
            }
            set
            {
                mLastName = value; //Set the private data
            }
        }

        private string mDepartment; //Private data member for department property
        public string Department //Public property for department
        {
            get
            {
                return mDepartment; //Return private data
            }
            set
            {
                mDepartment = value; //Set the private data
            }
        }

        private string mPhoneNo; //Private data member for phone no property
        public string PhoneNo //Public property for phone no
        {
            get
            {
                return mPhoneNo; //Return private data
            }
            set
            {
                mPhoneNo = value; //Set the private data
            }
        }


        public bool Find(int staffID)
        {
            clsDataConnection DB = new clsDataConnection(); //Instance of data connection
            DB.AddParameter("@StaffID", StaffID); //Parameter for staff id to be searched
            DB.Execute("sproc_tblStaff_FilterByStaffID"); //Execute stored procedure
            if (DB.Count == 1) //If 1 record is found
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                return true; //Return everything worked
            }
            else //If no record found
            {
                return false; //Return false, indicating an issue
            }
        }
    }
}