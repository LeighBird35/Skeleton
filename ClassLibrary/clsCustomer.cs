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
            //set the private data members to the test data value
            mCustomerNo = 123;
            mCustomerName = Convert.ToString("Ash Williams");
            mCustomerAddress = Convert.ToString("10 Cloverfield Lane");
            mhasAccount = true;
            mcreationDate = Convert.ToDateTime("02/02/2022");
            //always return true
            return true;
        }
    }
}