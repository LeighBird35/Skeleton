using ClassLibrary;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        
        //private data member for the list
        List<clsStock> mstockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();
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

        public clsStock ThisStock
        {
            get
            {
                //return pivate data
                return mThisStock;
            }
            set
            {
               //set private data
                mThisStock = value;
            }
        }

        //comstructor for class
        public clsStockCollection()
        {

            //onject for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the sttored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate
            PopulateArray(DB);

            ////var for the index
            //Int32 Index = 0;
            ////var to store the record count
            //Int32 RecordCount = 0;
            ////object for data connection
            //clsDataConnection DB = new clsDataConnection();
            ////execute the stored procedure
            //DB.Execute("sproc_tblStock_SelectAll");
            ////get the count of records
            //RecordCount = DB.Count;
            ////while there are records to process
            //while (Index < RecordCount)
            //{
            //    clsStock aStock = new clsStock();
            //    //read in the fields from the current record
            //    aStock.bookId = Convert.ToInt32(DB.DataTable.Rows[Index]["bookId"]);
            //    aStock.bookSearches = Convert.ToString(DB.DataTable.Rows[Index]["bookSearches"]);
            //    aStock.bookDescription = Convert.ToString(DB.DataTable.Rows[Index]["bookDescription"]);
            //    aStock.price = Convert.ToDouble(DB.DataTable.Rows[Index]["price"]);
            //    aStock.available = Convert.ToBoolean(DB.DataTable.Rows[Index]["available"]);
            //    aStock.dayAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["dayAdded"]);
            //    //add the record to the private data member
            //    mstockList.Add(aStock);
            //    //point to the next record
            //    Index++;
            //}

         
        }

        public int Add()
        {
            //adds new record to the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //DB.AddParameter("@bookId", mThisStock.bookId);
            DB.AddParameter("@bookSearches", mThisStock.bookSearches);
            DB.AddParameter("@bookDescription", mThisStock.bookDescription);
            DB.AddParameter("@price", mThisStock.price);
            DB.AddParameter("@dayAdded", mThisStock.dayAdded);
            DB.AddParameter("@available", mThisStock.available);
            //execute the query by returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values of this address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters
            DB.AddParameter("@bookId", mThisStock.bookId);
            DB.AddParameter("@bookSearches", mThisStock.bookSearches);
            DB.AddParameter("@bookDescription", mThisStock.bookDescription);
            DB.AddParameter("@price", mThisStock.price);
            DB.AddParameter("@dayAdded", mThisStock.dayAdded);
            DB.AddParameter("@available", mThisStock.available);
            //execute the stored procedure
            DB.Execute("sproc_tbStock_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisStock
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored procedure
            DB.AddParameter("@bookId", mThisStock.bookId);
            //execute
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportBybookDescription(string bookDescription)
        {
            //filters the rcords based on a full or partial book title
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send the title parameter to the database
            DB.AddParameter("@bookDescription", bookDescription);
            //execute the stored procedure
            DB.Execute("proc_tblStock_FilteredBybookDescription");
            //POPULATE THE ARRAY LIST WITH DATA TABLE
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get current count of records
            RecordCount = DB.Count;
            //clear the private array list
            mstockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock
                clsStock aStock = new clsStock();
                //read in the fields from the currewnt record
                aStock.bookId = Convert.ToInt32(DB.DataTable.Rows[Index]["bookId"]);
                aStock.bookSearches = Convert.ToString(DB.DataTable.Rows[Index]["bookSearches"]);
                aStock.bookDescription = Convert.ToString(DB.DataTable.Rows[Index]["bookDescription"]);
                aStock.price = Convert.ToDouble(DB.DataTable.Rows[Index]["price"]);
                aStock.dayAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["dayAdded"]);
                aStock.available = Convert.ToBoolean(DB.DataTable.Rows[Index]["available"]);


                //add the record to the private data member
                mstockList.Add(aStock);
                //point at the next record
                Index++;
            }
                  


        }

    }
}
