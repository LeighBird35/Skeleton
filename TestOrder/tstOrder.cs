using ClassLibrary;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing6
{
    [TestClass]
    public class tstOrder
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
            Int32 TestData = 1;
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
            //assign the data to the property
            AnOrder.OrderReturn = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderReturn, testData);
        }

        //------------Found test------------

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 234;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 234;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order number
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
            if (AnOrder.OrderDelivery =! Convert.ToString("The two kings Crown"))
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
            if (AnOrder.OrderReturn != Convert.ToString("Addicted, Test Towm");
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
            if (AnOrder.OrderAddress != )
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 234;
            //invoke the mehod
            Found = AnOrder.Find(AnOrder);
            //check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("12/03/2000"))
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

        //------------------Date added validation--------------

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
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()

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
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()

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
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()

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
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()

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
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dayAddedInvalidData()
        {
            //create class instance
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the dayAdded to a non date value
            string OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //-------------OrderSearch------------

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
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
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
            Error = AnOrder.Valid((OrderSearch, OrderReturn, OrderAddress, OrderDate);
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
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
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
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressMinLessOne()
        {

            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderAddress = "";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressMin()
        {

            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderAddress = "a";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
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
            //this should pass
            string OrderAddress = "aa";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
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
            //this should pass
            string OrderAddress = "aaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
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
            //this should pass
            string OrderAddress = "aaaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressMaxPlusOne()
        {

            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderAddress = "aaaaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressMid()
        {

            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderAddress = "aaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
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
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
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
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
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
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnsMaxLessOne()
        {

            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderReturn = "aaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
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
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderReturnMaxPlusOne()
        {

            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderAddress = "aaaaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
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
            Error = AnOrder.Valid(OrderSearch, OrderReturn, OrderAddress, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}

