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
}