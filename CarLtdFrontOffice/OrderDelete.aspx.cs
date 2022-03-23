using CarLtdClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderNo;
    
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be deleted from the session object
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
    }

    void DeleteOrder()
    {
        //function to delete the selected record

        //create a new instance of the order book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to delete
        OrderBook.ThisOrder.Find(OrderNo);
        //delete the record
        OrderBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteOrder();
        //redirect back to the main page
        Response.Redirect("Default.aspx");
    }

}