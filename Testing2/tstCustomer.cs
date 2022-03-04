using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void customerNoOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data
            Int32 testData = 5;
            //assign the data to the property
            AnCustomer.customerNo = testData;
            //test to see if the two values are the same
            Assert.AreEqual(AnCustomer.customerNo, testData);
        }

        [TestMethod]
        public void customerNameOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data
            String testData = "Williams, Ash";
            //assign the data to the property
            AnCustomer.CustomerName = testData;
            //test to see if the two values are the same
            Assert.AreEqual(AnCustomer.CustomerName, testData);
        }

        [TestMethod]
        public void customerAddressOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data
            String testData = "Gateway House, Leicester LE1 9BH";
            //assign the data to the property
            AnCustomer.customerAddress = testData;
            //test to see if the two values are the same
            Assert.AreEqual(AnCustomer.customerAddress, testData);
        }

        [TestMethod]
        public void hasAccountOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data
            Boolean testData = true;
            //assign the data to the property
            AnCustomer.hasAccount = testData;
            //test to see if the two values are the same
            Assert.AreEqual(AnCustomer.hasAccount, testData);
        }

        [TestMethod]
        public void creationDateOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data
            DateTime testData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.creationDate = testData;
            //test to see if the two values are the same
            Assert.AreEqual(AnCustomer.creationDate, testData);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assuming it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerNo = 123;
            //invoke the method
            Found = AnCustomer.Find(customerNo);
            //check the customer no
            if (AnCustomer.customerNo != 123)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //creates an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean varaible to record if data is OK (assuming it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerNo = 123;
            //invoke the method
            Found = AnCustomer.Find(customerNo);
            //check the name
            if (AnCustomer.CustomerName != Convert.ToString("Ash Williams"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //creates an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assuming it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerNo = 123;
            //invoke the method
            Found = AnCustomer.Find(customerNo);
            //check the address
            if (AnCustomer.customerAddress != Convert.ToString("10 Cloverfield Lane"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHasAccount()
        {
            //creates an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assuming it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerNo = 123;
            //invoke the method
            Found = AnCustomer.Find(customerNo);
            //check if account exists
            if (AnCustomer.hasAccount != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCreationDate()
        {
            //creates an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assuming it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerNo = 123;
            //invoke the method
            Found = AnCustomer.Find(customerNo);
            //check account creation date
            if (AnCustomer.creationDate != Convert.ToDateTime("02/02/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
