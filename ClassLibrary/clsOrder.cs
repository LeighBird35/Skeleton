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

        public string Valid(string OrderID, string OrderAddress, string OrderReturn, string OrderSearch, string OrderDate, string OrderDelivery)
        {
            //create a string variable to store the errors
            String Error = "";
            //create a temporary variable to store data values
            DateTime DateTemp;
                
            //if the Order number is blank
            if (OrderID.Length == 0)
            {
                //record the error
                Error = Error + "The order number may not be blank";
            }
            //if the order number is greater than 6 characters
            if (OrderID.Length > 6)
            {
                //record the error
                Error = Error + "The order number must not be less than 6 characters:";
            }
            //copy the dateadded values to the datetemp variable
            DateTemp = Convert.ToDateTime(OrderDate);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the past :";
            }
            //check to see if the date is greater than today's date
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the Order Address blank
            if (OrderAddress.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank : ";
            }
            //if the Order Address is too long
            if (OrderAddress.Length > 9)
            {
                //record the error
                Error = Error + "The address must be less than 9 characters : ";
            }
            //is the order return blank
            if (OrderReturn.Length == 0)
            {
                //record the error
                Error = Error + "The order return may not be blank : ";
            }
            //if the Order return is too long
            if (OrderReturn.Length > 50)
            {
                //record the error
                Error = Error + "The order return must be less than 50 characters : ";
            }
            //is the Order search blank
            if (OrderSearch.Length == 0)
            {
                //record the error
                Error = Error + "The search may not be blank : ";
            }
            //if the Order search is too long
            if (OrderSearch.Length > 50)
            {
                //record the error
                Error = Error + "The search must be less than 50 characters : ";
            }
            //is the Order delivery blank
            if (OrderDelivery.Length == 0)
            {
                //record the error
                Error = Error + "The delivery may not be blank : ";
            }
            //if the Order delivery is too long
            if (OrderDelivery.Length > 50)
            {
                //record the error
                Error = Error + "The delivery must be less than 50 characters : ";
            }

            //return any error
            return Error;
        }

        public string Valid(object orderID, object orderSearch, object orderDelivery, object orderAddress, string orderDate)
        {
            throw new NotImplementedException();
        }
    }
}
