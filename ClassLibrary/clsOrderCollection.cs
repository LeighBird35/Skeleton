using System;
using ClassLibrary;
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

        //comstructor for class
        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("proc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

            //var for the index
            //  Int32 Index = 0;
            //var to store the record count
            //Int32 RecordCount = 0;
            ////object for data connection
            //clsDataConnection DB = new clsDataConnection();
            // //execute the stored procedure
            // DB.Execute("sproc_tblOrder_SelectAll");
            ////get the count of records
            //RecordCount = DB.Count;
            //while there are records to process
            //while (Index < RecordCount)
            //{
            // clsOrder AnOrder = new clsOrder();
            //  //read in the fields from the current record
            // AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
            // AnOrder.OrderSearch = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderSearch"]);
            //AnOrder.OrderAddress = Convert.ToString(DB.DataTable.Rows[Index]["OrderAddress"]);
            // AnOrder.OrderReturn = Convert.ToString(DB.DataTable.Rows[Index]["OrderReturn"]);
            // AnOrder.OrderDelivery = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderDelivery"]);
            //AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
            //add the record to the private data member
            // mOrderList.Add(AnOrder);
            //point to the next record
            // Index++;
            // }
        }
        private void PopulateArray(clsDataConnection dB)
        {
         
             //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get current count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the currewnt record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.OrderSearch = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderSearch"]);
                AnOrder.OrderAddress = Convert.ToString(DB.DataTable.Rows[Index]["OrderAddress"]);
                AnOrder.OrderReturn = Convert.ToString(DB.DataTable.Rows[Index]["OrderReturn"]);
                AnOrder.OrderDelivery = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderDelivery"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);

                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }

            
            }

        public void ReportByOrderAddress(object text)
        {
            throw new NotImplementedException();
        }

        int Add()
            {
                //adds new record to the database based on the values of mThisStock
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                //DB.AddParameter("@bookId", mThisOrder.OrderID);
                DB.AddParameter("@OrderSearch", mThisOrder.OrderSearch);
                DB.AddParameter("@OrderAddress", mThisOrder.OrderAddress);
                DB.AddParameter("@OrderDelivery", mThisOrder.OrderDelivery);
                DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
                DB.AddParameter("@OrderReturn", mThisOrder.OrderReturn);
                //execute the query by returning the primary key value
                return DB.Execute("sproc_tblOrder_Insert");

            }

            void Update()
            {
                //update an existing record based on the values of this address
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters
                DB.AddParameter("@OrderID", mThisOrder.OrderID);
                DB.AddParameter("@OrderSearch", mThisOrder.OrderSearch);
                DB.AddParameter("@OrderAddress", mThisOrder.OrderAddress);
                DB.AddParameter("@OrderReturn", mThisOrder.OrderReturn);
                DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
                DB.AddParameter("@OrderDelivey", mThisOrder.OrderDelivery);
                //execute the stored procedure
                DB.Execute("sproc_tblOrder_Update");
            }

            void Delete()
            {
                //deletes the record pointed to by ThisStock
                //connect to database
                clsDataConnection DB = new clsDataConnection();
                //set parameters for stored procedure
                DB.AddParameter("@OrderID", mThisOrder.OrderID);
                //execute
                DB.Execute("sproc_tblOrder_Delete");
            }
         }


         public void ReportByOrderAddress(string OrderAddress)
        {
            //filtered the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the address parameter to the database
            DB.AddParameter(OrderAddress, OrderAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilteredByOrderAddress");
            //populate the array list witht the data table
            PopulateArray(DB);
        }

      
    }

   
