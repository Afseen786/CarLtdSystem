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
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the order number for this entry
        Response.Write(AnOrder.OrderNo);
    }

    protected void btnFindOrders_Click(object sender, EventArgs e)
    {
        //create an instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        //OrderNo
        //capture the Order no
        AnOrder.OrderNo = Int32.Parse(txtOrderNo.Text);
        //store the order in the session object
        Session["AnOrder"] = AnOrder;
        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //OrderName
        //capture the Order name
        AnOrder.OrderName = txtOrderName.Text;
        //store the order in the session object
        Session["AnOrder"] = AnOrder;
        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //OrderStatus
        //capture the Order status
        AnOrder.OrderStatus = txtOrderStatus.Text;
        //store the order in the session object
        Session["AnOrder"] = AnOrder;
        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //OrderDate
        //capture the Order date
        AnOrder.OrderDate = DateTime.Parse(txtOrderDate.Text);
        //store the order in the session object
        Session["AnOrder"] = AnOrder;
        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //BillingAddress
        //capture the Billing address
        AnOrder.OrderStatus = txtBillingAddress.Text;
        //store the order in the session object
        Session["AnOrder"] = AnOrder;
        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //Active
        AnOrder.Active = Active.Checked;
        //store the order in the session object
        Session["AnOrder"] = AnOrder;
        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }
}