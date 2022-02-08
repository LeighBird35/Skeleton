using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(aStock);
        }

        [TestMethod]
        public void availableStockOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create some test data to assign to the property
            Boolean testData = true;
            //assign the data to the property
            aStock.available = testData;
            //test to see if the two values are the same
            Assert.AreEqual(aStock.available, testData);
        }

        [TestMethod]
        public void dayAddedStockOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create some test data to assign to the property
            DateTime testData = DateTime.Now.Date;
            //assign the data to the property
            aStock.dayAdded = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.dayAdded, testData);
        }

        [TestMethod]
        public void bookIdStockOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create some test data to assign to the property
            Int64 testData = 23;
            //assign the data to the property
            aStock.bookId = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.bookId, testData);
        }


        [TestMethod]
        public void bookSearchesStockOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create some test data to assign to the property
            String testData = "Horror, S. King";
            //assign the data to the property
            aStock.bookSearches = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.bookSearches, testData);
        }


        [TestMethod]
        public void bookDescriptionStockOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create some test data to assign to the property
            String testData = "IT";
            //assign the data to the property
            aStock.bookDescription = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.bookDescription, testData);
        }


        [TestMethod]
        public void priceStockOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create some test data to assign to the property
            Double testData = 15.60;
            //assign the data to the property
            aStock.price = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.price, testData);
        }

    }
}

       
