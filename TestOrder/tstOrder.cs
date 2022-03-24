using ClassLibrary;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestOrder;

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
        public void DateAddedOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign tot the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);
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
           Assert.AreEqual(AnOrder.OrderReturn, TestData);
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
            if (AnOrder.OrderDelivery != Convert.ToString("The two kings Crown"))
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
            if (AnOrder.OrderReturn != Convert.ToString("Addicted, Test Towm")
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

    }
}

    


