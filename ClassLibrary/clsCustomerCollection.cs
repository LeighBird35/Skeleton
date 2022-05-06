using ClassLibrary;
using System;
using System.Collections.Generic;



namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();



        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }


        public int Count 
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //will worry about this later
            }
        
        }



        public clsCustomer ThisCustomer { 
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }



        //constructor for the class
        public clsCustomerCollection()
        {
            //object for data collection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@customerNo", mThisCustomer.customerNo);
            DB.AddParameter("@customerName", mThisCustomer.customerName);
            DB.AddParameter("@customerAddress", mThisCustomer.customerAddress);
            DB.AddParameter("@hasAccount", mThisCustomer.hasAccount);
            DB.AddParameter("@creationDate", mThisCustomer.creationDate);
            //execute the stored procedure
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@customerNo", mThisCustomer.customerNo);
            DB.AddParameter("@customerName", mThisCustomer.customerName);
            DB.AddParameter("@customerAddress", mThisCustomer.customerAddress);
            DB.AddParameter("@hasAccount", mThisCustomer.hasAccount);
            DB.AddParameter("@creationDate", mThisCustomer.creationDate);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@customerNo", mThisCustomer.customerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByCustomerName(string customerName)
        {
            //filters the records based on a full or partial name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the CustomerName parameter to the database
            DB.AddParameter("@CustomerName", customerName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerName");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        public void ReportByCustomerNameDataFound(string customerName)
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that doesn't exist
            FilteredCustomers.ReportByCustomerName("xxxxx xxxxx");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is 
            }
        }


        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
                AnCustomer.customerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["customerNo"]);
                AnCustomer.customerName = Convert.ToString(DB.DataTable.Rows[Index]["customerName"]);
                AnCustomer.customerAddress = Convert.ToString(DB.DataTable.Rows[Index]["customerAddress"]);
                AnCustomer.hasAccount = Convert.ToBoolean(DB.DataTable.Rows[Index]["hasAccount"]);
                AnCustomer.creationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["creationDate"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }
    }
}