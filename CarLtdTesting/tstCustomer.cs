using CarLtdClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarLtdTesting
{
    [TestClass]
    public class tstCustomer
    { 
   [TestMethod]

    public void InstanceOK()
    {
        //create an instance of the class we want to createe
        clsCustomer ACustomer = new clsCustomer();
        //test to see that it exists
        Assert.IsNotNull(ACustomer);
    }
    [TestMethod]

    public void ActivePropertyOK()
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //create some test data to assign to the property
        Boolean TestData = true;
        //assign the data to the property
        ACustomer.active = TestData;
        //test to see that it exists
        Assert.AreEqual(ACustomer.active, TestData);
    }
        [TestMethod]
    public void DateOfBirthOK()
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //create some test data to assign to the property
        DateTime TestData = DateTime.Now.Date;
        //assign the data to the property
        ACustomer.DateOfBirth = TestData;
        //test to see that it exists
        Assert.AreEqual(ACustomer.DateOfBirth, TestData);
    }
    [TestMethod]
    public void CustomerIDOK()
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //create some test data to assign to the property
        Int32 TestData = 2;
        //assign the data to the property
        ACustomer.CustomerID = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(ACustomer.CustomerID, TestData);
    }

    [TestMethod]
    public void FirstNameOK()
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //create some test data to assign to the property
        string TestData = "Aisha";
        //assign the data to the property
        ACustomer.FirstName = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(ACustomer.FirstName, TestData);
    }

    [TestMethod]
    public void LastNameOK()
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //create some test data to assign to the property
        string TestData = "Patel";
        //assign the data to the property
        ACustomer.LastName = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(ACustomer.LastName, TestData);
    }
    [TestMethod]
    public void AddressOK()
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //create some test data to assign to the property
        string TestData = "31 silver street";
        //assign the data to the property
        ACustomer.Address = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(ACustomer.Address, TestData);
    }

    [TestMethod]
    public void PostCodeOK()
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //create some test data to assign to the property
        string TestData = "le7 2oi";
        //assign the data to the property
        ACustomer.PostCode = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(ACustomer.PostCode, TestData);
    }

    [TestMethod]
    public void PhoneNumberOK()
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //create some test data to assign to the property
        string TestData = "01167543271";
        //assign the data to the property
        ACustomer.PhoneNumber = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(ACustomer.PhoneNumber, TestData);
    }
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

    [TestMethod]
    public void TestCustomerIDFound()
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //boolean variable to store the results of the validation
        Boolean Found = true;
        //boolean variable to record if data is ok (assume it is)
        Boolean OK = true;
        //create some test data to use with the method
        Int32 CustomerID = 2;
        //invoke the method
        Found = ACustomer.Find(CustomerID);
        //check the customer id
        if (ACustomer.CustomerID != 2)
        {
            OK = true;
        }
        //test to see if the result is true
        Assert.IsTrue(OK);
    }

    [TestMethod]

    public void TestDateOfBirthFound()
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //boolean variable to store the results of the validation
        Boolean Found = true;
        //boolean variable to record if data is ok (assume it is)
        Boolean OK = true;
        //create some tesr data to use with the method
        Int32 CustomerID = 2;
        //invoke the method
        Found = ACustomer.Find(CustomerID);
        //check the customer id
        if (ACustomer.DateOfBirth != Convert.ToDateTime("01/01/2021"))
        {
            OK = true;
        }
        //test to see if the result is true
        Assert.IsTrue(OK);
    }

    [TestMethod]

    public void TestFirstNameFound()
    {
       //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //boolean variable to store the result of the search
        Boolean Found = true;
        //boolean variable to record if data is OK (assume it is)
        Boolean OK = true;
        //create some test data to use with the method
        Int32 CustomerID = 2;
        //invoke the method
        Found = ACustomer.Find(CustomerID);
        //check the property
        if (ACustomer.FirstName != "Aisha")
        {
            OK = true;
        }
        //test to see that the result is correct
        Assert.IsTrue(OK);
    }
    [TestMethod]
    public void TestPhoneNumberFound()
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //boolean variable to store the result of the search
        Boolean Found = true;
        //boolean variable to record if data is OK (assume it is)
        Boolean OK = true;
        //create some test data to use with the method
        Int32 CustomerID = 2;
        //invoke the method
        Found = ACustomer.Find(CustomerID);
        //check the property
        if (ACustomer.PhoneNumber != "01167543271")
        {
            OK = true;
        }
        //test to see that the result is correct
        Assert.IsTrue(OK);
    }
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = true;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.PostCode != "le7 2oi ")
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
    public void TestLastNameFound()
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //boolean variable to store the result of the search
        Boolean Found = true;
        //boolean variable to record if data is OK (assume it is)
        Boolean OK = true;
        //create some test data to use with the method
        Int32 CustomerID = 2;
        //invoke the method
        Found = ACustomer.Find(CustomerID);
        //check the property
        if (ACustomer.LastName != "Patel")
        {
            OK = true;
        }
        //test to see that the result is correct
        Assert.IsTrue(OK);
    }
    [TestMethod]

    public void TestAddressFound()
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //boolean variable to store the result of the search
        Boolean Found = true;
        //boolean variable to record if data is OK (assume it is)
        Boolean OK = true;
        //create some test data to use with the method
        Int32 CustomerID = 2;
        //invoke the method
        Found = ACustomer.Find(CustomerID);
        //check the property
        if (ACustomer.Address != "21 silver street")
        {
            OK = true;
        }
        //test to see that the result is correct
        Assert.IsTrue(OK);
    }
    [TestMethod]

    public void TestactiveFound()
    {
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //boolean variable to store the result of the search
        Boolean Found = true;
        //boolean variable to record if data is OK (assume it is)
        Boolean OK = true;
        //create some test data to use with the method
        Int32 CustomerID = 2;
        //invoke the method
        Found = ACustomer.Find(CustomerID);
        //check the property
        if (ACustomer.active != true)
        {
            OK = true;
        }
        //test to see that the result is correct
        Assert.IsTrue(OK);
    }
}
}
