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
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
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
        public void CustomerListOk()
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
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void ListAndCountOK()
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
      [TestMethod]
      public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.active = true;
            TestItem.CustomerID = 12;
            TestItem.FirstName = "Hello";
            TestItem.LastName = "come";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "90 yill road";
            TestItem.PostCode = "le6 4rt";
            TestItem.PhoneNumber = "7883383939";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.active = true;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Afseen";
            TestItem.LastName = "Asphak";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "12 Rose Street";
            TestItem.PostCode = "LE5 3RT";
            TestItem.PhoneNumber = "02345678912";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.active = true;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Afseen";
            TestItem.LastName = "Asphak";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "12 Rose Street";
            TestItem.PostCode = "LE5 3RT";
            TestItem.PhoneNumber = "02345678912";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.active = true;
            TestItem.FirstName = "Afseen";
            TestItem.LastName = "Asphak";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "12 Rose Road";
            TestItem.PostCode = "LE5 3RT";
            TestItem.PhoneNumber = "02345678912";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //delete the update
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the class containing unfiltered results 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomers.ReportByPostCode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a postcode that doesn't exist
            FilteredCustomers.ReportByPostCode("xxx xxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a postcode that doesn't exist
            FilteredCustomers.ReportByPostCode("LE4 0PP");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 4
                if (FilteredCustomers.CustomerList[0].CustomerID != 4) 
                {
                    OK = false;
                }
                //check that the first record is ID 5
                if (FilteredCustomers.CustomerList[1].CustomerID!= 5)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
