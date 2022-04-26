using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Framework
{
    [TestClass]
   public class tstOrderCollection
   { 
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderConnection AllOrder = new clsOrderConnection();
            //test to see that it exist
            Assert.IsNotNull(AllOrder);
        }
   }

    [TestMethod]
    public void OrderListOK()
    {
        //create an instance of he class we want to create
        clsOrderConnection AllOrder = new clsOrderConnection();
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
}
