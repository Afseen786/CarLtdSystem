using CarLtdClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace CarLtdTesting
{
    [TestClass]
    public class tstSupplier
    {

        [TestMethod]

        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]

        public void SupplierIdOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the propery
            AnSupplier.SupplierId = TestData;
            //test to see that it exists
            Assert.AreEqual(AnSupplier.SupplierId, TestData);
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
            string TestData = "Test Address";
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

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean Found = false;
            Int32 SupplierId = 21;
            //assign the data to the propery
            Found = AnSupplier.Find(SupplierId);
            //test to see that it exists
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestSupplierIdFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the supplier no
            if (AnSupplier.SupplierId != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestSupplierNameFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the supplier no
            if (AnSupplier.SupplierName != "Test Supplier")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestSupplierAddressFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the supplier no
            if (AnSupplier.SupplierAddress != "Test Address")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestSupplierEmailFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the supplier no
            if (AnSupplier.SupplierEmail != "SupplierTest@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        





    }


}
