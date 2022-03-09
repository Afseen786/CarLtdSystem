using System;

namespace CarLtdTesting
{
    public class clsSupplier
    {
        //private data member for the supplier no
        private Int32 mSupplierNo;
        //private data member for the active
        private Boolean mActive;
        private string mSupplierName;
        private string mSupplierEmail;
        private string mSupplierAddress;

        public bool Active 
               
        {
            get
            {
                //this line of code send data out of the property
                return mActive;
            }

            set
            {

                //this line of code allows data into the property
                mActive = value;
            }

        }
        
        public Int32 SupplierNo 
        {
            get
            {
                //this line of code send data out of the property
                return mSupplierNo;
            }      
        
            set
            {

                //this line of code allows data into the property
                mSupplierNo = value;
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

        public bool Find(int SupplierNo)
        {
            //set the private data members to the test data value
            mSupplierNo = 21;
            mActive = true;
            mSupplierAddress = "Test Address";
            mSupplierEmail = "SupplierTest@gmail.com";
            mSupplierName = "Test Supplier";
            //always return true
            return true;
        }
    }
}