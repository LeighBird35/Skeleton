using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestOrder
{
    [TestClass]
    public class tstOrder
    {
        //god tes data 
        //create some test data to pass to the method
        string OrderID = "321";
        string OrderDelivery = Convert.ToString(true);
        string OrderSearch = Convert.ToString(true);
        string OrderAddress = "Millions Road MN8 RA98";
        string OrderReturn = "Billions sea port BS7 SP90";
        string OrderDate = DateTime.Now.Date.ToString();


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
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);

        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {

            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void OrderSearchPropertyOK()
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
        public void OrderDeliveryPropertyOK()
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
        public void OrderAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "Head Town HD5 TN6";
            //assign the data to the property
            AnOrder.OrderAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderAddress, TestData);

        }

        [TestMethod]
        public void OrderReturnPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "Toe Street TE4 ST9";
            //assign the data to the property
            AnOrder.OrderReturn = TestData;
            //test to see that the result is correct
            Assert.AreEqual(AnOrder.OrderReturn, TestData);
        }


        [TestMethod]
        public void FindMetodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 234;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
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
            if (AnOrder.OrderDelivery != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIDFound()
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
            if (AnOrder.OrderID != 234)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderSearchFound()
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
            if (AnOrder.OrderSearch != true)
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
            if (AnOrder.OrderReturn != Convert.ToString("My town, MY5 TN7"))
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
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.OrderAddress != Convert.ToString("Yours Town, YS5 TN9"))
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void OrderAddressMinLessOne()
        {
            //create an instance of the clas we want to create
            clsOrder AnOrder = new clsOrder();
            //string varaible to store any error message
            String Error = "";
            //create some test data to pass tp the method
            string OrderAddress = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderAddress = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderAddress = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderAddressMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderAddress = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderAddress = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderAddress = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderAddress = "";
            OrderAddress = OrderAddress.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
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
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
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
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
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
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
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
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderReturn = "";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correctss, OrderReturn, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderReturn = "a";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderReturn = "aa";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderReturn = "aaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderReturn = "aaaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderReturn = "aaaaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderReturn = "aaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

       

        [TestMethod]
        public void OrderSearchMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderSearch = "a";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderSearchMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderSearch = "aa";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderSearchMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderSearch = "";
            OrderSearch = OrderSearch.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderSearchMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderSearch = "";
            OrderSearch = OrderSearch.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderSearchMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderSearch = "";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderSearchMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderSearch = "";
            OrderSearch = OrderSearch.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDeliveryMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderDelivery = "";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDeliveryMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderDelivery = "a";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDeliveryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderDelivery = "aa";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDeliveryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderDelivery = "";
            OrderDelivery = OrderDelivery.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDeliveryMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderDelivery = "";
            OrderDelivery = OrderDelivery.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDeliveryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string OrderDelivery = "";
            OrderDelivery = OrderDelivery.PadRight(51, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDeliveryMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderDelivery = "";
            OrderDelivery = OrderDelivery.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderDelivery, OrderAddress, OrderReturn, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


    }
}
