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
        if (IsPostBack == false)
        {
            //display the data for this customer
            DisplayCustomer();
            //display the list of customers
            lblError.Text = DisplayCustomers("") + "records in the database";
        }
    }
    void DisplayCustomer()
    {

        //create an instance of the customer collection
        CarLtdClasses.clsCustomerCollection Customers = new CarLtdClasses.clsCustomerCollection();
        //set the data source to the list of customers in the collection
        lstCustomers.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomers.DataValueField = "CustomerID";
        //set the data field to display
        lstCustomers.DataTextField = "FirstName";
        //set the data field to display
        lstCustomers.DataTextField = "Address";
        //se the data field to display
        lstCustomers.DataTextField = "PostCode";
        //bind the data to the list
        lstCustomers.DataBind();
    }
    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data Acustomer page 
        Response.Redirect("ACustomer.aspx"); 
    }
    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the customer delete page 
            Response.Redirect("CustomerDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from list";
        }
    }
    //event handler for the edit button 
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
           Session["CustomerID"] = CustomerID;
            //redirect to the Acustomer page 
            Response.Redirect("ACustomer.aspx"); 
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from list";
        }
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayCustomers("");
        //display the number of records found
        lblError.Text = RecordCount + " records in the database";
        //clear the post code filter text box
        txtPostCode.Text = "";
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declare var to store the record count 
        Int32 RecordCount;
        //assign the results of the DisplayCustomerss function to the record count var
        RecordCount = DisplayCustomers(txtPostCode.Text);
        //display the number of record found 
        lblError.Text = RecordCount + "records found";
    }
   // function use to populate the list box
    Int32 DisplayCustomers(string PostCodeFilter)
    {
        //declare the varibales 
        Int32 CustomerID;
        string FirstName;
        string Address;
        string PostCode;

        //create a new instance of the clsAddress
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ReportByPostCode(PostCodeFilter);
        //var to store the count of records
        Int32 RecordCount;
        Int32 Index = 0;
        RecordCount = CustomerBook.Count; //get the count of records from the tblcustomer table
        lstCustomers.Items.Clear();
        while (Index < RecordCount) //while there are records to process
        {
            CustomerID = CustomerBook.CustomerList[Index].CustomerID; // get the customer id 
            FirstName = CustomerBook.CustomerList[Index].FirstName; //get the firstname
            Address = CustomerBook.CustomerList[Index].Address; //get the address
            PostCode = CustomerBook.CustomerList[Index].PostCode; //get the postcode

            //create the new enetry for the list box
            ListItem NewEntry = new ListItem(FirstName + " " + Address +" " + PostCode,CustomerID.ToString());
            lstCustomers.Items.Add(NewEntry); //add customer to the list
            Index++; //move the index to the next record
        }
        return RecordCount; //return the count of records found 
    }
    protected void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}