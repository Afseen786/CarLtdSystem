using CarLtdClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Order : System.Web.UI.Page
{
    Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder clsOrder = new clsOrder();
        //get the data from the session object
        clsOrder AnOrder = (clsOrder)Session["AnOrder"];
        //display the order number for this entry
        Response.Write(AnOrder.OrderNo);
    }

    protected void btnFindOrders_Click(object sender, EventArgs e)
    {

        //create an instance of the Orders class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //find the record
        Found = AnOrder.Find(OrderNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            //txtOrderNo.Text = AnOrder.OrderNo.ToString();
            txtOrderName.Text = AnOrder.OrderName;
            txtOrderStatus.Text = AnOrder.OrderStatus;
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtBillingAddress.Text = AnOrder.BillingAddress.ToString();
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (OrderNo == -1)
        {
            //dd the record
            Add();
        }
        else
        {
            //update the new record
            Update();
        }

        //all done so redirect back to the main page
        Response.Redirect("OrderDefault.aspx");
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order no
        string OrderNo = this.txtOrderNo.Text;
        //capture the order name
        string OrderName = txtOrderName.Text;
        //capture the order status
        string OrderStatus = txtOrderStatus.Text;
        //capture the order date
        string OrderDate = txtOrderDate.Text;
        //capture the billing address
        string BillingAddress = txtBillingAddress.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(OrderNo, OrderName, OrderStatus, OrderDate, BillingAddress);
        if (Error == "")
        {
            //capture the order no
            AnOrder.OrderNo = Convert.ToInt32(OrderNo);
            //capture the order name
            AnOrder.OrderName = OrderName;
            //capture the order status
            AnOrder.OrderStatus = OrderStatus;
            //capture the order date
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //store the order in the session object
            Session["AnOrder"] = AnOrder;
            //redirect to the viewer page
            Response.Redirect("OrderViewwer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

        void Add()
        {
            //create an instance of the order book
            CarLtdClasses.clsOrderCollection OrderBook = new CarLtdClasses.clsOrderCollection();
            //validate the data on the web form
            String Error = OrderBook.ThisOrder.Valid(txtOrderNo.Text, txtOrderName.Text, txtOrderStatus.Text, txtOrderDate.Text, txtBillingAddress.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                OrderBook.ThisOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);
                OrderBook.ThisOrder.OrderName = txtOrderName.Text;
                OrderBook.ThisOrder.OrderStatus = txtOrderStatus.Text;
                OrderBook.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
                OrderBook.ThisOrder.BillingAddress = txtBillingAddress.Text;
            OrderBook.ThisOrder.Active = chkActive.Checked;
                //add the record
                OrderBook.Add();
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

    //function for updating records
    void Update()
    {
        //create an instance of the order book
        CarLtdClasses.clsOrderCollection OrderBook = new clsOrderCollection();
        //validate the data on the web form
        String Error = OrderBook.ThisOrder.Valid(txtOrderNo.Text, txtOrderName.Text, txtOrderStatus.Text, txtOrderDate.Text, txtBillingAddress.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            OrderBook.ThisOrder.Find(OrderNo);
            //get the data entered by the user
            OrderBook.ThisOrder.OrderName = txtOrderName.Text;
            OrderBook.ThisOrder.OrderStatus = txtOrderStatus.Text;
            OrderBook.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            OrderBook.ThisOrder.BillingAddress = txtBillingAddress.Text;
            OrderBook.ThisOrder.Active = chkActive.Checked;
            //update the record
            OrderBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("OrderDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

        void DisplayOrders()
        {
            //create an instance of the order book
            clsOrderCollection OrderBook = new clsOrderCollection();
            //find the record to update
            OrderBook.ThisOrder.Find(OrderNo);
            //display the data for this record
            txtOrderName.Text = OrderBook.ThisOrder.OrderName;
            txtOrderStatus.Text = OrderBook.ThisOrder.OrderStatus;
            txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString("dd/mm/yyyy");
            txtBillingAddress.Text = OrderBook.ThisOrder.BillingAddress;
            chkActive.Checked = OrderBook.ThisOrder.Active;
        }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //this line of code redirect back to the order default page 
        Response.Redirect("OrderDefault.aspx");
    }
}