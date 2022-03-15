using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarLtdClasses;

namespace CarLtdTesting
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass to the method
        string OrderNo = "23";
        string OrderName = "ORD201";
        string OrderStatus = "DELIVERED";
        string OrderDate = Convert.ToString("10/05/2015");
        string BillingAddress = "15 Longway Road";

        [TestMethod]
        public void validMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void findMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to assign to the property
            int OrderNo = 10;
            Boolean OK;
            //assign the data to the property
            OK = AnOrder.Find(OrderNo);
            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNoFound()
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
            //check the address no
            if (AnOrder.OrderNo != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
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

        [TestMethod]
        public void OrderNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void OrderNoMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "a"; //this should be OK
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String OrderNo = "aaaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 10;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void OrderNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "ORD999";
            //assign the data to the property
            AnOrder.OrderName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderName, TestData);
        }

        [TestMethod]
        public void OrderStatusOK()
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
            if (AnOrder.OrderStatus != "SHIPPED")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderDateOK()
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
            if (AnOrder.OrderDate != Convert.ToDateTime("10/02/2015"))
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderNoInLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "2"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "";
            OrderNo = OrderNo.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test tp see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BillingAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "16 Hastle Road";
            //assign the data to the property
            AnOrder.BillingAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.BillingAddress, TestData);
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
            Int32 OrderNo = 10;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.Active != true)
            {
                OK = false;
            }
            //test to ee that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "10m";
            string OrderName = "Ish";
            string OrderStatus = "SHIPPED";
            string BillingAddress = "74 Poole Road";
            //set the OrderDate to a non date value
            string OrderDate = "This is not a date!";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see tat the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderStatus = "";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderStatus = "IN TRANSIT";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderStatus = "aa";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderStatus = "aaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderStatus = "aaaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderStatus = "aaaaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderStatus = "aaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BillingAddressLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string BillingAddress = "";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BillingAddressMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BillingAddress = "a";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BillingAddress = "aa";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BillingAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BillingAddress = "";
            BillingAddress = BillingAddress.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BillingAddressMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BillingAddresstMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string BillingAddress = "";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BillingAddressMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BillingAddress = "";
            BillingAddress = BillingAddress.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public string Valid(string orderNo, string orderName, string orderStatus, string orderDate, string billingAddress)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            //if the HouseNo is blank
            if (OrderNo.Length == 0)
            {
                //record the error
                Error = Error + "The order no may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (OrderNo.Length > 6)
            {
                //record the error
                Error = Error + "The order no must be less than 6 characters : ";
            }
            try
            {
                //copy the OrderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //return any error messages
                return Error;
            }
            //is the post code blank
            if (orderStatus.Length == 0)
            {
                //record the error
                Error = Error + "The order status may not be blank : ";
            }
            //if the post code is too long
            if (orderStatus.Length > 9)
            {
                //record the error
                Error = Error + "The order status must be less than 9 characters : ";
            }
            //is the street blank
            if (orderStatus.Length == 0)
            {
                //record the error
                Error = Error + "The order status may not be blank : ";
            }
            //if the street is too long
            if (orderStatus.Length > 50)
            {
                //record the error
                Error = Error + "The order status must be less than 50 characters : ";
            }
            //is the town blank
            if (BillingAddress.Length == 0)
            {
                //record the error
                Error = Error + "The billing address may not be blank : ";
            }
            //if the town is too long
            if (BillingAddress.Length > 50)
            {
                //record the error
                Error = Error + "The billing address must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}