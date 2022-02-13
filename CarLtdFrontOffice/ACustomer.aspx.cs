using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarLtdClasses;

public partial class ACustomer : System.Web.UI.Page
{

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clscustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the first name 
        ACustomer.FirstName = txtFirstName.Text;
        //store the customer in the session object
        Session["ACustomer"] = ACustomer;
        //redirect to the viewer page 
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = ACustomer.FirstName;
            txtLastName.Text = ACustomer.LastName;
            txtDateOfBirth.Text = ACustomer.DateOfBirth.ToString();
            txtAddress.Text = ACustomer.Address;
            txtPostCode.Text = ACustomer.PostCode;
            txtPhoneNumber.Text = ACustomer.PhoneNumber;

        }
    }
}