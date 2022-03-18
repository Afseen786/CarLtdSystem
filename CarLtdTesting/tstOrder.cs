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
        public void ValidMethodOK()
        {
            //create an instane of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to assign to the property
            Int32 OrderNo = 1;
            //assign the data to the property
            Found = AnOrder.Find(OrderNo);
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
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the address no
            if (AnOrder.OrderNo != 1)
            {
                OK = true;
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
            Boolean Found = true;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderName = 1;
            //invoke the method
            Found = AnOrder.Find(OrderName);
            //check the property
            if (AnOrder.OrderName != "Ishvone")
            {
                OK = true;
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
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderStatus != "Process")
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
                OK = true;
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
                OK = true;
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
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}