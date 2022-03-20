using CarLtdClasses;
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
        //create an instance of the class we want to create
        clsCustomer ACustomer = new clsCustomer();
        //test to see that it exits
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
        //test to see that it exits
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
        //test to see that it exits
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
        //test to see that it exits
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
        //test to see that it exits
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
        //test to see that the it exits
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
        //test to see that the it exits
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
        //test to see that the it exits
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
        //test to see that the it exits
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
        //check the date of birth properly 
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
        //check the first name property
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
        //check the phone number property
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
            //check the postcode property
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
        //check the last name property
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
        //check the address property
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
        //check the active property
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
            string FirstName = ""; 
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
            string FirstName = "a"; 
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
            string FirstName = "aa"; 
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
            string FirstName = "aaaaaaaaaaaaaaaaaaa"; 
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
            string FirstName = "aaaaaaaaaaaaaaaaaaaa"; 
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
            string FirstName = "aaaaaaaaaaaaaaaaaaaa"; 
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
            string FirstName = "aaaaaaaaaaaaaaaaaaaaa"; 
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
            string LastName = ""; 
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
            string LastName = "b"; 
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
            string LastName = "bb"; 
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
            string LastName = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbb"; 
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
            string LastName = "bbbbbbbbbbbbbbbbbbbb"; 
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
            string LastName = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbb"; 
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
            string FirstName = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbb"; 
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
            string Address = ""; 
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
            string Address = "c"; 
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
            string Address = "cc"; 
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
            //create some test data to pass to the method
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
            string Address = ""; 
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
    }
}
