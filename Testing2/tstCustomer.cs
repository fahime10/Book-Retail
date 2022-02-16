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
            clsCustomer TheCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(TheCustomer);
        }

        [TestMethod]

        public void CustomerIDPropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            int TestData = 1;
            TheCustomer.CustomerID = TestData;
            Assert.AreEqual(TheCustomer.CustomerID, TestData);

        }

        [TestMethod]
        public void CustomerFirstNamePropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            string TestData = "Joe";
            TheCustomer.CustomerFirstName = TestData;
            Assert.AreEqual(TheCustomer.CustomerFirstName, TestData);

        }

        [TestMethod]
        public void CustomerLastNamePropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            string TestData = "Bloggs";
            TheCustomer.CustomerLastName = TestData;
            Assert.AreEqual(TheCustomer.CustomerLastName, TestData);
        }

        [TestMethod]

        public void CustomerAddressPropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            string TestData = "33 Tor Church Road, Torquay,TQ2 5UP";
            TheCustomer.CustomerAddress = TestData;
            Assert.AreEqual(TheCustomer.CustomerAddress, TestData);
        }

        [TestMethod]

        public void CustomerAccCreated()
        {
            clsCustomer TheCustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            TheCustomer.CustomerAccCreated = TestData;
            Assert.AreEqual(TheCustomer.CustomerAccCreated, TestData);
        }

        [TestMethod]

        public void ExistingAccPropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean TestData = true;
            TheCustomer.ExistingAcc = TestData;
            Assert.AreEqual(TheCustomer.ExistingAcc, TestData);
        }
    }
}
