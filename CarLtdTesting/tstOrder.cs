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
        public void FindMethodOK()
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
            Int32 OrderNo = 21;
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
        public void TestOrderNameFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderName = 15;
            //invoke the method
            Found = AnOrder.Find(OrderName);
            //check the property
            if (AnOrder.OrderName != "Test Order Name")
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
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderStatus != "SHIPPED");
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
            if (AnOrder.OrderDate != Convert.ToDateTime("16/09/2015"))
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
    }
}
/*
public string Valid(string OrderNo, string OrderName, string OrderStatus, string OrderDate, string BillingAddress)
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

            //order name
            if (OrderName.Length == 0)
            {
                //record the error
                Error = Error + "The order name may not be blank : ";
            }
            //if the order name is greater than 30 characters
            if (OrderName.Length > 30)
            {
                //record the error
                Error = Error + "The order name may not be more than 30 characters : ";
            }

            //order date
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
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //is the order status blank
            if (orderStatus.Length == 0)
            {
                //record the error
                Error = Error + "The order status may not be blank : ";
            }
            //if the order status is too long
            if (orderStatus.Length > 9)
            {
                //record the error
                Error = Error + "The order status must be less than 9 characters : ";
            }

            //is the billing address blank
            if (billingAddress.Length == 0)
            {
                //record the error
                Error = Error + "The billing address may not be blank : ";
            }
            //if the billing address is too long
            if (billingAddress.Length > 50)
            {
                //record the error
                Error = Error + "The billing address must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}
*/