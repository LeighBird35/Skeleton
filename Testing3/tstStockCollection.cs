using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {  
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsStockCollection allStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(allStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class
            clsStockCollection allStock = new clsStockCollection();
            //create some test data 
            //in this case a list
            List<clsStock> TestList = new List<clsStock>();
            //add item to list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties       
            TestItem.bookId = 3;
            TestItem.bookSearches = "Fantasy, L.Bardugo";
            TestItem.bookDescription = "Six Of Crows";
            TestItem.price = 17.40;
            TestItem.dayAdded = DateTime.Now.Date;
            TestItem.available = true;

            //add item to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            allStock.stockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allStock.stockList, TestList);
        }


        [TestMethod]
        public void ThisStockOK()
        {
            //CREATE CLASS INSTANCE
            clsStockCollection allStock = new clsStockCollection();
            //create some test data to add to the property
            clsStock TestStock = new clsStock();
            //set object properties
            TestStock.bookId = 3;
            TestStock.bookSearches = "Fantasy, L.Bardugo";
            TestStock.bookDescription = "Six Of Crows";
            TestStock.price = 17.40;
            TestStock.dayAdded = DateTime.Now.Date;
            TestStock.available = true;
            //assign data to the property
            allStock.ThisStock = TestStock;
            //test to see if two values are the same
            Assert.AreEqual(allStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Crearte a class instance
            clsStockCollection allStock = new clsStockCollection();
            // create some test data
            //in this case a list
            List<clsStock> TestList = new List<clsStock>();
            //add item to list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties       
            TestItem.bookId = 3;
            TestItem.bookSearches = "Fantasy, L.Bardugo";
            TestItem.bookDescription = "Six Of Crows";
            TestItem.price = 17.40;
            TestItem.dayAdded = DateTime.Now.Date;
            TestItem.available = true;

            //add item to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            allStock.stockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of the class
            clsStockCollection allStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.bookId = 9;
            TestItem.bookSearches = "genre, authour";
            TestItem.bookDescription = "title";
            TestItem.price = 18.20;
            TestItem.dayAdded = DateTime.Now.Date;
            TestItem.available = true;
            //set ThisStock to the test data
            allStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = allStock.Add();
            //set primary key of the test data
            TestItem.bookId = PrimaryKey;
            //find the record
            allStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsStockCollection allStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its propertires           
            TestItem.bookSearches = "genre, authour";
            TestItem.bookDescription = "title";
            TestItem.price = 18.20;
            TestItem.dayAdded = DateTime.Now.Date;
            TestItem.available = true;
            //set ThisStock to the test data
            allStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = allStock.Add();
            //set the primary key of the test data
            TestItem.bookId = PrimaryKey;
            //modify the test data      
            TestItem.bookSearches = "other genre, other authour";
            TestItem.bookDescription = "other title";
            TestItem.price = 18.20;
            TestItem.dayAdded = DateTime.Now.Date;
            TestItem.available = false;
            //set the record based on teh new test data
            allStock.ThisStock = TestItem;
            //update the record
            allStock.Update();
            //find the record
            allStock.ThisStock.Find(PrimaryKey);
            //test to see if ThisStock matches the test data
            Assert.AreEqual(allStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsStockCollection allStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.bookId = 1;
            TestItem.bookSearches = "aaaaaa";
            TestItem.bookDescription = "aaaaaaaaaaaa";
            TestItem.price = 13.25;
            TestItem.dayAdded = DateTime.Now.Date;
            TestItem.available = true;
            //set this stock to the test data
            allStock.ThisStock = TestItem;
            //add record
            PrimaryKey = allStock.Add();
            //set primary key of test data 
            TestItem.bookId = PrimaryKey;
            //find record
            allStock.ThisStock.Find(PrimaryKey);
            //deleted the record
            allStock.Delete();
            //find the record
            Boolean Found = allStock.ThisStock.Find(PrimaryKey);
            //test to see if found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByBookDescriptionMethodOK()
        {
            //create instance of the class containing unfiltered results
            clsStockCollection allStock = new clsStockCollection();
            //create an instanse of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank strinf (should return all records)
            FilteredStock.ReportBybookDescription("");
            //test to see two values are the same
            Assert.AreEqual(allStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportBybookDescriptionNoneFound()
        {
            //create instance of filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a title that doesnt exist
            FilteredStock.ReportBybookDescription("aaaa aaaa aa");
            //test to see that there is no record
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportBybookDescriptionTestDataFound()
        {
            //create an instance of the filterted data
            clsStockCollection FilteredStock = new clsStockCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a book title that doesnt exist
            FilteredStock.ReportBybookDescription("Geralds Game");
            //check that the correct number of records are found
            if (FilteredStock.Count == 1)
            { 
                //check that the record is ID 11
                if (FilteredStock.stockList[0].bookId != 11)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
            //Assert.IsTrue(OK);
        }

    }
}
