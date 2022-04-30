using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestOrder
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollections AllOrder = new clsOrderCollections();
            //test to see that it exists
            Assert.IsNotNull(AllOrder);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            //create an nstance of the class we want to create
            clsOrderCollections AllOrder = new clsOrderCollections();
            //create some test data t assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllOrder.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, SomeCount);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class
            clsOrderCollections AllOrder = new clsOrderCollections();
            //create some test data 
            //in this case a list
            List<clsOrder> TestList = new List<clsOrder>();
            //add item to list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties       
            TestItem.OrderID = 3;
            TestItem.OrderAddress = "Yours Town, YS5 TN9";
            TestItem.OrderReturn = "My town, MY5 TN7";
            TestItem.OrderSearch = true;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderDelivery = true;
            TestItem.Active = true;
            //add item to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.OrderList, TestList);
        }



        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create a class instance
            clsOrderCollections AllOrder = new clsOrderCollections();
            //create some test data to add to the property
            clsOrder TestOrder = new clsOrder();
            //set object properties
            TestOrder.OrderID = 3;
            TestOrder.OrderAddress = "Yours Town, YS5 TN9";
            TestOrder.OrderReturn = "My town, MY5 TN7";
            TestOrder.OrderSearch = true;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderDelivery = true;
            TestOrder.Active = true;
            //assign data to the property
            AllOrder.ThisOrder = TestOrder;
            //test to see if two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Crearte a class instance
            clsOrderCollections AllOrder = new clsOrderCollections();
            // create some test data
            //in this case a list
            List<clsOrder> TestList = new List<clsOrder>();
            //add item to list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties       
            TestItem.OrderID = 3;
            TestItem.OrderAddress = "Yours Town, YS5 TN9";
            TestItem.OrderReturn = "My town, MY5 TN7";
            TestItem.OrderSearch = true;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderDelivery = true;
            TestItem.Active = true;
            //add item to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of the class
            clsOrderCollections AllOrder = new clsOrderCollections();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 123;
            TestItem.OrderAddress = "Head Town HA6 OW9 ";
            TestItem.OrderReturn = "Toe Street OE3 EE3";
            TestItem.OrderSearch = true;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderDelivery = true;
            TestItem.Active = true;
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsOrderCollections AllOrder = new clsOrderCollections();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its propertires           
            TestItem.OrderSearch = true;
            TestItem.OrderAddress = "same street, SM4 ST9";
            TestItem.OrderReturn = "another town, AR5 TN0";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderDelivery = true;
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data      
            TestItem.OrderSearch = true;
            TestItem.OrderAddress = "another street, AE5 SE5";
            TestItem.OrderReturn = "Samson town, SN1 TN5";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderDelivery = false;
            //set the record based on the new test data
            AllOrder.ThisOrder = TestItem;
            //update the record
            AllOrder.Update();
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see if ThisOrder matches the test data
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsOrderCollections AllOrder = new clsOrderCollections();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.OrderID = 101;
            TestItem.OrderSearch = true;
            TestItem.OrderAddress = "aaaaaaaaaaaa";
            TestItem.OrderReturn = "aa aa aa";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderDelivery = true;
            //set this Order to the test data
            AllOrder.ThisOrder = TestItem;
            //add record
            PrimaryKey = AllOrder.Add();
            //set primary key of test data 
            TestItem.OrderID = PrimaryKey;
            //find record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //deleted the record
            AllOrder.Delete();
            //find the record
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see if found
            Assert.IsFalse(Found);
        }


        [TestMethod]
        public void ReportByOrderAddressMethodOK()
        {
            //create instance of the class containing unfiltered results
            clsOrderCollections AllOrder = new clsOrderCollections();
            //create an instanse of the filtered data
            clsOrderCollections FilteredOrder = new clsOrderCollections();
            //apply a blank strinf (should return all records)
            FilteredOrder.ReportByOrderAddress("");
            //test to see two values are the same
            Assert.AreEqual(AllOrder.Count, FilteredOrder.Count);
        }

        [TestMethod]
        public void ReportByOrderAddressNoneFound()
        {
            //create instance of filtered data
            clsOrderCollections FilteredOrder = new clsOrderCollections();
            //apply a product that doesnt exist
            FilteredOrder.ReportByOrderAddress("xxx xxx");
            //test to see that there is no record
            Assert.AreEqual(0, FilteredOrder.Count);
        }

        [TestMethod]
        public void ReportByOrderAddressTestDataFound()
        {
            //create an instance of the filterted data
            clsOrderCollections FilteredOrder = new clsOrderCollections();
            //var to store outcome
            Boolean OK = true;
            //apply a product that doesnt exist
            FilteredOrder.ReportByOrderAddress("yyy yyy");
            //check that the correct number of records are found
            if (FilteredOrder.Count == 1)
            {
                //check that the record is ID 11
                if (FilteredOrder.OrderList[0].OrderID != 11)
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

