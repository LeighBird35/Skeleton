using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {

        //good test data
        //created test data to pass valid method
        string customerNo = "2";
        string customerAddress = "60 Klaatu Road";
        string customerName = "Ash Williams";
        string hasAccount = "True";
        string creationDate = DateTime.Now.Date.ToString();


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
            AnCustomer.customerName = testData;
            //test to see if the two values are the same
            Assert.AreEqual(AnCustomer.customerName, testData);
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
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
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
            Int32 customerNo = 1;
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
            Int32 customerNo = 2;
            //invoke the method
            Found = AnCustomer.Find(customerNo);
            //check the name
            if (AnCustomer.customerName != Convert.ToString("Ash Williams"))
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
            Int32 customerNo = 3;
            //invoke the method
            Found = AnCustomer.Find(customerNo);
            //check the address
            if (AnCustomer.customerAddress != Convert.ToString("52 Somewhere Road"))
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
            Int32 customerNo = 1;
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
            Int32 customerNo = 1;
            //invoke the method
            Found = AnCustomer.Find(customerNo);
            //check account creation date
            if (AnCustomer.creationDate != Convert.ToDateTime("08/02/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void creationDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //string variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string creationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void creationDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string creationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid( customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void creationDateMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string creationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void creationDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string creationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void creationDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //string variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string creationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void creationDateInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            string creationDate = "this is not a date!";
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void customerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string customerName = "";
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void customerNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string customerName = "A";
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void customerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string customerName = "AB";
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void customerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string customerName = "";
            customerName = customerName.PadRight(49, 'A');
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void customerNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string customerName = "";
            customerName = customerName.PadRight(50, 'A');
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void customerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string customerName = "";
            customerName = customerName.PadRight(51, 'A');
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void customerNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string customerName = "";
            customerName = customerName.PadRight(25, 'A');
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void customerNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string customerName = "";
            customerName = customerName.PadRight(500, 'A');
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void customerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string customerAddress = "";
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void customerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string customerAddress = "A";
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void customerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string customerAddress = "AB";
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void customerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string customerAddress = "";
            customerAddress = customerAddress.PadRight(99, 'A');
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void customerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string customerAddress = "";
            customerAddress = customerAddress.PadRight(100, 'A');
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void customerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string customerName = "";
            customerName = customerName.PadRight(101, 'A');
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void customerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string customerAddress = "";
            customerAddress = customerAddress.PadRight(50, 'A');
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void customerAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string customerAddress = "";
            customerAddress = customerAddress.PadRight(1000, 'A');
            //invoke the method
            Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


    }
}
