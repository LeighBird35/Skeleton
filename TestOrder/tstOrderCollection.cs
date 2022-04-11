using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
using TestOrder;

namespace Test_Framework
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void instanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that it exist
            Assert.IsNotNull(AllOrder);

        }

    }

    [TestMethod]
    public void CountPropertyOK()
    {
        //create an instance of the class we want to create
        clsOrderCollection AllOrder = new clsOrderCollection();
        //create some test data to the property
        AllOrder.Count = SomeCount;
        //test to see that the two value are the same
        Assert.AreEqual(AllOrder.Count, SomeCount);
    }

    [TestMethod]
    public void ThisOrderPropertyOK()
    {
        //create an instance of the class we want to create
        clsOrderCollection AllOrder = new clsOrderCollection();
        //create some test data to assign
        //in this case the data needs to be a list of objects
        List<clsOrder> TestList = new clsOrder();
        //set its properties
        TestItem.Active = true;
        TestItem.OrderID = 1;
        TestItem.OrderSearch = "waist belt";
        TestItem.OrderDelivery = "Rugby street";
        TestItem.OrderAddress = "My street, LE3 TY6";
        TestItem.OrderDate = DateTime.Now.Date;
        TestItem.OrderReturn = "Yours street, LE3 YS6";
        //asign the data to the property
        AllOrder.ThisOrder = TestOrder;
        //test to see that the two values are the same
        Assert.AreEqual(AllOrder.OrderList, TestList);
    }

    [TestMethod]
    public void OrderListOK()
    {
        //Create an instance of the class we want to create
        clsOrderCollection AllOrder = new clsOrderCollection();
        //create some test data to assign
        //in this case the data needs to be a list of objects
        List<clsOrder> TestList = new clsOrder();
        //set its properties
        TestItem.Active = true;
        TestItem.OrderID = 1;
        TestItem.OrderSearch = "waist belt";
        TestItem.OrderDelivery = "Rugby street";
        TestItem.OrderAddress = "My street, LE3 TY6";
        TestItem.OrderDate = DateTime.Now.Date;
        TestItem.OrderReturn = "Yours street, LE3 YS6";
        //add the item to the test list
        TestList.Add(TestItem);
        //asign the data to the property
        AllOrder.OrderList = TestList;
        //test to see that the two values are the same
        Assert.AreEqual(AllOrder.OrderList, TestList);
    }

    [TestMethod]
    public void ListAndCountOK()
    {
        //create an instance of the class we want to create
        clsOrderCollection AllOrder = new clsOrderCollection();
        //create some test data to assign
        //in this case the data needs to be a list of objects
        List<clsOrder> TestList = new clsOrder();
        //set its properties
        TestItem.Active = true;
        TestItem.OrderID = 1;
        TestItem.OrderSearch = "waist belt";
        TestItem.OrderDelivery = "Rugby street";
        TestItem.OrderAddress = "My street, LE3 TY6";
        TestItem.OrderDate = DateTime.Now.Date;
        TestItem.OrderReturn = "Yours street, LE3 YS6";
        //add the item to the test list
        TestList.Add(TestItem);
        //asign the data to the property
        AllOrder.OrderList = TestList;
        //test to see that the two values are the same
        Assert.AreEqual(AllOrder.CountList, TestList.Count);
    }
}
