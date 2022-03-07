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
    }
}
