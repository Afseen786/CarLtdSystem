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
        string FirstName = txtFirstName.Text;
        //capture the first name 
        string LastName = txtLastName.Text;
        //capture the date of birth
        string DateOfBirth = txtDateOfBirth.Text;
        //capture the address 
        string Address = txtAddress.Text;
        //capture the postcode 
        string PostCode = txtPostCode.Text;
        //capture the phone number
        string PhoneNumber = txtPhoneNumber.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data 
        Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Address, PostCode, PhoneNumber);
        if (Error == "")
        {
            //capture the first name 
            ACustomer.FirstName = txtFirstName.Text;
            //capture the last name 
            ACustomer.LastName = txtLastName.Text;
            //capture the date of birth 
            ACustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            //capture the address 
            ACustomer.Address = txtAddress.Text;
            //capture the postcode
            ACustomer.PostCode = txtPostCode.Text;
            //capture the phone number
            ACustomer.PhoneNumber = txtPhoneNumber.Text;
            //store the customer in the session object
            Session["ACustomer"] = ACustomer;
            //redirect to the viewer page 
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display the error message 
            lblError.Text = Error;
        }
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