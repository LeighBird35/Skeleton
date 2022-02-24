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
    }
}