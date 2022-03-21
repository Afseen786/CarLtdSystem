using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace CarLtdClasses
{
    [TestClass]
    class tstOrderCollection
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Active = true;
            TestItem.OrderNo = 2;
            TestItem.OrderName = "Ish";
            TestItem.OrderStatus = "IN TRANSIT";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.BillingAddress = "13 Law Street";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            {
                //create some test data to assign to the property
                //in this case the data needs to be a list of objects
                List<clsOrder> TestList = new List<clsOrder>();
                //add an item to the list
                //create the item of test data
                clsOrder TestItem = new clsOrder();
                //set its properties
                TestItem.Active = true;
                TestItem.OrderNo = 1;
                TestItem.OrderName = "Ishvone";
                TestItem.OrderStatus = "SHIPPED";
                TestItem.OrderDate = DateTime.Now.Date;
                TestItem.BillingAddress = "23 Rose Street";
                //add the item to the test list
                TestList.Add(TestItem);
                //assign the data to the property
                AllOrders.OrderList = TestList;
                //test to see that the two values are the same
                Assert.AreEqual(AllOrders.Count, TestList.Count);
            }
        }
    }
}
