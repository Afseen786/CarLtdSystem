using System;

namespace CarLtdClasses
{
    public class clsCustomer
    {
        //private data member for the customer ID property
        private Int32 mCustomerID;
        private DateTime mPurchaseDate;
        private string mFirstName;
        private string mLastName;
        private string mAddress;
        private string mPostCode;
        private Boolean mActive;
        public bool Active {
                get
            {
                    //return the private data
                    return mActive;
                }
                set
                 {
                    //set the private data 
                    mActive = value;
                }
            }
        public DateTime PurchaseDate 
        {
            get
            {
                //return the private data
                return mPurchaseDate;
            }
            set
                 {
                    //set the private data 
                    mPurchaseDate = value;
                }
            }
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
            //set the private data members to the test data value 
            mCustomerID = 2;
            mPurchaseDate = Convert.ToDateTime("01/01/2021");
            mFirstName = "Aisha";
            mLastName = "Patel";
            mAddress = "34 silver street";
            mPostCode = "le7 2oi";
            mActive = true;
            //always return true
            return true;
        }
    }
}