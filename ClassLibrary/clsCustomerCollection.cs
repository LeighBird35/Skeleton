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
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
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
            return DB.Execute("sproc_tblCustomer_Update");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}