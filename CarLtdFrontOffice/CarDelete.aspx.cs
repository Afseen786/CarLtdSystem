using CarLtdClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CarDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted 
    Int32 ID;

    //event handler for the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        ID = Convert.ToInt32(Session["ID"]);
    }

    void DeleteCar()
    {
        //function to delete the selected record
        //create a new instance of the car book
        clsCarCollection carBook = new clsCarCollection();
        //find the record to delete 
        CarBook.ThisCar.Find(ID);
        //delete the record
        CustomerBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteCar();
        //redirect back to the customer default page
        Response.Redirect("CarDefault.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //this line of code redirect back to the customer default page
        Response.Redirect("CarDefault.aspx");
    }
}