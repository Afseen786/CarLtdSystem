using CarLtdClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder Order = new clsOrder();
        //get the data from the session object
        Order = (clsOrder)Session["AnOrder"];
        //display the order number for this entry
        Response.Write(Order.OrderNo);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsOrder
        clsOrder Order = new clsOrder();
        //capture the Order no
        Order.OrderNo = int.Parse(txtOrderNo.Text);
        //store the order in the session object
        Session["Order"] = Order;
        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }
}