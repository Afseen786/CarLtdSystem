using ClassLibrary;
using System;

namespace CarLtdClasses
{
    public class clsOrder
    {
        public int mOrderNo { get; set; }
        public string mOrderName { get; set; }
        public string mOrderStatus { get; set; }
        public DateTime mOrderDate { get; set; }
        public string mBillingAddress { get; set; }
        public bool mActive { get; set; }

        public bool Find(int OrderNo)
        {
            //create an instance of  the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order no to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mOrderName = Convert.ToString(DB.DataTable.Rows[0]["OrderName"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mBillingAddress = Convert.ToString(DB.DataTable.Rows[0]["BillingAddress"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}