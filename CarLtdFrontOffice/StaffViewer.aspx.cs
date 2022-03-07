using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarLtdClasses;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff(); //Instance of clsStaff
        AStaff = (clsStaff)Session["AStaff"]; //Get data from the session object
        Response.Write(AStaff.FirstName);
    }
}