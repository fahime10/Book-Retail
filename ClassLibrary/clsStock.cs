using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private int bookId;
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
                return bookId;
            }
            set
            {
                bookId = value;
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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookId", bookId);
            DB.Execute("sproc_tblStock_FilterByBookId");

            if(DB.Count == 1)
            {
                this.bookId = Convert.ToInt32(DB.DataTable.Rows[0]["BookId"]);
                bookTitle = Convert.ToString(DB.DataTable.Rows[0]["BookTitle"]);
                bookPrice = Convert.ToDouble(DB.DataTable.Rows[0]["BookPrice"]);
                bookAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["BookAvailability"]);
                bookQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["BookQuantity"]);
                dateReceived = Convert.ToDateTime(DB.DataTable.Rows[0]["DateReceived"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}