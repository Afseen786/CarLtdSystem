using ClassLibrary;
using System;

namespace CarLtdTesting
{
    public class clsSupplier
    {
        //private data member for the supplier no
        private Int32 mSupplierId;
        //private data member for the active
        
        private string mSupplierName;
        private string mSupplierEmail;
        private string mSupplierAddress;

       
        
        public Int32 SupplierId 
        {
            get
            {
                //this line of code send data out of the property
                return mSupplierId;
            }      
        
            set
            {

                //this line of code allows data into the property
                mSupplierId = value;
            }
           
        
        }
        public string SupplierEmail
        {
            get
            {
                //this line of code send data out of the property
                return mSupplierEmail;
            }

            set
            {

                //this line of code allows data into the property
                mSupplierEmail = value;
            }
        }
        
        public string SupplierAddress
        {
            get
            {
                //this line of code send data out of the property
                return mSupplierAddress;
            }

            set
            {

                //this line of code allows data into the property
                mSupplierAddress = value;
            }
        }
        
        public string SupplierName
        {
            get
            {
                //this line of code send data out of the property
                return mSupplierName;
            }

            set
            {

                //this line of code allows data into the property
                mSupplierName = value;
            }
        }

        public bool Find(int SupplierId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the supplier no to search for
            DB.AddParameter("@SupplierId", SupplierId);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplierEmail = Convert.ToString(DB.DataTable.Rows[0]["SupplierEmail"]);
                mSupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return true;

            }
            
        }
    }
}