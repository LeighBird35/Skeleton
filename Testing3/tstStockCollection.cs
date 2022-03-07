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
   
    }
}
