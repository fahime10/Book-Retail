using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsBookCollection
    {
        //private data member for the list
        List<clsStock> bookList = new List<clsStock>();

        public clsBookCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are record to process
            while(Index < RecordCount)
            {
                //create a blank book
                clsStock ABook = new clsStock();
                //read in the fields from the current record
                ABook.BookId = Convert.ToInt32(DB.DataTable.Rows[Index]["BookId"]);
                ABook.BookTitle = Convert.ToString(DB.DataTable.Rows[Index]["BookTitle"]);
                ABook.BookPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["BookPrice"]);
                ABook.BookQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["BookQuantity"]);
                ABook.BookAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["BookAvailability"]);
                ABook.DateReceived = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateReceived"]);
                //add the record to the private data member
                bookList.Add(ABook);
                //point at the next record
                Index++;
            }
        }

        //public property for the list
        public List<clsStock> BookList
        {
            get
            {
                //return the private data
                return bookList;
            }
            set
            {
                //set the private data
                bookList = value;
            }
        }

        //public property for the count
        public int Count
        {
            get
            {
                //return the count of the list
                return bookList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisBook { get; set; }
    }
}