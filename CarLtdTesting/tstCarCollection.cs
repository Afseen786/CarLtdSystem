using CarLtdClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CarLtdTesting
{
    [TestClass]
    public class tstCarCollection
    {
        [TestMethod]
        public void instanceOK()
        {
            //create an instance of the class we want to create 
            clsCarCollection AllCars = new clsCarCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCars);
        }
        [TestMethod]
        public void ThisCarPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property 
            clsCar TestCar = new clsCar();
            //set this properties of the test object
           
            TestCar.ID = 1;
            TestCar.VehicleNo = "01";
            TestCar.Model = "Volvo XC40";
            
            TestCar.EngineType = "Petrol";
            TestCar.EngineCC = "1000CC";
            TestCar.Color = "White";
            //assign the data to the property
            AllCars.ThisCar = TestCar;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCars.ThisCar, TestCar);
        }
        [TestMethod]
        public void CarListOk()
        {
            //create an instance of the class we want to create 
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsCar> TestList = new List<clsCar>();
            //add an item to the list
            //create the item of test data
            clsCar TestItem = new clsCar();
            //set this properties 
            
            TestItem.ID = 1;
            TestItem.VehicleNo = "01";
            TestItem.Model = "Volvo XC40";
            
            TestItem.EngineType = "Petrol";
            TestItem.EngineCC = "1000CC";
            TestItem.Color = "White";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCars.CarList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCars.CarList, TestList);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsCar> TestList = new List<clsCar>();
            //add an item to the list
            //create the item of test data
            clsCar TestItem = new clsCar();
            //set this properties 
           
            TestItem.ID = 1;
            TestItem.VehicleNo = "01";
            TestItem.Model = "Volvo XC40";
           
            TestItem.EngineType = "Petrol";
            TestItem.EngineCC = "1000CC";
            TestItem.Color = "White";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCars.CarList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCars.Count, TestList.Count);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            
            TestItem.ID = 12;
            TestItem.VehicleNo = "08";
            TestItem.Model = "SUV 4321";
            
            TestItem.EngineType = "Diesel";
            TestItem.EngineCC = "1200 CC";
            TestItem.Color = "Black";
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.ID = PrimaryKey;
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //delete the record
            AllCars.Delete();
            //now find the record
            Boolean Found = AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
           
            TestItem.ID = 1;
            TestItem.VehicleNo = "01";
            TestItem.Model = "Volvo XC40";
           
            TestItem.EngineType = "Petrol";
            TestItem.EngineCC = "1000CC";
            TestItem.Color = "White";
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.ID = PrimaryKey;
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            
            TestItem.ID = 1;
            TestItem.VehicleNo = "01";
            TestItem.Model = "Volvo XC40";
          
            TestItem.EngineType = "Petrol";
            TestItem.EngineCC = "1000CC";
            TestItem.Color = "White";
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.ID = PrimaryKey;
            //modify the test data
           
            TestItem.VehicleNo = "01";
            TestItem.Model = "Volvo XC40";
            
            TestItem.EngineType = "Petrol";
            TestItem.EngineCC = "1000CC";
            TestItem.Color = "White";
            //set the record based on the new test data
            AllCars.ThisCar = TestItem;
            //delete the update
            AllCars.Update();
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }


        [TestMethod]
        public void ReportByEngineCCMethodOK()
        {
            //create an instance of the class containing unfiltered results 
            clsCarCollection AllCars = new clsCarCollection();
            //create an instance of the filtered data
            clsCarCollection FilteredCars = new clsCarCollection();
            //apply a blank string (should return all records);
            FilteredCars.ReportByEngineCC("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.Count, FilteredCars.Count);
        }
        [TestMethod]
        public void ReportByEngineCCNoneFound()
        {
            //create an instance of the filtered data
            clsCarCollection FilteredCars = new clsCarCollection();
            //apply a EngineCC that doesn't exist
            FilteredCars.ReportByEngineCC("xxx xxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCars.Count);
        }
        [TestMethod]
        
    }
}
