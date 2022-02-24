using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        //create an instance of the customer collection
        CarLtdClasses.clsCustomerCollection Customers = new CarLtdClasses.clsCustomerCollection();
        //set the data source to the list of customers in the collection
        lstCustomers.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomers.DataValueField = "CustomerID";
        //se the data field to display
        lstCustomers.DataTextField = "PostCode";
        //bind the data to the list
        lstCustomers.DataBind();
    }

    protected void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}