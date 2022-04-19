using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        string CustomerFirstName = "Joe";
        string CustomerLastName = "Bloggs";
        string CustomerAddress = "33 Tor Church Road, Torquay,TQ2 5UP";
        string CustomerAccountCreated = DateTime.Now.Date.ToString();

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

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 1;
            Found = TheCustomer.Find(CustomerID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = TheCustomer.Find(CustomerID);
            if (TheCustomer.CustomerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerAccCreatedFound()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = TheCustomer.Find(CustomerID);
            if (TheCustomer.CustomerAccCreated != Convert.ToDateTime("05/10/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerFirstNameFound()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = TheCustomer.Find(CustomerID);
            if (TheCustomer.CustomerFirstName != "Joe")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomerLastNameFound()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = TheCustomer.Find(CustomerID);
            if (TheCustomer.CustomerLastName != "Bloggs")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomerAddressFound()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = TheCustomer.Find(CustomerID);
            if (TheCustomer.CustomerAddress != "33 Tor Church Road, Torquay,TQ2 5UP")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestExistingAccFound()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = TheCustomer.Find(CustomerID);
            if (TheCustomer.ExistingAcc != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerFirstNameMinLessOne()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "";
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMin()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "a";
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "aa";
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxLessOne()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(24, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMax()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(25, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(26, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMid()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(13, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstExtremeMax()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(100000, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreNotEqual(Error, "");
        }
       
        [TestMethod]
        public void CustomerLastNameMinLessOne()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "";
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void CustomerLastNameMin()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "a";
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMinPlusOne()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "aa";
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxLessOne()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "";
            CustomerLastName = CustomerLastName.PadRight(24, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMax()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "";
            CustomerLastName = CustomerLastName.PadRight(25, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxPlusOne()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "";
            CustomerLastName = CustomerLastName.PadRight(26, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMid()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "";
            CustomerLastName = CustomerLastName.PadRight(13, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameExtremeMax()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerLastName = "";
            CustomerLastName = CustomerLastName.PadRight(100000, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "a";
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "aa";
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(49, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMax()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(50, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(51, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMid()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(25, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(100000, 'a');
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAccountCreatedExtremeMin()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-500);
            string CustomerAccountCreated = TestDate.ToString();
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAccountCreatedMinLessOne()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string CustomerAccountCreated = TestDate.ToString();
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAccountCreatedMin()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string CustomerAccountCreated = TestDate.ToString();
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAccountCreatedMinPlusOne()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string CustomerAccountCreated = TestDate.ToString();
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAccountCreatedExtremeMax()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1000);
            string CustomerAccountCreated = TestDate.ToString();
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAccountCreatedInvalidData()
        {
            clsCustomer TheCustomer = new clsCustomer();
            String Error = "";
            string CustomerAccountCreated = "this is not a valid date";
            Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
            Assert.AreNotEqual(Error, "");
        }

    }
}
