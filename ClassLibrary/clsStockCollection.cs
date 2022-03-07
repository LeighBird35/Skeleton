using ClassLibrary;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {


        //private data member for the list
        List<clsStock> mstockList = new List<clsStock>();
        public List<clsStock> stockList
        {
            get
            {
                //return private data
                return mstockList;
            }
            set
            {
                //set private data
                mstockList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mstockList.Count;
            }
            set
            {
                //later
            }
        }

        public clsStock ThisStock { get; set; }

        //comstructor for class
        public clsStockCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                clsStock aStock = new clsStock();
                //read in the fields from the current record
                aStock.bookId = Convert.ToInt32(DB.DataTable.Rows[Index]["bookId"]);
                aStock.bookSearches = Convert.ToString(DB.DataTable.Rows[Index]["bookSearches"]);
                aStock.bookDescription = Convert.ToString(DB.DataTable.Rows[Index]["bookDescription"]);
                aStock.price = Convert.ToDouble(DB.DataTable.Rows[Index]["price"]);
                aStock.available = Convert.ToBoolean(DB.DataTable.Rows[Index]["available"]);
                aStock.dayAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["dayAdded"]);
                //add the record to the private data member
                mstockList.Add(aStock);
                //point to the next record
                Index++;
            }

         
        }

    }
}
