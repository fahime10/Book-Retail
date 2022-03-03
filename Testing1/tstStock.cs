using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        //some test data
        string title = "Leadership";
        string price = "15.00";
        string quantity = "40";
        string dateReceived = DateTime.Now.Date.ToString();

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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Error = ABook.Valid(title, price, quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleMinLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            String Title = "";
            Error = ABook.Valid(Title, price, quantity, dateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleMin()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            String Title = "A";
            Error = ABook.Valid(Title, price, quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BoookTitleMinPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            String Title = "AA";
            Error = ABook.Valid(Title, price, quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleMaxLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            String Title = "";
            Title = Title.PadRight(49, 'A');
            Error = ABook.Valid(Title, price, quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleMax()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            String Title = "";
            Title = Title.PadRight(50, 'A');
            Error = ABook.Valid(Title, price, quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleMid()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            String Title = "";
            Title = Title.PadRight(25, 'A');
            Error = ABook.Valid(Title, price, quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleMaxPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            String Title = "";
            Title = Title.PadRight(51, 'A');
            Error = ABook.Valid(Title, price, quantity, dateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleExtremeMax()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            String Title = "";
            Title = Title.PadRight(200, 'A');
            Error = ABook.Valid(Title, price, quantity, dateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateReceivedExtremeMin()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateReceived = TestDate.ToString();
            Error = ABook.Valid(title, price, quantity, DateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateReceivedMinLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateReceived = TestDate.ToString();
            Error = ABook.Valid(title, price, quantity, DateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateReceivedMin()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateReceived = TestDate.ToString();
            Error = ABook.Valid(title, price, quantity, DateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateReceivedMinPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateReceived = TestDate.ToString();
            Error = ABook.Valid(title, price, quantity, DateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateReceivedExtremeMax()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateReceived = TestDate.ToString();
            Error = ABook.Valid(title, price, quantity, DateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateReceivedInvalidData()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string DateReceived = "This is not a date!";
            Error = ABook.Valid(title, price, quantity, DateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceExtremeMin()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            double cost = -10000.00;
            string Price = cost.ToString();
            Error = ABook.Valid(title, Price, quantity, dateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceMinLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            double cost = -0.01;
            string Price = cost.ToString();
            Error = ABook.Valid(title, Price, quantity, dateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceMin()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            double cost = 0.00;
            string Price = cost.ToString();
            Error = ABook.Valid(title, Price, quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceMinPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            double cost = 0.01;
            string Price = cost.ToString();
            Error = ABook.Valid(title, Price, quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceMaxLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            double cost = 999.99;
            string Price = cost.ToString();
            Error = ABook.Valid(title, Price, quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceMax()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            double cost = 1000.00;
            string Price = cost.ToString();
            Error = ABook.Valid(title, Price, quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceMaxPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            double cost = 1000.01;
            string Price = cost.ToString();
            Error = ABook.Valid(title, Price, quantity, dateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceMid()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            double cost = 500.00;
            string Price = cost.ToString();
            Error = ABook.Valid(title, Price, quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceExtremeMax()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            double cost = 10000.00;
            string Price = cost.ToString();
            Error = ABook.Valid(title, Price, quantity, dateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceInvalidDataType()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string Price = "Invalid data type!";
            Error = ABook.Valid(title, Price, quantity, dateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookQuantityExtremeMin()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            int number = -10000;
            string Quantity = number.ToString();
            Error = ABook.Valid(title, price, Quantity, dateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookQuantityMinLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            int number = 0;
            string Quantity = number.ToString();
            Error = ABook.Valid(title, price, Quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookQuantityMin()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            int number = 1;
            string Quantity = number.ToString();
            Error = ABook.Valid(title, price, Quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookQuantityMinPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            int number = 2;
            string Quantity = number.ToString();
            Error = ABook.Valid(title, price, Quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookQuantityMaxLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            int number = 199;
            string Quantity = number.ToString();
            Error = ABook.Valid(title, price, Quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookQuantityMax()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            int number = 200;
            string Quantity = number.ToString();
            Error = ABook.Valid(title, price, Quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookQuantityMaxPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            int number = 201;
            string Quantity = number.ToString();
            Error = ABook.Valid(title, price, Quantity, dateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookQuantityMid()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            int number = 100;
            string Quantity = number.ToString();
            Error = ABook.Valid(title, price, Quantity, dateReceived);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookQuantityExtremeMax()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            int number = 10000;
            string Quantity = number.ToString();
            Error = ABook.Valid(title, price, Quantity, dateReceived);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookQuantityInvalidDataType()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string Quantity = "Invalid integer!";
            Error = ABook.Valid(title, price, Quantity, dateReceived);
            Assert.AreNotEqual(Error, "");
        }
    }
}
