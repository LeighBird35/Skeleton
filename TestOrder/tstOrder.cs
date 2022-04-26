using ClassLibrary;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing6
{
    [TestClass]
    public class TstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }


        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign tot the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderIDOK()
        {

            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 234;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void OrderSearchOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.OrderSearch = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderSearch, TestData);
        }

        [TestMethod]
        public void OrderDeliveryOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.OrderDelivery = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDelivery, TestData);
        }

        [TestMethod]
        public void OrderAddressOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "Billions, M.Kudu";
            //assign the data to the property
            AnOrder.OrderAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderAddress, TestData);
        }

        [TestMethod]
        public void OrderReturnOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestOrderDeliveryFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean varaible to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 234;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property

           
          

            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestOrderReturnFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean varaible to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 234;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property

            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderAddressFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean varaible to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 234;

            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.OrderAddress != Convert.ToString("Yours town, YS3,MN4"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {

            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean varaible to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 234;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        public void OrderIDMinLessOne()
        {
            //create an instance of the clas we want to create
            clsOrder AnOrder = new clsOrder();
            //string varaible to store any error message
            String Error = "";
            //create some test data to pass tp the method
            string OrderID = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void OrderIDMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderSearchMinLessOne()
        {
            //create class instance
            clsOrder AnOrder = new clsOrder();
            //srting variable to store an error message
            String Error = "";
            //create some test data to pass to the method
            string OrderSearch = ""; //should trigger an error
            //invoke method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderSearchMin()
        {
            //create class instance
            clsOrder AnOrder = new clsOrder();
            //srting variable to store an error message
            String Error = "";
            //create some test data to pass to the method
            string OrderSearch = "a";
            //invoke method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderSearchMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderSearch = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid((OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderSearchExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderSearch = "";
            OrderSearch = OrderSearch.PadRight(10000, 'a');
            //invoke the method
            Error = AnOrder.Valid((OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

          //------------------day added validation--------------
        [TestMethod]
        public void OrderDateExtremeMin()
        {
              //create a class instance
              clsOrder AnOrder = new clsOrder();
              //string variable to store error message
              String Error = "";
              //create a variable to store the test data
              DateTime TestDate;
             //set date to todays daye
              TestDate = DateTime.Now.Date;
              //change date to whatever is 100 years less
              TestDate = TestDate.AddYears(-100);
              //convert the date to a string variable
               string OrderDate = TestDate.ToString();
              //invoke method
              Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
             //test to see that the result is correct
              Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        { 

        
              //create an instance of the class we want to create
              clsOrder AnOrder = new clsOrder();
              //string variable to store any error message
              String Error = "";
            //create a variable to store the test date data
             DateTime TestDate;
             //set the date totodays date
              TestDate = DateTime.Now.Date;
              //change the date to whatever the date is less 1 day
               TestDate = TestDate.AddDays(-1);
              //convert the date variable to a string variable
              string OrderDate = TestDate.ToString();
              //invoke the method
             Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        { 
                
              //create an instance of the class we want to create
               clsOrder AnOrder = new clsOrder();
              //string variable to store any error message
               String Error = "";
               //create a variable to store the test date data
               DateTime TestDate;
               //set the date totodays date
               TestDate = DateTime.Now.Date;
               //convert the date variable to a string variable
               string OrderDate = TestDate.ToString();
               //invoke the method
               Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
              //test to see that the result is correct
              Assert.AreEqual(Error, "");
        }

        [TestMethod]
       public void OrderDateMinPlusOne()
       { 
                
             //create an instance of the class we want to create
               clsOrder AnOrder = new clsOrder();
             //string variable to store any error message
              String Error = "";
              //create a variable to store the test date data
              DateTime TestDate;
              //set the date totodays date
               TestDate = DateTime.Now.Date;
               //change the date to whatever the date is less 1 day
               TestDate = TestDate.AddDays(1);
               //convert the date variable to a string variable
               string OrderDate = TestDate.ToString();
                //invoke the method
               Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
               //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
       }

       [TestMethod]
       public void OrderDateExtremeMax()
       { 
                
            //create an instance of the class we want to create
              clsOrder AnOrder = new clsOrder();
               //string variable to store any error message
              String Error = "";
              //create a variable to store the test date data
              DateTime TestDate;
               //set the date totodays date
              TestDate = DateTime.Now.Date;
              //change the date to whatever the date is less 1 day
              TestDate = TestDate.AddYears(100);
              //convert the date variable to a string variable
               string OrderDate = TestDate.ToString();
              //invoke the method
               Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
              //test to see that the result is correct
               Assert.AreNotEqual(Error, "");
       }

       [TestMethod]
       public void OrderDateInvalidData()
       {
             //create class instance
             clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
             String Error = "";
            //set the dayAdded to a non date value
            string OrderDate = "this is not a date!";
            //invoke the method
             Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

       }
         
    }
}



    


