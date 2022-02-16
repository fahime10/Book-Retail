using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstBookStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class required
            clsBookStock ABookStock = new clsBookStock();
            //test to see if it exists
            Assert.IsNotNull(ABookStock);
        }

        [TestMethod]
        public void BookIDPropertyOK()
        {
            clsBookStock ABookStock = new clsBookStock();
            int TestData = 1;
            ABookStock.BookID = TestData;
            Assert.AreEqual(ABookStock.BookID, TestData);
        }

        [TestMethod]
        public void BookTitlePropertyOK()
        {
            clsBookStock ABookStock = new clsBookStock();
            string TestData = "Leadership and Self-Deception";
            ABookStock.BookTitle = TestData;
            Assert.AreEqual(ABookStock.BookTitle, TestData);

        }

        [TestMethod]
        public void BookPricePropertyOK()
        {
            clsBookStock ABookStock = new clsBookStock();
            double TestData = 15.00;
            ABookStock.BookPrice = TestData;
            Assert.AreEqual(ABookStock.BookPrice, TestData);
        }

        [TestMethod]
        public void BookAvailabilityPropertyOK()
        {
            clsBookStock ABookStock = new clsBookStock();
            Boolean TestData = true;
            ABookStock.BookAvailability = TestData;
            Assert.AreEqual(ABookStock.BookAvailability, TestData);
        }

        [TestMethod]
        public void BookQuantityPropertyOK()
        {
            clsBookStock ABookStock = new clsBookStock();
            int TestData = 40;
            ABookStock.BookQuantity = TestData;
            Assert.AreEqual(ABookStock.BookQuantity, TestData);
        }

        [TestMethod]
        public void DateReceivedPropertyOK()
        {
            clsBookStock ABookStock = new clsBookStock();
            DateTime TestData = DateTime.Now.Date;
            ABookStock.DateReceived = TestData;
            Assert.AreEqual(ABookStock.DateReceived, TestData);
        }
    }
}
