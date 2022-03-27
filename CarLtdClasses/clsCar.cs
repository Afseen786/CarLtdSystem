using Class_Library;
using System;

namespace CarLtdClasses
{

    public class clsCar
    {
       
       
        //private data member for the Car ID property
        private Int32 mID;
        public int ID
        {
            get
            {
                //return the private data
                return mID;
            }
            set
            {
                //set the private data 
                mID = value;
            }
        }
        //private data member for the VehicleNo property
        private string mVehicleNo;
        public string VehicleNo
        {
            get
            {
                //return the private data
                return mVehicleNo;
            }
            set
            {
                //set the private data 
                mVehicleNo = value;
            }
        }
        //private data member for the Model property
        private string mModel;
        public string Model
        {
            get
            {
                //return the private data
                return mModel;
            }
            set
            {
                //set the private data 
                mModel = value;
            }
        }
        //private data member for the EngineType property
        private string mEngineType;
        public string EngineType
        {
            get
            {
                //return the private data
                return mEngineType;
            }
            set
            {
                //set the private data 
                mEngineType = value;
            }
        }
        //private data member for the EngineCC property
        private string mEngineCC;
        public string EngineCC
        {
            get
            {
                //return the private data
                return mEngineCC;
            }
            set
            {
                //set the private data 
                mEngineCC = value;
            }
        }
        //private data member for the Color property
        private string mColor;
        public string Color
        {
            get
            {
                //return the private data
                return mColor;
            }
            set
            {
                //set the private data 
                mColor = value;
            }
        }

        public bool Find(int ID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the id to search for
            DB.AddParameter("@ID", ID);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_FilterByID");
            //if one record is found ( there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["ID"]);
                mVehicleNo = Convert.ToString(DB.DataTable.Rows[0]["VehicleNo"]);
                mModel = Convert.ToString(DB.DataTable.Rows[0]["Model"]);
                mEngineType = Convert.ToString(DB.DataTable.Rows[0]["EngineType"]);
                mEngineCC = Convert.ToString(DB.DataTable.Rows[0]["EngineCC"]);
                mColor= Convert.ToString(DB.DataTable.Rows[0]["Color"]);
               
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string VehicleNo, string Model, string EngineType, string EngineCC, string Color)
        {
            //create a string varibale to store the error 
            String Error = "";

            //if the VehicleNo is blank
            if (VehicleNo.Length == 0)
            {
                //record the error
                Error = Error + "The VehicleNo should not be blank :";
            }
            //if the VehicleNo is greater than 21 characters 
            if (VehicleNo.Length > 20)
            {
                //record the error
                Error = Error + "The VehicleNo must be less than 20 characters :";
            }
            //if the Model  is blank
            if (Model.Length == 0)
            {
                //record the error
                Error = Error + "The Model should not be blank :";
            }
            //if the Model is greater than 31 characters 
            if (Model.Length > 30)
            {
                //record the error
                Error = Error + "The Model must be less than 30 characters :";
            }

            //if the EngineType  is blank
            if (EngineType.Length == 0)
            {
                //record the error
                Error = Error + "The EngineType should not be blank :";
            }
            //if the EngineType is greater than 36 characters 
            if (EngineType.Length > 35)
            {
                //record the error
                Error = Error + "The EngineType must be less than 35 characters :";
            }
            //if the EngineCC is blank 
            if (EngineCC.Length == 0)
            {
                //record the error 
                Error = Error + "The EngineCC may not be blank : ";
            }
            //if the EngineCC is too long 
            if (EngineCC.Length > 7)
            {
                //record the error 
                Error = Error + "The EngineCC must be less than 7 characters : ";
            }
            //if the Color is blank 
            if (Color.Length == 0)
            {
                //record the error 
                Error = Error + "The Color may not be blank : ";
            }
            //if the Color is too long 
            if (Color.Length > 11)
            {
                //record the error 
                Error = Error + "The Color must be less than 11 characters : ";
            }
            //return any error message 
            return Error;
        }
    }
}
