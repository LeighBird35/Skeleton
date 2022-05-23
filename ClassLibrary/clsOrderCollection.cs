using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                //return private data
                return mOrderList;
            }
            set
            {
                //set private data
                mOrderList = value;
            }
        }

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

        public clsOrder ThisOrder
        {
            get
            {
                //return pivate data
                return mThisOrder;
            }
            set
            {
                //set private data
                mThisOrder = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisOrder
            //set the primaruy key value of the new record
            //mThisOrder.OrderID = 123;
            //return the primary key of the new record
            //return mThisOrder.OrderID;
            
            
                //adds new record to the database based on the values of mThisOrder
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                DB.AddParameter("@OrderID", mThisOrder.OrderID);
                DB.AddParameter("@OrderAddress", mThisOrder.OrderAddress);
                DB.AddParameter("@OrderReturn", mThisOrder.OrderReturn);
                DB.AddParameter("@OrderSearch", mThisOrder.OrderSearch);
                DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
                DB.AddParameter("@OrderDelivery", mThisOrder.OrderDelivery);
                //execute the query by returning the primary key value
                return DB.Execute("sproc_tblOrder_Insert");

            
        }

        public void Update()
        {
            //adds new record to the database based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@OrderAddress", mThisOrder.OrderAddress);
            DB.AddParameter("@OrderReturn", mThisOrder.OrderReturn);
            DB.AddParameter("@OrderSearch", mThisOrder.OrderSearch);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@OrderDelivery", mThisOrder.OrderDelivery);
            //execute the query by returning the primary key value
            DB.Execute("sproc_tblOrder_Update");
        }

       

        public void Delete()
        {
            //delete the new record pointed to by thisOrder
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

       
        public void ReportByOrderAddress(string OrderAddress)
        {

            //filters the rcords based on a full or partial order address
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send the title parameter to the database
            DB.AddParameter("@OrderAddress", ReportByOrderAddress);
            //execute the stored procedure
            DB.Execute("proc_tblOrder_FilteredByOrderAddress");
            //populate the array list with thw data table
            PopulateArray(DB);



        }

        //constructor for the class
        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);  
        }
        void PopulateArray (clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            Int32 RecordCount = 0;
            //object for data connection
            //clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            //DB.Execute("sproc_tblOrder_SelectAll");
            ////get the count of records
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.OrderAddress = Convert.ToString(DB.DataTable.Rows[Index]["OrderAddress"]);
                AnOrder.OrderReturn = Convert.ToString(DB.DataTable.Rows[Index]["OrderReturn"]);
                AnOrder.OrderSearch = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderSearch"]);
                AnOrder.OrderDelivery = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderDelivery"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point to the next record
                Index++;
            }

            
        }
    }
    
}