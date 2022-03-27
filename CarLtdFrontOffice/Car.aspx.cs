using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarLtdClasses;

public partial class Car : System.Web.UI.Page
{
    Int32 ID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the Car id from the session object 
        ID = Convert.ToInt32(Session["ID"]);
        
                DisplayCars();
      
    }
    void DisplayCars()
    {
        //create an instance of the Car book
        clsCarCollection CarBook = new clsCarCollection();
        //find the record to update 
        CarBook.ThisCar.Find(ID);
        //display the VehicleNo 
        txt_VehicleNo.Text = CarBook.ThisCar.VehicleNo;
        //display the Model
        txt_Model.Text = CarBook.ThisCar.Model;
        
        //display the EngineType
        txt_EngineType.Text = CarBook.ThisCar.EngineType;
        //display the EngineCC
        txt_EngineCC.Text = CarBook.ThisCar.EngineCC;
        //display the Color
        txt_Color.Text = CarBook.ThisCar.Color;
       
    }

    //event handler for the add button
    protected void btn_add_Click(object sender, EventArgs e)
    {
        if (ID == -1)
        {
            //add the new record 
            Add();
            //redirect back to the default page 
            //Response.Redirect("CarDefault.aspx");
        }
        else
        {
            //update the record
            Update();
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Car class
        clsCar ACar = new clsCar();
        //variable to store the primary key
        Int32 ID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by user
        ID = Convert.ToInt32(txt_ID.Text);
        //find the record
        Found = ACar.Find(ID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txt_VehicleNo.Text = ACar.VehicleNo;
            txt_Model.Text = ACar.Model;
            
            txt_EngineType.Text = ACar.EngineType;
            txt_EngineCC.Text = ACar.EngineCC;
            txt_Color.Text = ACar.Color;

        }
    }
    //function for adding new records
    void Add()
    {
        //create an instance of this Car book
        CarLtdClasses.clsCarCollection CarBook = new CarLtdClasses.clsCarCollection();
        //validate the data on the web form
        string Error = CarBook.ThisCar.Valid(txt_VehicleNo.Text, txt_Model.Text, txt_EngineType.Text, txt_EngineCC.Text, txt_Color.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            CarBook.ThisCar.VehicleNo = txt_VehicleNo.Text;
            CarBook.ThisCar.Model = txt_Model.Text;
            
            CarBook.ThisCar.EngineType = txt_EngineType.Text;
            CarBook.ThisCar.EngineCC = txt_EngineCC.Text;
            CarBook.ThisCar.Color = txt_Color.Text;
           
            //add the record 
            CarBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("CarDefault.aspx");
        }
        else
        {
            //report an error 
            lbl_Error.Text = "There were problems with the data entered" + Error;
        }
    }
    //function for updating records
    void Update()
    {
        //create an instance of the Car book
        CarLtdClasses.clsCarCollection CarBook = new CarLtdClasses.clsCarCollection();
        //validate the data on the web form
        string Error = CarBook.ThisCar.Valid(txt_VehicleNo.Text, txt_Model.Text, txt_EngineType.Text, txt_EngineCC.Text, txt_Color.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update 
            CarBook.ThisCar.Find(ID);
            //get the data entered by the user
            CarBook.ThisCar.VehicleNo = txt_VehicleNo.Text;
            CarBook.ThisCar.Model = txt_Model.Text;

            CarBook.ThisCar.EngineType = txt_EngineType.Text;
            CarBook.ThisCar.EngineCC = txt_EngineCC.Text;
            CarBook.ThisCar.Color = txt_Color.Text;

            //add the record 
            CarBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("CarDefault.aspx");
        }
        else
        {
            //report an error 
            lbl_Error.Text = "There were problems with the data entered" + Error;
        }
    }

    
}
}