using CarLtdClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CarLtdTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void instanceOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void thisCustomerPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            clsCustomer TestCustomer = new clsCustomer();
            //set this properties of the test object
            TestCustomer.active = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.FirstName = "Afseen";
            TestCustomer.LastName = "Asphak";
            TestCustomer.DateOfBirth = DateTime.Now.Date;
            TestCustomer.Address = "12 Rose Street";
            TestCustomer.PostCode = "LE5 3RT";
            TestCustomer.PhoneNumber = "02345678912";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void listAndCountOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set this properties 
            TestItem.active = true;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Afseen";
            TestItem.LastName = "Asphak";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "12 Rose Street";
            TestItem.PostCode = "LE5 3RT";
            TestItem.PhoneNumber = "02345678912";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }
}
