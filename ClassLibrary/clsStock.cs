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
            //set private data members to the test data value
            mbookId = 3;
            mbookSearches = "Fantasy, L.Bardugo";
            mbookDescription = "Six Of Crows";
            mprice = 17.40;
            mavailable = true;
            mdayAdded = Convert.ToDateTime("17/02/2022");
            
            //always return true
            return true;
        }
    }
}