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

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            int bookId = 5;
            Found = ABook.Find(bookId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookFound()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Boolean OK = false;
            int bookId = 1;
            Found = ABook.Find(bookId);
            
            if(Found == true && ABook.BookId == bookId)
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateReceivedFound()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Boolean OK = false;
            int bookId = 1;
            Found = ABook.Find(bookId);
            DateTime dateReceived = Convert.ToDateTime("03/02/2022");

            if(Found == true && ABook.DateReceived == dateReceived)
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BookTitleFound()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Boolean OK = false;
            int bookId = 1;
            Found = ABook.Find(bookId);
            String bookTitle = "The Mammoth Book of CHESS";

            if(Found == true && ABook.BookTitle == bookTitle)
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BookAvailabilityFound()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Boolean OK = false;
            int bookId = 1;
            Found = ABook.Find(bookId);
            Boolean bookAvailability = true;

            if(Found == true && ABook.BookAvailability == bookAvailability)
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BookQuantityFound()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Boolean OK = false;
            int bookId = 1;
            Found = ABook.Find(bookId);
            int bookQuantity = 20;

            if(Found == true && ABook.BookQuantity == bookQuantity)
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BookPriceFound()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Boolean OK = false;
            int bookId = 1;
            Found = ABook.Find(bookId);
            double bookPrice = 12.5;

            if(Found == true && ABook.BookPrice == bookPrice)
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }
    }
}
