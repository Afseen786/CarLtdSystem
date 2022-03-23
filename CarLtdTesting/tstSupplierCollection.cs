using System;
using CarLtdClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace CarLtdTesting
{
    [TestClass]
    class tstSupplierCollection
    {
        [TestMethod]
        public void AddressListOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set the properties
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "test name";
            TestItem.SupplierEmail = "test address";
            TestItem.SupplierAddress = "test address";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSuppliers.SupplierList = TestList;
            //test to see that two value are the same
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);


        }

        [TestMethod]
        public void CountPropertyOK()
        {

            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllSuppliers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, SomeCount);
        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            clsSupplier TestSupplier = new clsSupplier();
            //set the properties of the test object
            TestSupplier.SupplierName = "test names";
            TestSupplier.SupplierId = 1;
            TestSupplier.SupplierEmail = "emailtest@gmail.com";
            TestSupplier.SupplierAddress = "address";
            //assign the data to the property
            AllSuppliers.ThisSupplier = TestSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            List<clsSupplier> TestList = new List<clsSupplier>();
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //set the properties of the test object
            TestItem.SupplierName = "test names";
            TestItem.SupplierId = 1;
            TestItem.SupplierEmail = "emailtest@gmail.com";
            TestItem.SupplierAddress = "address";
            //assign the data to the property
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }
    }
}
