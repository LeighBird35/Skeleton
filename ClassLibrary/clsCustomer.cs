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
                return mcustomerNo;
            }

            set
            {
                //this line of code allows data into the property
                mcustomerNo = value;
            }
        }



        public string customerName
        {
            get
            {
                //this line of code sends data out of the property
                return mcustomerName;
            }

            set
            {
                //this line of code allows data into the property
                mcustomerName = value;
            }
        }

        public string customerAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mcustomerAddress;
            }

            set
            {
                //this line of code allows data into the property
                mcustomerAddress = value;
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
        private Int32 mcustomerNo;
        private string mcustomerName;
        private string mcustomerAddress;
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
                mcustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["customerNo"]);
                mcustomerName = Convert.ToString(DB.DataTable.Rows[0]["customerName"]);
                mcustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["customerAddress"]);
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

        public string Valid(string customerName, string customerAddress, string creationDate)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temp variable to store date values
            DateTime DateTemp;

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

            //if the customerName is blank
            if (customerName.Length == 0)
            {
                //record the error
                Error = Error + "The customer name may not be blank: ";
            }

            //if the customerName is greater than 50 characters
            if (customerName.Length > 50)
            {
                //record the error
                Error = Error + "The customer name must be less than 50 characters : ";
            }

            //customerAddress

            //if the customer address is blank
            if (customerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The customer address may not be blank: ";
            }

            //if the customer address is greater than 100 characters
            if (customerAddress.Length > 100)
            {
                //record the error
                Error = Error + "The customer address must be less than 50 characters : ";
            }


            //return any error messages
            return Error;
        }
    }
}