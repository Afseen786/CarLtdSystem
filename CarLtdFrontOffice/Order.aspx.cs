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

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the Order no
        AnOrder.OrderNo = txtOrderNo.Text;
        //store the order in the session object
        Session["Order"] = AnOrder;
        //redirect to the viewer page
        Response.Redirect["OrderViewer.aspx"];
    }
}