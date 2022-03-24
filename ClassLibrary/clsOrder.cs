using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        //private data member for the order number property
        private Boolean mActive;
        //OrderID public property
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }
        //private data member for the order number property
        private Int32 mOrderID;
        //OrderID public property
        public Int32 OrderID
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderID;
            }
            set
            {
                //this line of code allows data into the property
                mOrderID = value;
            }
        }

        //private data member for the OrderSearch property
        private Boolean mOrderSearch;
        //OrderSearch public property
        public Boolean OrderSearch
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderSearch;
            }

            set
            {
                //yhis line of code allows data into the property
                mOrderSearch = value;
            }
        }

        //private data member for the Date property
        private DateTime mOrderDate;
        //Date public property
        public DateTime OrderDate
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderDate;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDate = value;
            }
        }

        //private data member for the delivery property
        private Boolean mOrderDelivery;
        //Delivery public property
        public Boolean OrderDelivery
        {
            get
            {
                //this line of code semds data out of the property
                return mOrderDelivery;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDelivery = value;
            }
        }

        //private data member for the delivery poperty
        private String mOrderAddress;
        //Address public property
        public String OrderAddress
        {
            get
            {
                //this line of code send data out of the property
                return mOrderAddress;
            }
            set
            {
                //this line of code allows data into the property
                mOrderAddress = value;
            }
        }

        //private data member for Return Order property
        private String mOrderReturn;
        //Return Order public property
        public String OrderReturn
        {
            get
            {
                //this line of code send data out of the property
                return mOrderReturn;
            }
            set
            {
                //this line of code allows data into the property
                mOrderReturn = value;
            }
        }

        public bool Find(int OrderID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Order number to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should be either one and zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderAddress = Convert.ToString(DB.DataTable.Rows[0]["OrderAddress"]);
                mOrderSearch = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderSearch"]);
                mOrderDelivery = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderDelivery"]);
                mOrderReturn = Convert.ToString(DB.DataTable.Rows[0]["OrderReturn"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderID"]);
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
