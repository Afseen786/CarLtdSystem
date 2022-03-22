﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;

namespace CarLtdClasses
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisOrder
        clsOrder mThisOrder = new clsOrder();
        //public property for ThisOrder
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        //public property for the order list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //later
            }
        }

        //constructor for the class
        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records

            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.OrderName = Convert.ToString(DB.DataTable.Rows[Index]["OrderName"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.BillingAddress = Convert.ToString(DB.DataTable.Rows[Index]["BillingAddress"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("OrderName", mThisOrder.OrderName);
            DB.AddParameter("OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("BillingAddress", mThisOrder.BillingAddress);
            DB.AddParameter("Active", mThisOrder.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }
    }
}