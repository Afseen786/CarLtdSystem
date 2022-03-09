using CarLtdClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace CarLtdTesting
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]

        public void ActiveSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the propery
            AnSupplier.Active = TestData;
            //test to see that it exists
            Assert.AreEqual(AnSupplier.Active, TestData);
        }

        [TestMethod]

        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]

        public void SupplierNoOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the propery
            AnSupplier.SupplierNo = TestData;
            //test to see that it exists
            Assert.AreEqual(AnSupplier.SupplierNo, TestData);
        }

        [TestMethod]

        public void SupplierNameOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "A Supplier";
            //assign the data to the propery
            AnSupplier.SupplierName = TestData;
            //test to see that it exists
            Assert.AreEqual(AnSupplier.SupplierName, TestData);
        }

        [TestMethod]

        public void SupplierAddressOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "21 County Road";
            //assign the data to the propery
            AnSupplier.SupplierAddress = TestData;
            //test to see that it exists
            Assert.AreEqual(AnSupplier.SupplierAddress, TestData);
        }

        [TestMethod]

        public void SupplierEmailOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "Supplier32@gmail.com";
            //assign the data to the propery
            AnSupplier.SupplierEmail = TestData;
            //test to see that it exists
            Assert.AreEqual(AnSupplier.SupplierEmail, TestData);
        }

    }


}
