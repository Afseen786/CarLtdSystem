using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CarLtdClasses;
using System.Collections.Generic;

namespace CarLtdTesting
{
    [TestClass]
    public class tstOrderCollection
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

            [TestMethod]
            public void AddMethodOK()
            {
                //create an instance of the class we want to create
                clsOrderCollection AllOrders = new clsOrderCollection();
                //create the item of test data
                clsOrder TestItem = new clsOrder();
                //var to store the primary key
                Int32 PrimaryKey = 0;
                //set its properties
                TestItem.Active = true;
                TestItem.OrderNo = 1;
                TestItem.OrderName = "Ishvone";
                TestItem.OrderStatus = "Process";
                TestItem.OrderDate = DateTime.Now.Date;
                TestItem.BillingAddress = "23 Beaver Street";
                //set ThisOrder to the test data
                AllOrders.ThisOrder = TestItem;
                //add the record
                PrimaryKey = AllOrders.Add();
                //set the primary key of the test data
                TestItem.OrderNo = PrimaryKey;
                //find the record
                AllOrders.ThisOrder.Find(PrimaryKey);
                //test to see that the two values are the same
                Assert.AreEqual(AllOrders.ThisOrder, TestItem);
            }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.OrderName = "Ishvone";
            TestItem.OrderStatus = "SHIPPED";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.BillingAddress = "91 Anstey Way";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.OrderName = "Ishvone";
            TestItem.OrderStatus = "Delivered";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.BillingAddress = "10 Thorpe Road";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.OrderNo = 3;
            TestItem.OrderName = "Ish";
            TestItem.OrderStatus = "Viewed";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.BillingAddress = "9 Meadle Way";
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
    }   
}