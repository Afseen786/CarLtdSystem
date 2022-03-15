using CarLtdClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarLtdClasses
{
    public class clsOrder
    {
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);

        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);

        }

        public string Valid(string orderNo, string orderName, string orderStatus, string orderDate, string billingAddress)
        {
            //create a string variable to store the rror
            String Error = "";
            //create a temporary variable to store data values
            DateTime DateTemp;
            //if the OrderNo is blank
            if (orderNo.Length == 0)
            {
                //record the error
                Error = Error + "The order no must not be blank : ";
            }
            //if the order no is greater than 6 characters
            if (orderNo.Length > 6)
            {
                //record the error
                Error = Error + "the order no must be less than 6 characters : ";
            }
        try 
        { 
            //copy the dateAdded value to the DateTemp variable
            DateTemp = Convert.ToDateTime(orderDate);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "the date cannot be in the past : ";
            }
            //check to see if the date is greater than today's date
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "the date cannot be in the future : ";
            }
        }
        catch
        {
        //record the error
        Error = Error + "The date was not a valid date : ";
        }

            //return any error messages
            return Error;
        }

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

        public bool Find(int AddressNo)
        {
            //set the private data members to the test data value

            mOrderNo = 10;

            mOrderName = "ORD999";

            mOrderStatus = "SHIPPED";

            mOrderDate = Convert.ToDateTime("10/02/2015");

            mBillingAddress = "30 Berry Street";

            mActive = true;
            
            //always return true
            return true;
        }
    }
}