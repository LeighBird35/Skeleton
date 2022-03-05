using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        public object AStaffMember { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaffMember = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaffMember);
        }

        [TestMethod]
        public void AvaliableStaffOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaffMember = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            AStaffMember.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaffMember.Active, TestData);
        }

        [TestMethod]
        public void DobStaffOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaffMember = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AStaffMember.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaffMember.DateAdded, TestData);
        }

        [TestMethod]
        public void StaffNoOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaffMember = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 3;
            //assign the data to the property
            AStaffMember.StaffNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaffMember.StaffNo, TestData); 
        }

        [TestMethod]
        public void StaffNameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "luke Corbett";
            //assign the data to the property
            AStaffMember.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaffMember.StaffName, TestData);
        }

        [TestMethod]
        public void StaffDesc()
        {
            //create an instance of the class we want to create
            clsStaff AStaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "luke Corbett";
            //assign the data to the property
            AStaffMember.StaffDesc = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaffMember.StaffDesc, TestData);
        }

        [TestMethod]
        public void StaffWage()
        {
            //create an instance of the class we want to create
            clsStaff AStaffMember = new clsStaff();
            //create some test data to assign to the property
            Double TestData = 25.50;
            //assign the data to the property
            AStaffMember.StaffWage = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaffMember.StaffWage, TestData);
        }


    }
}