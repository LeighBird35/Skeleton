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
            //set the private data members to the test data value
            mOrderID = 234;
            mOrderDate = Convert.ToDateTime("12/03/2000");
            mOrderDelivery = true;
            mOrderSearch = true;
            mOrderReturn = Convert.ToString("My town, MY3 TN7");
            mOrderAddress = Convert.ToString("Yours town, YS3,MN4");
            mActive = true;
            //always return value
            return true;
        }
    }
}
