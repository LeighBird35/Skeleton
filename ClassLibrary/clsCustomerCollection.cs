using System.Collections.Generic;
using System;



namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();




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
                //gonna worry bout this one later... so in like 10 mins when I'm done with this shit
            }
        
        }



        public clsCustomer ThisCustomer { get; set; }



        //constructor for the class
        public clsCustomerCollection()
        {
            //create the items of test data
            clsCustomer TestItem = new clsCustomer();
            //set the properties
            TestItem.customerNo = 2;
            TestItem.customerAddress = "60 Klaatu Road";
            TestItem.CustomerName = "Ash Williams";
            TestItem.hasAccount = true;
            TestItem.creationDate = DateTime.Now.Date;
            //add the item to the test list
            mCustomerList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsCustomer();
            //set its properties
            TestItem.customerNo = 3;
            TestItem.customerAddress = "60 Swanfield Road";
            TestItem.CustomerName = "Tony Stark";
            TestItem.hasAccount = true;
            TestItem.creationDate = DateTime.Now.Date;
            //add the item to the test list
            mCustomerList.Add(TestItem);
        }
    }
}