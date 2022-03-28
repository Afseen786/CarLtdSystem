using CarLtdClasses;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLtdTesting
{
    class tstCar
    {
      //good test data 
            //create some test data to pass to the method 
            string VehicleNo = "01";
            string Model = "Volvo XC40";
            string EngineType = "petrol";
            string EngineCC = "1000CC";
            string Color = "White";
            
            [TestMethod]

          

          
   
            public void IDOK()
            {
                //create an instance of the class we want to create
                clsCar ACar = new clsCar();
                //create some test data to assign to the property
                Int32 TestData = 3;
                //assign the data to the property
                ACar.ID = TestData;
                //test to see that it exists
                Assert.AreEqual(ACar.ID, TestData);
            }

            [TestMethod]
            public void VehicleNoOK()
            {
                //create an instance of the class we want to create
                clsCar ACar = new clsCar();
                //create some test data to assign to the property
                string TestData = "01";
                //assign the data to the property
                ACar.VehicleNo = TestData;
                //test to see that it exists
                Assert.AreEqual(ACar.VehicleNo, TestData);
            }

            [TestMethod]
            public void ModelOK()
            {
                //create an instance of the class we want to create
                clsCar ACar = new clsCar();
                //create some test data to assign to the property
                string TestData = "Volvo XC40";
                //assign the data to the property
                ACar.Model = TestData;
                //test to see that the it exists
                Assert.AreEqual(ACar.Model, TestData);
            }
            [TestMethod]
            public void EngineTypeOK()
            {
                //create an instance of the class we want to create
                clsCar ACar = new clsCar();
                //create some test data to assign to the property
                string TestData = "Petrol";
                //assign the data to the property
                ACar.EngineType = TestData;
                //test to see that the it exists
                Assert.AreEqual(ACar.EngineType, TestData);
            }

            [TestMethod]
            public void EngineCCOK()
            {
                //create an instance of the class we want to create
                clsCar ACar = new clsCar();
                //create some test data to assign to the property
                string TestData = "1000CC";
                //assign the data to the property
                ACar.EngineCC = TestData;
                //test to see that the it exists
                Assert.AreEqual(ACar.EngineCC, TestData);
            }

            [TestMethod]
            public void ColorOK()
            {
                //create an instance of the class we want to create
                clsCar ACar = new clsCar();
                //create some test data to assign to the property
                string TestData = "White";
                //assign the data to the property
                ACar.Color = TestData;
                //test to see that the it exists
                Assert.AreEqual(ACar.Color, TestData);
            }
            public void FindMethodOK()
            {
                //create an instance of the class we want to create
                clsCar ACar = new clsCar();
                //boolean variable to store the result of the validation
                Boolean Found = true;
                //create some test data to use with the method
                Int32 CarID = 3;
                //invoke the method
                Found = ACar.Find(CarID);
                //test to see that the result is correct
                Assert.IsTrue(Found);
            }

            [TestMethod]
            public void TestCarIDFound()
            {
                //create an instance of the class we want to create
                clsCar ACar = new clsCar();
                //boolean variable to store the results of the validation
                Boolean Found = true;
                //boolean variable to record if data is ok (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CarID = 3;
                //invoke the method
                Found = ACar.Find(CarID);
                //check the Car id
                if (ACar.CarID != 3)
                {
                    OK = true;
                }
                //test to see if the result is true
                Assert.IsTrue(OK);
            }

            [TestMethod]

           

            public void TestVehicleNoFound()
            {
                //create an instance of the class we want to create
                clsCar ACar = new clsCar();
                //boolean variable to store the result of the search
                Boolean Found = true;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CarID = 3;
                //invoke the method
                Found = ACar.Find(CarID);
                //check the first name property
                if (ACar.VehicleNo != "01")
                {
                    OK = true;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestColorFound()
            {
                //create an instance of the class we want to create
                clsCar ACar = new clsCar();
                //boolean variable to store the result of the search
                Boolean Found = true;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CarID = 3;
                //invoke the method
                Found = ACar.Find(CarID);
                //check the phone number property
                if (ACar.Color != "White")
                {
                    OK = true;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestEngineCCFound()
            {
                //create an instance of the class we want to create
                clsCar ACar = new clsCar();
                //boolean variable to store the result of the search
                Boolean Found = true;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CarID = 3;
                //invoke the method
                Found = ACar.Find(CarID);
                //check the EngineCC property
                if (ACar.EngineCC != "1000CC")
                {
                    OK = true;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestModelFound()
            {
                //create an instance of the class we want to create
                clsCar ACar = new clsCar();
                //boolean variable to store the result of the search
                Boolean Found = true;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CarID = 3;
                //invoke the method
                Found = ACar.Find(CarID);
                //check the last name property
                if (ACar.Model != "Volvo XC40")
                {
                    OK = true;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }
            [TestMethod]

            public void TestEngineTypeFound()
            {
                //create an instance of the class we want to create
                clsCar ACar = new clsCar();
                //boolean variable to store the result of the search
                Boolean Found = true;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CarID = 3;
                //invoke the method
                Found = ACar.Find(CarID);
                //check the EngineType property
                if (ACar.EngineType != "Petrol")
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
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void VehicleNoMinLessOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string VehicleNo = "";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void VehicleNoMin()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string VehicleNo = "a";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void VehicleNoMinPlusOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string VehicleNo = "aa";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void VehicleNoMaxLessOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string VehicleNo = "aaaaaaaaaaaaaaaaaaa";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void VehicleNoMid()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string VehicleNo = "aaaaaaaaaaaaaaaaaaaa";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void VehicleNoMax()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string VehicleNo = "aaaaaaaaaaaaaaaaaaaa";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void VehicleNoMaxPlusOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string VehicleNo = "aaaaaaaaaaaaaaaaaaaaa";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void VehicleNoExtremeMax()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string VehicleNo = "";
                VehicleNo = VehicleNo.PadRight(150, 'a');
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void ModelMinLessOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Model = "";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void ModelMin()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Model = "b";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void ModelMinPlusOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Model = "bb";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void ModelMaxLessOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Model = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbb";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void ModelMid()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Model = "bbbbbbbbbbbbbbbbbbbb";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void ModelMax()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Model = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbb";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void ModelMaxPlusOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string VehicleNo = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbb";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void ModelExtremeMax()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Model = "";
                Model = Model.PadRight(300, 'b');
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            
            public void EngineTypeMinLessOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineType = "";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void EngineTypeMin()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineType = "c";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void EngineTypeMinPlusOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineType = "cc";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void EngineTypeMaxLessOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method
                EngineType = EngineType.PadRight(34, 'c');
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void EngineTypeMid()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineType = "";
                EngineType = EngineType.PadRight(30, 'c');
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void EngineTypeMax()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineType = "";
                EngineType = EngineType.PadRight(35, 'c');
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void EngineTypeMaxPlusOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineType = "";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void EngineTypeExtremeMax()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineType = "";
                EngineType = EngineType.PadRight(200, 'a');
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void EngineCCMinLessOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineCC = "";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void EngineCCMin()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineCC = "a";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void EngineCCMinPlusOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineCC = "aa";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void EngineCCMaxLessOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineCC = "aaaaaa";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void EngineCCMax()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineCC = "aaaaaaa";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void EngineCCMaxPlusOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineCC = "aaaaaaaa";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void EngineCCMid()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineCC = "aaaa";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void EngineCCExtremeMax()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string EngineCC = "";
                EngineCC = EngineCC.PadRight(100, '1');
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void ColorMinLessOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Color = "";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void ColorMin()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Color = "1";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void ColorMinPlusOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Color = "11";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void ColorMaxLessOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Color = "11111111";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void ColorMax()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Color = "11111111111";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void ColorMaxPlusOne()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Color = "111111111111";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void ColorMid()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Color = "11111";
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void ColorExtremeMax()
            {
                //create an instance of the class we want to create 
                clsCar ACar = new clsCar();
                //string variable to store any error message 
                String Error = "";
                //create some test data to pass to the method 
                string Color = "";
                Color = Color.PadRight(50, '1');
                //invoke the method 
                Error = ACar.Valid(VehicleNo, Model, EngineType, EngineCC, Color);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
        }
}
