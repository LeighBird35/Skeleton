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

        //--------------OK TESTS ---------------------

        [TestMethod]
        public void bookIdStockOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create some test data to assign to the property
            Int32 testData = 3;
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
            String testData = "Fantasy, L.Bardugo";
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
            String testData = "Six Of Crows";
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
            Double testData = 17.40;
            //assign the data to the property
            aStock.price = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.price, testData);
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

        //-------------Found Tests---------------

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //bool variable to store validation results
            Boolean Found = false;
            //create some test data to use with the ethd
            Int32 bookId = 3;
            //invoke the method
            Found = aStock.Find(bookId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestbookIdFound()
        {
            //create an instance of te class we want to create
            clsStock aStock = new clsStock();
            //bool variable to store the search result
            Boolean Found = false;
            //bool variable to record if data is OK (assume yes)
            Boolean OK = true;
            //create some test data for the method
            Int32 bookId = 3;
            //invoke method
            Found = aStock.Find(bookId);
            //check bookId
            if (aStock.bookId != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestbookSearchesFound()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if data is OK (assume yes)
            Boolean OK = true;
            //create some test data for the method
            Int32 bookId = 3;
            //invoke the method
            Found = aStock.Find(bookId);
            //check the date
            if (aStock.bookSearches != Convert.ToString("Fantasy, L.Bardugo"))
            {
                OK = false;
            }
            //test to see that the result is true
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestbookDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if data is OK (assume yes)
            Boolean OK = true;
            //create some test data for the method
            Int32 bookId = 3;
            //invoke the method
            Found = aStock.Find(bookId);
            //check the date
            if (aStock.bookDescription != Convert.ToString("Six Of Crows"))
            {
                OK = false;
            }
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestpriceFound()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if data is OK (assume yes)
            Boolean OK = true;
            //create some test data for the method
            Int32 bookId = 3;
            //invoke the method
            Found = aStock.Find(bookId);
            //check the date
            if (aStock.price != Convert.ToDouble(17.40))
            {
                OK = false;
            }
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestavailableFound()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if data is OK (assume yes)
            Boolean OK = true;
            //create some test data for the method
            Int32 bookId = 3;
            //invoke the method
            Found = aStock.Find(bookId);
            //check the date
            if (aStock.available != true)
            {
                OK = false;
            }
            //test to see that the result is true
            Assert.IsTrue(OK);
        }
    

        [TestMethod]
        public void TestdayAddedFound()
        {
        //create an instance of the class we want to create
        clsStock aStock = new clsStock();
        //bool variable to store the result of the search
        Boolean Found = false;
        //bool variable to record if data is OK (assume yes)
        Boolean OK = true;
        //create some test data for the method
        Int32 bookId = 3;
        //invoke the method
        Found = aStock.Find(bookId);
        //check the date
        if (aStock.dayAdded != Convert.ToDateTime("17/02/2022"))
        {
            OK = false;
        }
        //test to see that the result is true
        Assert.IsTrue(OK);
        }

    }
}

       
