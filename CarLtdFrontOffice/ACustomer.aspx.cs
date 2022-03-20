using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarLtdClasses;

public partial class ACustomer : System.Web.UI.Page
{
    //var to store the customer ID
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the customer id from the session object 
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {

            //if the customerID is not -1 then display the data from the record 
            if (CustomerID != -1)
            {
                //display the data for this customer
                DisplayCustomers();
            }
            else //this is a new record
            {
                //set the date to todays date 
                txtDateOfBirth.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
            }
        }
    }
    void DisplayCustomers()
    {
        //create an instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update 
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display the first name 
        txtFirstName.Text = CustomerBook.ThisCustomer.FirstName;
        //display the last name
        txtLastName.Text = CustomerBook.ThisCustomer.LastName;
        //display the Date of birth
        txtDateOfBirth.Text = CustomerBook.ThisCustomer.DateOfBirth.ToString("dd/MM/yyyy");
        //display the address
        txtAddress.Text = CustomerBook.ThisCustomer.Address;
        //display the postcode
        txtPostCode.Text = CustomerBook.ThisCustomer.PostCode;
        //display the phonenumber
        txtPhoneNumber.Text = CustomerBook.ThisCustomer.PhoneNumber;
        //display the active state 
        chkactive.Checked = CustomerBook.ThisCustomer.active;
    }

    //event handler for the OK button
    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (CustomerID == -1)
        {
            //add the new record 
            Add();
            //redirect back to the default page 
            //Response.Redirect("CustomerDefault.aspx");
        }
        else
        {
            //update the record
            Update();
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
        //function for adding new records
        void Add()
        {
        //create an instance of this customer book
        CarLtdClasses.clsCustomerCollection CustomerBook = new CarLtdClasses.clsCustomerCollection();
        //validate the data on the web form
        string Error = CustomerBook.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtDateOfBirth.Text, txtAddress.Text, txtPostCode.Text, txtPhoneNumber.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            CustomerBook.ThisCustomer.FirstName = txtFirstName.Text;
            CustomerBook.ThisCustomer.LastName = txtLastName.Text;
            CustomerBook.ThisCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            CustomerBook.ThisCustomer.Address = txtAddress.Text;
            CustomerBook.ThisCustomer.PostCode = txtPostCode.Text;
            CustomerBook.ThisCustomer.PhoneNumber = txtPhoneNumber.Text;
            CustomerBook.ThisCustomer.active = chkactive.Checked;
            //add the record 
            CustomerBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("CustomerDefault.aspx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problems with the data entered" + Error;
        }
     }
        //function for updating records
        void Update()
          {
        //create an instance of the customer book
         CarLtdClasses.clsCustomerCollection CustomerBook = new CarLtdClasses.clsCustomerCollection();
        //validate the data on the web form
            string Error = CustomerBook.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtDateOfBirth.Text, txtAddress.Text, txtPostCode.Text, txtPhoneNumber.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update 
            CustomerBook.ThisCustomer.Find(CustomerID);
            //get the data entered by the user
            CustomerBook.ThisCustomer.FirstName = txtFirstName.Text;
            CustomerBook.ThisCustomer.LastName = txtLastName.Text;
            CustomerBook.ThisCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            CustomerBook.ThisCustomer.Address = txtAddress.Text;
            CustomerBook.ThisCustomer.PostCode = txtPostCode.Text;
            CustomerBook.ThisCustomer.PhoneNumber = txtPhoneNumber.Text;
            CustomerBook.ThisCustomer.active = chkactive.Checked;
            //add the record 
            CustomerBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("CustomerDefault.aspx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
        {
            //this line of code redirect back to the customer default page 
            Response.Redirect("CustomerDefault.aspx");
        }
    }

