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

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerID = 4;
            TestItem.CustomerFirstName = "Joe";
            TestItem.CustomerLastName = "Ice";
            TestItem.CustomerAddress = "otherplace somewhere";
            TestItem.CustomerAccCreated = DateTime.Now.Date;
            TestItem.ExistingAcc = true;
            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerFirstName = "Jane";
            TestItem.CustomerLastName = "Stone";
            TestItem.CustomerAccCreated = DateTime.Now.Date;
            TestItem.CustomerAddress = "Test place";
            TestItem.ExistingAcc = true;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            TestItem.CustomerFirstName = "Alex";
            TestItem.CustomerLastName = "Wood";
            TestItem.CustomerAccCreated = DateTime.Now.Date;
            TestItem.CustomerAddress = "Different test place";
            TestItem.ExistingAcc = false;
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerID = 1;
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "glass";
            TestItem.CustomerAddress = "some place some where";
            TestItem.CustomerAccCreated = DateTime.Now.Date;
            TestItem.ExistingAcc = true;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]

        public void ReportByFirstNameOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByFirstName("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]

        public void ReportByFirstNameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByFirstName("xxx xxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]

        public void ReportByFirstNameDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByFirstName("Eric");
            if (FilteredCustomers.Count == 2)
            {
                if (FilteredCustomers.CustomerList[0].CustomerID != 28)
                {
                    OK = false;
                }

                if (FilteredCustomers.CustomerList[1].CustomerID != 35)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
