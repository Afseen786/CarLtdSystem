using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLtdClasses
{
    public class clsCarCollection
    {
        //private data member for the list
        List<clsCar> mCarList = new List<clsCar>();
        //private data member thisCars
        clsCar mThisCar = new clsCar();
        //constructor for the class
        public clsCarCollection()
        {
            //object for data connection
            clsDataConnection DBConnection = new clsDataConnection();
            //execute the stored procedure 
            DBConnection.Execute("sproc_tblCar_SelectAll");
            //populate the array list with the data table
            PopulateArray(DBConnection);
        }


        //public property for the Car list
        public List<clsCar> CarList
        {
            get
            {
                //return the private data
                return mCarList;
            }
            set
            {
                //set the private data
                mCarList = value;
            }
        }

        //public property for count
        public Int32 Count
        {
            get
            {
                //return the count of the list
                return mCarList.Count;
            }
        }
        //public property for thisCar
        public clsCar ThisCar
        {
            get
            {
                //return the private data 
                return mThisCar;
            }
            set
            {
                //set the private data 
                mThisCar = value;
            }
        }
        public int Add()
        {
            //adds a new record to the database based on the values of mThisCar
            //connect to the database
            clsDataConnection DBConnection = new clsDataConnection();
            //set the parameters for the stored procedure 
            DBConnection.AddParameter("@VehicleNo", mThisCar.VehicleNo);
            DBConnection.AddParameter("@Model", mThisCar.Model);
            DBConnection.AddParameter("@EngineType", mThisCar.EngineType);
            DBConnection.AddParameter("@EngineCC", mThisCar.EngineCC);
            DBConnection.AddParameter("@Color", mThisCar.Color);
            
            //execute the query returning the primary key value
            return DBConnection.Execute("sproc_tblCar_Insert");

        }
        public void Delete()
        {
            //deletes the record pointed to by ThisCar
            //connect to the database
            clsDataConnection DBConnection = new clsDataConnection();
            //set the parameters for the stored procedure 
            DBConnection.AddParameter("@ID", mThisCar.ID);
            //execute the stored procedure 
            DBConnection.Execute("sproc_tblCar_Delete");
        }
        public void Update()
        {
            //adds a new record to the database based on the values of mThisCar
            //connect to the database
            clsDataConnection DBConnection = new clsDataConnection();
            //set the parameters for the stored procedure 
            DBConnection.AddParameter("@ID", mThisCar.ID);
            DBConnection.AddParameter("@VehicleNo", mThisCar.VehicleNo);
            DBConnection.AddParameter("@Model", mThisCar.Model);
            DBConnection.AddParameter("@EngineType", mThisCar.EngineType);
            DBConnection.AddParameter("@EngineCC", mThisCar.EngineCC);
            DBConnection.AddParameter("@Color", mThisCar.Color);
            //execute the query returning the primary key value
            DBConnection.Execute("sproc_tblCar_Update");
        }

       
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCarList = new List<clsCar>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Car
                clsCar ACar = new clsCar();
                //read in the fields from the current record
                ACar.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["ID"]);
            
                ACar.VehicleNo = Convert.ToString(DB.DataTable.Rows[Index]["VehicleNo"]);
                ACar.Model = Convert.ToString(DB.DataTable.Rows[Index]["Model"]);
                ACar.EngineType = Convert.ToString(DB.DataTable.Rows[Index]["EngineType"]);
                ACar.EngineCC = Convert.ToString(DB.DataTable.Rows[Index]["EngineCC"]);
                ACar.Color = Convert.ToString(DB.DataTable.Rows[Index]["Color"]);
                
                //add the record to the private data member
                mCarList.Add(ACar);
                //point at the next record
                Index++;
            }
        }
    }
}
}
