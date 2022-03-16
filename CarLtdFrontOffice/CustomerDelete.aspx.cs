using CarLtdClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted 
    Int32 CustomerID;

    //event handler for the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    void DeleteCustomer()
    {
        //function to delete the selected record

        //create a new instance of teh customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to delete 
        CustomerBook.ThisCustomer.Find(CustomerID);
        //delete the record
        CustomerBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteCustomer();
        //redirect back to the default page
        Response.Redirect("CustomerDefault.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //this line of code redirect back to the customer default page
        Response.Redirect("CustomerDefault.aspx");
    }
}