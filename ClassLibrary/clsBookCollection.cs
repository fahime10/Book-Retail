using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsBookCollection
    {
        //private data member for the list
        List<clsStock> bookList = new List<clsStock>();
        //private data member for ThisBook
        clsStock thisBook = new clsStock();

        public clsBookCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
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

        //public property for ThisBook
        public clsStock ThisBook
        {
            get
            {
                return thisBook;
            }
            set
            {
                thisBook = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisBook
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@BookTitle", thisBook.BookTitle);
            DB.AddParameter("@BookPrice", thisBook.BookPrice);
            DB.AddParameter("@BookAvailability", thisBook.BookAvailability);
            DB.AddParameter("@BookQuantity", thisBook.BookQuantity);
            DB.AddParameter("@DateReceived", thisBook.DateReceived);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisBook
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@BookId", thisBook.BookId);
            DB.AddParameter("@BookTitle", thisBook.BookTitle);
            DB.AddParameter("@BookPrice", thisBook.BookPrice);
            DB.AddParameter("@BookAvailability", thisBook.BookAvailability);
            DB.AddParameter("@BookQuantity", thisBook.BookQuantity);
            DB.AddParameter("@DateReceived", thisBook.DateReceived);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to thisBook
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@BookId", thisBook.BookId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByBookTitle(string BookTitle)
        {
            //filters the records based on a full or partial title
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the BookTitle parameter to the database
            DB.AddParameter("@BookTitle", BookTitle);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByBookTitle");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            bookList = new List<clsStock>();
            //while there are records to process
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
    }
}