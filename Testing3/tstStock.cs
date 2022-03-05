using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //created data to pass
        string bookSearches = "Fantasy, L.Bardugo";
        string bookDescription = "Six Of Crows";
        string price = "17.40";
        string dayAdded = DateTime.Now.Date.ToString();

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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create class instance
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //-----------------book searches validation --------------------

        [TestMethod]
        public void bookSearchesMinLessOne()
        {
            //create class instance
            clsStock aStock = new clsStock();
            //srting variable to store an error message
            String Error = "";
            //create some test data to pass to the method
            string bookSearches = ""; //should trigger an error
            //invoke method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void bookSearchesMin()
        {
            //create class instance
            clsStock aStock = new clsStock();
            //srting variable to store an error message
            String Error = "";
            //create some test data to pass to the method
            string bookSearches = "a"; 
            //invoke method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void bookSearchesMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string bookSearches = "aa"; //this should be ok
            //invoke the method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void bookSearchesExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string bookSearches = "";
            bookSearches = bookSearches.PadRight(10000, 'a');
            //invoke the method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        //---------------book description validation -------------

        [TestMethod]
        public void bookDescriptionMinLessOne()
        {
            //create class instance
            clsStock aStock = new clsStock();
            //srting variable to store an error message
            String Error = "";
            //create some test data to pass to the method
            string bookSearches = ""; //should trigger an error
            //invoke method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void bookDescriptionMin()
        {
            //create class instance
            clsStock aStock = new clsStock();
            //srting variable to store an error message
            String Error = "";
            //create some test data to pass to the method
            string bookSearches = "a";
            //invoke method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void bookDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string bookSearches = "aa"; //this should be ok
            //invoke the method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void bookDescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string bookSearches = "";
            bookSearches = bookSearches.PadRight(10000, 'a');
            //invoke the method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        //--------------------price validation-----------------
        [TestMethod]
        public void priceExtremeMin()
        {
            //create a class instance
            clsStock aStock = new clsStock();
            //string variable to store error message
            String Error = "";
            //create a variable to store the test data
            Double TestPrice;
            //set price to extream min
            TestPrice = -1000000.00;
            //convert the dto a string variable
            string price = TestPrice.ToString();
            //invoke method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void priceMinLessOne()
        {
            //create a class instance
            clsStock aStock = new clsStock();
            //string variable to store error message
            String Error = "";
            //create a variable to store the test data
            Double TestPrice;
            //set price to extream min
            TestPrice = -00.01;
            //convert the dto a string variable
            string price = TestPrice.ToString();
            //invoke method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void priceMin()
        {
            //create a class instance
            clsStock aStock = new clsStock();
            //string variable to store error message
            String Error = "";
            //create a variable to store the test data
            Double TestPrice;
            //set price to extream min
            TestPrice = 00.00;
            //convert the dto a string variable
            string price = TestPrice.ToString();
            //invoke method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void priceMinAddOne()
        {
            //create a class instance
            clsStock aStock = new clsStock();
            //string variable to store error message
            String Error = "";
            //create a variable to store the test data
            Double TestPrice;
            //set price to extream min
            TestPrice = 00.01;
            //convert the dto a string variable
            string price = TestPrice.ToString();
            //invoke method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void priceExtremeMax()
        {
            //create a class instance
            clsStock aStock = new clsStock();
            //string variable to store error message
            String Error = "";
            //create a variable to store the test data
            Double TestPrice;
            //set price to extream min
            TestPrice = 1000000.00;
            //convert the dto a string variable
            string price = TestPrice.ToString();
            //invoke method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void priceInvalidData()
        {
              //create class instance
              clsStock aStock = new clsStock();
              //string variable to store any error message
              String Error = "";
              //set the to non price value
              string price = "this is not a price!";
              //invoke the method
              Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
              //test to see that the result is correct
              Assert.AreNotEqual(Error, "");          
        }

        //------------------day added validation--------------
        [TestMethod]
        public void dayAddedExtremeMin()
        {
            //create a class instance
            clsStock aStock = new clsStock();
            //string variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set date to todays daye
            TestDate = DateTime.Now.Date;
            //change date to whatever is 100 years less
            TestDate = TestDate.AddYears(-100);
            //convert the date to a string variable
            string dayAdded = TestDate.ToString();
            //invoke method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()

        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string dayAdded = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()

        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string dayAdded = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()

        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string dayAdded = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()

        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string dayAdded = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dayAddedInvalidData()
        {
            //create class instance
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the dayAdded to a non date value
            string dayAdded = "this is not a date!";
            //invoke the method
            Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }






    }
}

       
