﻿using CarLtdClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarLtdTesting
{
    [TestClass]
    public class tstCustomer
    {
        //good test data 
        //create some test data to pass to the method 
        string FirstName = "Sunny";
        string LastName = "Sub";
        string DateOfBirth = DateTime.Now.Date.ToString();
        string Address = "98 Moat Road";
        string PostCode = "LE3 0TY";
        string PhoneNumber = "01245674748";
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
        Int32 TestData = 3;
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
        string TestData = "Sunny";
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
        string TestData = "Sub";
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
        string TestData = "98 Moat Road";
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
        string TestData = "LE3 0TY";
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
        string TestData = "01245674748";
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
            Int32 CustomerID = 3;
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
        Int32 CustomerID = 3;
        //invoke the method
        Found = ACustomer.Find(CustomerID);
        //check the customer id
        if (ACustomer.CustomerID != 3)
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
        Int32 CustomerID = 3;
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
        Int32 CustomerID = 3;
        //invoke the method
        Found = ACustomer.Find(CustomerID);
        //check the property
        if (ACustomer.FirstName != "Sunny")
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
        Int32 CustomerID = 3;
        //invoke the method
        Found = ACustomer.Find(CustomerID);
        //check the property
        if (ACustomer.PhoneNumber != "01245674748")
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
            Int32 CustomerID = 3;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.PostCode != "LE3 0TY")
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
        Int32 CustomerID = 3;
        //invoke the method
        Found = ACustomer.Find(CustomerID);
        //check the property
        if (ACustomer.LastName != "Sub")
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
        Int32 CustomerID = 3;
        //invoke the method
        Found = ACustomer.Find(CustomerID);
        //check the property
        if (ACustomer.Address != "98 Moat Road")
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
        Int32 CustomerID = 3;
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
        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address,  PostCode, PhoneNumber);
            //Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FirstName = ""; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FirstName = "a"; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FirstName = "aa"; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FirstName = "aaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FirstName = "aaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
           //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FirstName = "aaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FirstName = "aaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FirstName = "";
            FirstName = FirstName.PadRight(150, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string LastName = ""; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string LastName = "b"; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string LastName = "bb"; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void lastNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string LastName = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbb"; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string LastName = "bbbbbbbbbbbbbbbbbbbb"; //this should trigger an error
           //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string LastName = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbb"; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FirstName = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbb"; //this should fail
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string LastName = "";
            LastName = LastName.PadRight(300, 'b');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime TestDate;
            //set the adte totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime TestDate;
            //set the adte totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime TestDate;
            //set the adte totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime TestDate;
            //set the adte totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //string the dateofbirth to a non date value 
            string DateOfBirth = "this is not a date!";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address = ""; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address = "c"; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address = "cc"; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            Address = Address.PadRight(34, 'c');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address = "";
            Address = Address.PadRight(30, 'c');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address = "";
            Address = Address.PadRight(35, 'c');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address = ""; //this should fail
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address = "";
            Address = Address.PadRight(200, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = "a";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

            [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = "aa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = "aaaaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = "aaaaaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = "aaaaaaaa";
            //PostCode = PostCode.PadRight(8, 'c');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = "aaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = "";
            PostCode = PostCode.PadRight(100, '1');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PhoneNumber = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PhoneNumber = "1";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PhoneNumber = "11";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PhoneNumber = "11111111";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PhoneNumber = "11111111111";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PhoneNumber = "111111111111";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PhoneNumber = "11111";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(50, '1');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
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
            //set thisCustomer to the test data 
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same 
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
            TestItem.CustomerID = 11;
            TestItem.FirstName = "Yaz";
            TestItem.LastName = "John";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "49 Miss Road ";
            TestItem.PostCode = "LE6 8TY";
            TestItem.PhoneNumber = "44556677777";
            //set thisCustomer to the test data 
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data 
            TestItem.active = true;
            TestItem.CustomerID = 11;
            TestItem.FirstName = "Yaz";
            TestItem.LastName = "John";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "49 Miss Road ";
            TestItem.PostCode = "LE6 8TY";
            TestItem.PhoneNumber = "44556677777";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
    }
}
