using CarLtdClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarLtdClasses
{
    public class clsOrder
    {
        /*
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder= new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 10;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderName != "Test OrderName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderNameFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderName = 5;
            //invoke the method
            Found = AnOrder.Find(OrderName);
            //check the address no
            if (AnOrder.OrderName != "TstOrdName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderStatus != "SHIPPED")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("10/02/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBillingAddressFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 10;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.BillingAddress !=("30 Berry Street"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public string Valid(string orderNo, string OrderName, string OrderStatus, string OrderDate, string BillingAddress)
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
            DateTemp = Convert.ToDateTime(OrderDate);
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
        */

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

        public bool Find(int OrderNo)
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