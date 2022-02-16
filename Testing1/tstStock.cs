using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class required
            clsStock ABook = new clsStock();
            //test to see if it exists
            Assert.IsNotNull(ABook);
        }

        [TestMethod]
        public void BookIDPropertyOK()
        {
            clsStock ABook = new clsStock();
            int TestData = 1;
            ABook.BookId = TestData;
            Assert.AreEqual(ABook.BookId, TestData);
        }

        [TestMethod]
        public void BookTitlePropertyOK()
        {
            clsStock ABook = new clsStock();
            string TestData = "Leadership and Self-Deception";
            ABook.BookTitle = TestData;
            Assert.AreEqual(ABook.BookTitle, TestData);

        }

        [TestMethod]
        public void BookPricePropertyOK()
        {
            clsStock ABook = new clsStock();
            double TestData = 15.00;
            ABook.BookPrice = TestData;
            Assert.AreEqual(ABook.BookPrice, TestData);
        }

        [TestMethod]
        public void BookAvailabilityPropertyOK()
        {
            clsStock ABook = new clsStock();
            Boolean TestData = true;
            ABook.BookAvailability = TestData;
            Assert.AreEqual(ABook.BookAvailability, TestData);
        }

        [TestMethod]
        public void BookQuantityPropertyOK()
        {
            clsStock ABook = new clsStock();
            int TestData = 40;
            ABook.BookQuantity = TestData;
            Assert.AreEqual(ABook.BookQuantity, TestData);
        }

        [TestMethod]
        public void DateReceivedPropertyOK()
        {
            clsStock ABook = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            ABook.DateReceived = TestData;
            Assert.AreEqual(ABook.DateReceived, TestData);
        }
    }
}
