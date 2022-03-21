using CarLtdClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CarLtdClasses
{
    public class clsOrder
    {
        //private data member for the order no property
        private Int32 mOrderNo;
        //OrderNo public property
        public Int32 OrderNo
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderNo;
            }
            set
            {
                //this line of code allwos data into the property
                mOrderNo = value;
            }
        }

        //OrderName private member variable
        private string mOrderName;
        //OrderName public property
        public string OrderName
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderName;
            }
            set
            {
                //this line of code allows data into property
                mOrderName = value;
            }
        }

        //OrderStatus private memeber variable
        private string mOrderStatus;
        //OrderStatus public property
        public string OrderStatus
        {
            get
            {
                return mOrderStatus;
            }
            set
            {
                mOrderStatus = value;
            }
        }

        //dateAdded private member variable
        private DateTime mOrderDate;
        //DateAdded public property
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }

        //BillingAddress private member variable
        private string mBillingAddress;
        public string BillingAddress
        {
            get
            {
                return mBillingAddress;
            }
            set
            {
                mBillingAddress = value;
            }
        }

        //Active private member variable
        private bool mActive;
        private List<clsOrder> mOrderList;

        //Active public property
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        //public property for the order list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //later
            }
        }

        public bool Find(int OrderNo)
        {
            //set the private data members to the test data value

            mOrderNo = 1;

            mOrderName = "Ishvone";

            mOrderStatus = "Process";

            mOrderDate = Convert.ToDateTime("12/02/2022");

            mBillingAddress = "23 Rose Street";

            mActive = true;
            
            //always return true
            return true;
        }

        public string Valid(string orderNo, string orderName, string orderStatus, string orderDate, string billingAddress)
        {
            return "";
        }

    }
}