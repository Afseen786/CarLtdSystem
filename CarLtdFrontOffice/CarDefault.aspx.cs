using CarLtdClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //clear any exisiting error message 
        lblError.Text = "";
        //if this is the first apperance of this form
       
            //display the data for this Car
            DisplayCar();
            //display the list of Cars
            lbl_Error.Text = DisplayCars("") + "records in the database";
        
    }
    void DisplayCar()
    {

        //create an instance of the Car collection
        CarLtdClasses.clsCarCollection Cars = new CarLtdClasses.clsCarCollection();
        //set the data source to the list of Cars in the collection
        lstCars.DataSource = Cars.CarList;
        //set the name of the primary key
        lstCars.DataValueField = "ID";
        //set the data field to display
        lstCars.DataTextField = "VehicleNo";
        //set the data field to display
        lstCars.DataTextField = "Model";
        //se the data field to display
        lstCars.DataTextField = "Color";
        //bind the data to the list
        lstCars.DataBind();
    }
    //event handler for the add button
    protected void btn_add_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ID"] = -1;
        //redirect to the data Car page 
        Response.Redirect("Car.aspx");
    }
    //event handler for the delete button
    protected void btn_delete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 ID;
        //if a record has been selected from the list
        if (lstCars.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            ID = Convert.ToInt32(lstCars.SelectedValue);
            //store the data in the session object
          
            //redirect to the Car delete page 
            Response.Redirect("CarDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lbl_Error.Text = "Please select a record to delete from list";
        }
    }
    //event handler for the edit button 
    protected void btn_update_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 ID;
        //if a record has been selected from the list
        if (lstCars.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            ID = Convert.ToInt32(lstCars.SelectedValue);
            //store the data in the session object
            
            //redirect to the Car page 
            Response.Redirect("Car.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lbl_Error.Text = "Please select a record to update from list";
        }
    }

 
   
    // function use to populate the list box
    Int32 DisplayCars(string PostCodeFilter)
    {
        //declare the varibales 
        string ID;
        string VehicleNo;
        string Model;
        string Color;

        //create a new instance of the clsAddress
        clsCarCollection CarBook = new clsCarCollection();
        
        //var to store the count of records
        Int32 RecordCount;
        Int32 Index = 0;
        RecordCount = CarBook.Count; //get the count of records from the tblCar table
        lstCars.Items.Clear();
        while (Index < RecordCount) //while there are records to process
        {
            ID = CarBook.CarList[Index].ID; // get the  id 
            VehicleNo = CarBook.CarList[Index].VehicleNo; //get the VehicleNo
            Model = CarBook.CarList[Index].Model; //get the Model
            Color = CarBook.CarList[Index].Color; //get the Color

            //create the new enetry for the list box
            ListItem NewEntry = new ListItem(VehicleNo + " " + Model + " " + Color, ID.ToString());
            lstCars.Items.Add(NewEntry); //add Car to the list
            Index++; //move the index to the next record
        }
        return RecordCount; //return the count of records found 
    }
    protected void lstCars_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}