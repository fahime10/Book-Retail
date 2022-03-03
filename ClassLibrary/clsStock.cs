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

        public string Valid(string title, string price, string quantity, string dateReceived)
        {
            String Error = "";
            DateTime DateTemp;
            double cost;
            int number;
            
            if(title.Length == 0)
            {
                Error = Error + "The book title may not be blank : ";
            }

            if(title.Length > 50)
            {
                Error = Error + "The book title must be less than 51 characters : ";
            }


            try
            {
                cost = Convert.ToDouble(price);

                if (cost < 0.00)
                {
                    Error = Error + "The price cannot be lower than £0.00 : ";
                }

                if (cost > 1000.00)
                {
                    Error = Error + "The price cannot be more than £1000.00 : ";
                }
            }
            catch
            {
                Error = Error + "The price given was not a valid price : ";
            }


            try
            {
                number = Convert.ToInt32(quantity);

                if (number < 0)
                {
                    Error = Error + "The quantity cannot be less than 0 : ";
                }

                if (number > 200)
                {
                    Error = Error + "The quantity cannot be more than 200 : ";
                }
            }
            catch
            {
                Error = Error + "The quantity given is not a valid data type : ";
            }


            try
            {
                DateTemp = Convert.ToDateTime(dateReceived);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "Date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "Date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }


            return Error;
        }
    }
}