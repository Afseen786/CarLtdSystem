using CarLtdClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarLtdTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff(); //An instance of the class to be created
            Assert.IsNotNull(AStaff); //Test to see that it exists
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsStaff AStaff = new clsStaff(); //Instance of the class to be created
            Boolean TestData = true; //Create test data to assign to the property
            AStaff.Active = TestData; //Assign data 
            Assert.AreEqual(AStaff.Active, TestData); //Test to see the two values are equal
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsStaff AStaff = new clsStaff(); //Instance of class to be created
            DateTime TestData = DateTime.Now.Date; //Create test data to assign to the property
            AStaff.DateAdded = TestData; //Assign data
            Assert.AreEqual(AStaff.DateAdded, TestData); //Test to see the two values are equal
        }

        [TestMethod]

        public void DepartmentPropertyOK()
        {
            clsStaff AStaff = new clsStaff(); //Instance of class to be created
            string TestData = "Order"; //Create test data to assign to the property
            AStaff.Department = TestData; //Assign data
            Assert.AreEqual(AStaff.Department, TestData); //Test that the two values are equal
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            clsStaff AStaff = new clsStaff(); //Instance of class to be created
            string TestData = "Serena"; //Create test data to assign to the property
            AStaff.FirstName = TestData; //Assign data
            Assert.AreEqual(AStaff.FirstName, TestData); //Test that the two values are equal
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            clsStaff AStaff = new clsStaff(); //Instance of class to be created
            string TestData = "Williams"; //Create test data to assign to the property
            AStaff.LastName = TestData; //Assign data
            Assert.AreEqual(AStaff.LastName, TestData); //Test that the two values are equal
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            clsStaff AStaff = new clsStaff(); //Instance of class to be created
            string TestData = "07762 458 902"; //Create test data to assign to the property
            AStaff.PhoneNo = TestData; //Assign data
            Assert.AreEqual(AStaff.PhoneNo, TestData); //Test that the two values are equal
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsStaff AStaff = new clsStaff(); //Instance of class to be created
            Int32 TestData = 1; //Create test data to assign to the property
            AStaff.StaffID = TestData; //Assign data
            Assert.AreEqual(AStaff.StaffID, TestData); //Test that the two values are equal
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff(); //Instance of class to be created
            Boolean Found = false; //Stores the results from validation
            Int32 StaffID = 4; //Test data to be assigned to property
            Found = AStaff.Find(StaffID); //Invoke method
            Assert.IsTrue(Found); //Test result to see if true
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff AStaff = new clsStaff(); //Instance of class to be created
            Boolean Found = false; //Variable used to store result
            Boolean OK = true; //Records if data is OK
            Int32 StaffID = 4; //Test data assigned to property
            Found = AStaff.Find(StaffID); //Invoke method
            if (AStaff.StaffID != 4) //Check Staff ID
            {
                OK = false;
            }
            Assert.IsTrue(OK); //Test result is correct
        }

        [TestMethod]
         public void TestFirstNameFound()
        {
            clsStaff AStaff = new clsStaff(); //Instance of class to be created
            Boolean Found = false; //Variable used to store result
            Boolean OK = true; //Records if data is OK
            Int32 StaffID = 4; //Test data assigned to property
            Found = AStaff.Find(StaffID); //Invoke method
            if (AStaff.FirstName != "Test First") //Checks the property
            {
                OK = false;
            }
            Assert.IsTrue(OK); //Tests result is correct
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            clsStaff AStaff = new clsStaff(); //Instance of class to be created
            Boolean Found = false; //Variable used to store result
            Boolean OK = true; //Records if data is OK
            Int32 StaffID = 4; //Test data assigned to property
            Found = AStaff.Find(StaffID); //Invoke method
            if (AStaff.LastName != "Test Last") //Checks the property
            {
                OK = false;
            }
            Assert.IsTrue(OK); //Tests result is correct
        }

        [TestMethod]
        public void TestDepartmentFound()
        {
            clsStaff AStaff = new clsStaff(); //Instance of class to be created
            Boolean Found = false; //Variable used to store result
            Boolean OK = true; //Records if data is OK
            Int32 StaffID = 4; //Test data assigned to property
            Found = AStaff.Find(StaffID); //Invoke method
            if (AStaff.Department != "Test Department") //Checks the property
            {
                OK = false;
            }
            Assert.IsTrue(OK); //Tests result is correct
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            clsStaff AStaff = new clsStaff(); //Instance of class to be created
            Boolean Found = false; //Variable used to store result
            Boolean OK = true; //Records if data is OK
            Int32 StaffID = 4; //Test data assigned to property
            Found = AStaff.Find(StaffID); //Invoke method
            if (AStaff.PhoneNo != "XXXXX XXX XXX") //Checks the property
            {
                OK = false;
            }
            Assert.IsTrue(OK); //Tests result is correct
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsStaff AStaff = new clsStaff(); //Instance of class to be created
            Boolean Found = false; //Variable used to store result
            Boolean OK = true; //Records if data is OK
            Int32 StaffID = 4; //Test data assigned to property
            Found = AStaff.Find(StaffID); //Invoke method
            if (AStaff.DateAdded !=Convert.ToDateTime("20/01/2020")) //Checks the property
            {
                OK = false;
            }
            Assert.IsTrue(OK); //Tests result is correct
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsStaff AStaff = new clsStaff(); //Instance of class to be created
            Boolean Found = false; //Variable used to store result
            Boolean OK = true; //Records if data is OK
            Int32 StaffID = 4; //Test data assigned to property
            Found = AStaff.Find(StaffID); //Invoke method
            if (AStaff.Active != true) //Checks the property
            {
                OK = false;
            }
            Assert.IsTrue(OK); //Tests result is correct
        }
    }
}
