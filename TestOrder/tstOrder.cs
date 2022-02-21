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

        //[TestMethod]
        //public void OrderReturnOK()
        //{ 
        //   //create an instance of the class we want to create
        //   clsOrder AnOrder = new clsOrder();
        //   //assign the data to the property
        //   AnOrder.OrderReturn = TestData;
        //   //test to see that the two values are the same
        //   Assert.AreEqual(AnOrder.OrderReturn, TestData);
        //}
    }
}
