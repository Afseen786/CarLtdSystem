using CarLtdClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }
    void DisplayOrders()
    {
        //ceate an instance of the Order Collection
        CarLtdClasses.clsOrderCollection Orders = new CarLtdClasses.clsOrderCollection();
        //set the data source to the list of orders in the collection
        lstOrders.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrders.DataValueField = "OrderNo";
        //set the data field to display
        lstOrders.DataTextField = "BillingAddress";
        //bind the data to the list
        lstOrders.DataBind();
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indiciate this is a new record
        Session["OrderNo"] = -1;
        //add the new record
        //redirect to the data entry page
        Response.Redirect("Order.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderNo;
        //if a record has been selected from the list
        if (lstOrders.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderNo = Convert.ToInt32(lstOrders.SelectedValue);
            //store the data in the session object
            Session["OrderNo"] = OrderNo;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblText.Text = "Please select a record to delete from the list";
        }
    }
}