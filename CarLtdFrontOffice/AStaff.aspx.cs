using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarLtdClasses;

public partial class AStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff(); //New instance of clsStaff
        AStaff.FirstName = txtFirstName.Text; //Capture first name
        Session["AStaff"] = AStaff; //Store the staff in session object
        Response.Redirect("StaffViewer.aspx"); //Redirect to viewer page
    }
}