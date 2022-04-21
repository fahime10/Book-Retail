using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            Assert.IsNotNull(AllCustomers);

        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.ExistingAcc = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerFirstName = "Joe";
            TestItem.CustomerLastName = "Bloggs";
            TestItem.CustomerAddress = "33 Tor Church Road, Torquay,TQ2 5UP";
            TestItem.CustomerAccCreated = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.ExistingAcc = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerFirstName = "Joe";
            TestCustomer.CustomerLastName = "Bloggs";
            TestCustomer.CustomerAddress = "33 Tor Church Road, Torquay,TQ2 5UP";
            TestCustomer.CustomerAccCreated = DateTime.Now.Date;
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerID = 1;
            TestItem.CustomerFirstName = "Joe";
            TestItem.CustomerLastName = "Bloggs";
            TestItem.CustomerAddress = "33 Tor Church Road, Torquay,TQ2 5UP";
            TestItem.CustomerAccCreated = DateTime.Now.Date;
            TestItem.ExistingAcc = true;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }


    }
}
