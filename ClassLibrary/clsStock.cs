using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private int bookID;
        private DateTime dateReceived;
        private String bookTitle;
        private bool bookAvailability;
        private int bookQuantity;
        public double bookPrice;

        public bool BookAvailability
        {
            get
            {
                return bookAvailability;
            }
            set
            {
                bookAvailability = value;
            }
        }
        public DateTime DateReceived
        {
            get
            {
                return dateReceived;
            }
            set
            {
                dateReceived = value;
            }
        }
        public int BookId
        {
            get
            {
                return bookID;
            }
            set
            {
                bookID = value;
            }
        }
        public string BookTitle
        {
            get
            {
                return bookTitle;
            }
            set
            {
                bookTitle = value;
            }
        }
        public int BookQuantity
        {
            get
            {
                return bookQuantity;
            }
            set
            {
                bookQuantity = value;
            }
        }
        public double BookPrice
        {
            get
            {
                return bookPrice;
            }
            set
            {
                bookPrice = value;
            }
        }

        public bool Find(int bookId)
        {
            bookID = 4;
            dateReceived = Convert.ToDateTime("25/02/2022");
            bookTitle = "Leadership";
            bookAvailability = true;
            bookQuantity = 100;
            bookPrice = 15.00;
            return true;
        }
    }
}