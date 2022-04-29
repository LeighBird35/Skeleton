using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public Int32 customerNo
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerNo;
            }

            set
            {
                //this line of code allows data into the property
                mCustomerNo = value;
            }
        }



        public string CustomerName
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerName;
            }

            set
            {
                //this line of code allows data into the property
                mCustomerName = value;
            }
        }

        public string customerAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerAddress;
            }

            set
            {
                //this line of code allows data into the property
                mCustomerAddress = value;
            }
        }


        public bool hasAccount
        {
            get
            {
                //this line of code sends data out of the property
                return mhasAccount;
            }

            set
            {
                //this line of code allows data into the property
                mhasAccount = value;
            }
        }



        public DateTime creationDate
        {
            get
            {
                //this line of code sends data out of the property
                return mcreationDate;
            }

            set
            {
                //this line of code allows data into the property
                mcreationDate = value;
            }
        }

        //private data members
        private Int32 mCustomerNo;
        private string mCustomerName;
        private string mCustomerAddress;
        private bool mhasAccount;
        private DateTime mcreationDate;

        public bool Find(int customerNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer no to search for
            DB.AddParameter("@CustomerNo", customerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            //if one record is found (there should either be a one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["customerNo"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["customerName"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["customerAddress"]);
                mhasAccount = Convert.ToBoolean(DB.DataTable.Rows[0]["hasAccount"]);
                mcreationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["creationDate"]);

                //return that everything worked ok
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string customerNo, string customerName, string customerAddress, string hasAccount, string creationDate)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temp variable to store date values
            DateTime DateTemp;

            //if the customerNo is blank
            if (customerNo.Length == 0)
            {
                //record the error
                Error = Error + "The customer no may not be blank: ";
            }

            //if the customerNo is greater than 6 characters
            if (customerNo.Length > 6)
            {
                //record the error
                Error = Error + "The customer no must be less than 6 characters : ";
            }



            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(creationDate);

                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }

                //check if the dateAdded valuve is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "That was not a valid date : ";
            }
            //return any error messages
            return Error;
        }
    }
}