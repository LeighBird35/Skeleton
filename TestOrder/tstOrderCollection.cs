using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOrder;

namespace Test_Framework
{
    [TestClass]
   public class tstOrderCollection
   { 
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that it exist
            Assert.IsNotNull(AllOrder);
        }
   }

    [TestMethod]
    public void OrderListOK()
    {
        //create an instance of he class we want to create
        clsOrderCollection AllOrder = new clsOrderCollection();
        //create some test data to assign to the property
        //in ths case the data needs to be a list of objects
        List<clsOrder> TestList = new List<clsOrder>();
        //add an item to the list
        //create the item of test data
        clsOrder TestItem = new clsOrder();
        //set its properties
        TestItem.Active = true;
        TestItem.OrderID = 234;
        TestItem.OrderReturn = "My town, MY5 TN7";
        TestItem.OrderDelivery = true;
        TestItem.OrderAddress = "Yours Town, YS5 TN9";
        TestItem.OrderSearch = true;
        TestItem.OrderDate = DateTime.Now.Date;
        //add the items to the test list
        TestList.Add(TestItem);
        //assign the data to the property
        AllOrder.OrderList = TestList;
        //test to see that the two values are the same
        Assert.AreEqual(AllOrder.OrderList, TestList);
    }

    [TestMethod]
    public void ThisOrderOK()
    {
        //create class instance
        clsOrderCollection AllOrder = new clsOrderCollection();
        //create some test data to add to the property
        clsOrder TestOrder = new clsOrder();
        //set object properties
        TestOrder.OrderID = 3;
        TestOrder.OrderAddress = "Yours Town, YS5 TN9";
        TestOrder.OrderReturn= "My town, MY5 TN7";
        TestOrder.OrderSearch = true;
        TestOrder.OrderDate = DateTime.Now.Date;
        TestOrder.OrderDelivery = true;
        //assign data to the property
        AllOrder.ThisOrder = TestOrder;
        //test to see if two values are the same
        Assert.AreEqual(AllOrder.ThisOrder, TestOrder);
    }

    [TestMethod]
    public void ListAndCountOK()
    {
        //Create a class instance
        clsOrderCollection AllOrder = new clsOrderCollection();
        // create some test data
        //in this case a list
        List<clsOrder> TestList = new List<clsOrder>();
        //add item to list
        //create the item of test data
        clsOrder TestItem = new clsOrder();
        //set its properties       
        TestItem.OrderID = 300;
        TestItem.OrderAddress = "Yours Town, YS5 TN9";
        TestItem.OrderReturn = "My town, MY5 TN7";
        TestItem.OrderSearch = true;
        TestItem.OrderDate = DateTime.Now.Date;
        TestItem.OrderDelivery = true;

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
        clsOrderCollection AllOrder = new clsOrderCollection();
        //create the item of test data
        clsOrder TestItem = new clsOrder();
        //var to store the primary key
        Int32 PrimaryKey = 0;
        //set its properties
        TestItem.OrderID = 8;
        TestItem.OrderSearch = true;
        TestItem.OrderAddress = "same street, SM4 ST9";
        TestItem.OrderReturn = "another town, AR5 TN0";
        TestItem.OrderDate = DateTime.Now.Date;
        TestItem.OrderDelivery = true;
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
        clsOrderCollection AllOrder = new clsOrderCollection();
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
        clsOrderCollection AllOrder = new clsOrderCollection();
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
        clsOrderCollection AllOrder = new clsOrderCollection();
        //create an instanse of the filtered data
        clsOrderCollection FilteredOrder = new clsOrderCollection();
        //apply a blank strinf (should return all records)
        FilteredOrder.ReportByOrderAddress("");
        //test to see two values are the same
        Assert.AreEqual(AllOrder.Count, FilteredOrder.Count);
    }

    [TestMethod]
    public void ReportByOrderAddressNoneFound()
    {
        //create instance of filtered data
        clsOrderCollection FilteredOrder = new clsOrderCollection();
        //apply a product that doesnt exist
        FilteredOrder.ReportByOrderAddress(false);
        //test to see that there is no record
        Assert.AreEqual(0, FilteredOrder.Count);
    }

    [TestMethod]
    public void ReportByOrderAddressTestDataFound()
    {
        //create an instance of the filterted data
        clsOrderCollection FilteredOrder = new clsOrderCollection();
        //var to store outcome
        Boolean OK = true;
        //apply a product that doesnt exist
        FilteredOrder.ReportByOrderAddress(true);
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

