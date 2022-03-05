using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the bookId property
        private Int32 mbookId;
        //bookId public property
        public Int32 bookId
        {
            get
            {
                //this line of code sends data out of the property
                return mbookId;
            }
            set
            {
                //this line of code allows data into the property
                mbookId = value;
            }
        }

        //private data member for bookSearches
        private String mbookSearches;
        //bookSearches public property
        public String bookSearches
        {
            get
            {
                //this line of code sends data out of the property
                return mbookSearches;
            }
            set
            {
                //this line of code allows data into the property
                mbookSearches = value;
            }
        }

        //private data member for bookDescription
        private String mbookDescription;
        //bookDescription public property
        public String bookDescription
        {
            get
            {
                //this line of code sends data out of the property
                return mbookDescription;
            }
            set
            {
                //this line of code allows data into the property
                mbookDescription = value;
            }
        }

        //private data member for price
        private Double mprice;
        //price public property
        public Double price
        {
            get
            {
                //this line of code sends data out of the property
                return mprice;
            }
            set
            {
                //this line of code allows data into the property
                mprice = value;
            }
        }

        //private data member for available
        private Boolean mavailable;
        //available public property
        public Boolean available
        {
            get
            {
                //this line of code sends data out of the property
                return mavailable;
            }
            set
            {
                //this line of code allows data into the property
                mavailable = value;
            }
        }

        //private data member for dayAdded
        private DateTime mdayAdded;
        //dayAdded public property
        public DateTime dayAdded
        {
            get
            {
                return mdayAdded;
            }
            set
            {
                mdayAdded = value;
            }
        }
                


        public bool Find(int bookId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add a parameter for the bookId to search for
            DB.AddParameter("@bookId", bookId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterBybookId");
            //if only one record is found (there should be one or 0)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mbookId = Convert.ToInt32(DB.DataTable.Rows[0]["bookId"]);
                mbookSearches = Convert.ToString(DB.DataTable.Rows[0]["bookSearches"]);
                mbookDescription = Convert.ToString(DB.DataTable.Rows[0]["bookDescription"]);
                mprice = Convert.ToDouble(DB.DataTable.Rows[0]["price"]);
                mavailable = Convert.ToBoolean(DB.DataTable.Rows[0]["available"]);
                mdayAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["dayAdded"]);
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

        public string Valid(string bookSearches, string bookDescription, string price, string dayAdded)
        {
            //create a sring variable to store the error
            String Error = "";
            //create a temp variable to store date values
            DateTime DateTemp;
            Double TestPrice;

            //----------book searches-------------

            //if the bookSearches is blank
            if (bookSearches.Length == 0)
            {
                //record the error
                Error = Error + "The Search Parameters must not be blank : ";
            }

            if (bookSearches.Length > 10000)
            {
                Error = Error + "The Search Parameters must be less than 10,000 characters :";
            }

            //----------book description--------------
            //is bookDescriptions blank
            if (bookDescription.Length == 0)
            {
                //record the error
                Error = Error + "The title must not be blank : ";
            }

            if (bookDescription.Length > 10000)
            {
                Error = Error + "The title must be less than 10,000 characters :";
            }

            //----------------price-----------------           
            try
            {
                TestPrice = Convert.ToDouble(price);
                //is price blank
                if (TestPrice == 0.00)
                {
                    //record the error
                    Error = Error + "The price may not be blank : ";
                }

                if (TestPrice > 1000000.00)
                {
                    //record the error
                    Error = Error + "The price must be less than £10,000,00 : ";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The price was not valid";
            }
        


            //------------------day added---------------

            try
            {

                //copy the daYAdded value to the DateTemp cariable
                DateTemp = Convert.ToDateTime(dayAdded);
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
                Error = Error + "The date was not a valid date";
            }

            //return any error message
            return Error;
        }
    }
}