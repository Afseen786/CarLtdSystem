using CarLtdClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of clsOrder
        clsOrder Order = new clsOrder();
        //get the data from the session object
        Order = (clsOrder)Session["Order"];
        //display the Order no for this entry
        Response.Write(Order.OrderNo);
    }
}