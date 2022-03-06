using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstBookCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of clsBookCollection
            clsBookCollection AllBooks = new clsBookCollection();
            //test to see that exists
            Assert.IsNotNull(AllBooks);
        }

        [TestMethod]
        public void BookListOK()
        {
            //create an instance of clsBookCollection
            clsBookCollection AllBooks = new clsBookCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.BookId = 1;
            TestItem.BookTitle = "Chess";
            TestItem.BookPrice = 15.00;
            TestItem.BookAvailability = true;
            TestItem.BookQuantity = 20;
            TestItem.DateReceived = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllBooks.BookList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllBooks.BookList, TestList);
        }

        [TestMethod]
        public void ThisBookPropertyOK()
        {
            //create an instance of clsBookCollection
            clsBookCollection AllBooks = new clsBookCollection();
            //create some test data to assign to the property
            clsStock TestBook = new clsStock();
            //set the properties of the test object
            TestBook.BookId = 1;
            TestBook.BookTitle = "Chess";
            TestBook.BookPrice = 15.00;
            TestBook.BookQuantity = 20;
            TestBook.BookAvailability = true;
            TestBook.DateReceived = DateTime.Now.Date;
            //assign the data to the property
            AllBooks.ThisBook = TestBook;
            //test to see that the two values are the same
            Assert.AreEqual(AllBooks.ThisBook, TestBook);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of clsBookCollection
            clsBookCollection AllBooks = new clsBookCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.BookId = 1;
            TestItem.BookTitle = "Chess";
            TestItem.BookPrice = 15.00;
            TestItem.BookQuantity = 20;
            TestItem.BookAvailability = true;
            TestItem.DateReceived = DateTime.Now.Date;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllBooks.BookList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllBooks.Count, TestList.Count);
        }

        /*[TestMethod]
        public void AddMethodOK()
        {
            //create an instance of clsBookCollection
            clsBookCollection AllBooks = new clsBookCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.BookId = 1;
            TestItem.BookTitle = "Cooking book";
            TestItem.BookPrice = 10.00;
            TestItem.BookQuantity = 100;
            TestItem.BookAvailability = true;
            TestItem.DateReceived = DateTime.Now.Date;
            //set ThisAddress to the test data
            AllBooks.ThisBook = TestItem;
            //add the record
            PrimaryKey = AllBooks.Add();
            //set the primary key of the test data
            TestItem.BookId = PrimaryKey;
            //find the record
            AllBooks.ThisBook.Find(PrimaryKey);
            //test to see that the values are the same
            Assert.AreEqual(AllBooks.ThisBook, TestItem);
        }

        /*[TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of clsBookCollection
            clsBookCollection AllBooks = new clsBookCollection();
            //create an item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.BookTitle = "Cooking book Vol.I";
            TestItem.BookPrice = 10.00;
            TestItem.BookQuantity = 100;
            TestItem.BookAvailability = true;
            TestItem.DateReceived = DateTime.Now.Date;
            //set ThisAddress to the test data
            AllBooks.ThisBook = TestItem;
            //add the record
            PrimaryKey = AllBooks.Add();
            //set the primary key of the test data
            TestItem.BookId = PrimaryKey;
            //modify the test data
            TestItem.BookTitle = "Cooking book Vol.II";
            TestItem.BookPrice = 11.00;
            TestItem.BookQuantity = 74;
            TestItem.BookAvailability = false;
            TestItem.DateReceived = DateTime.Now.Date;
            //set the record based on the new test data
            AllBooks.ThisBook = TestItem;
            //update the record
            AllBooks.Update();
            //find the record
            AllBooks.ThisBook.Find(PrimaryKey);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of clsBookCollection
            clsBookCollection AllBooks = new clsBookCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.BookId = 1;
            TestItem.BookTitle = "Cooking book";
            TestItem.BookPrice = 10.00;
            TestItem.BookQuantity = 100;
            TestItem.BookAvailability = true;
            TestItem.DateReceived = DateTime.Now.Date;
            //set ThisAddress to the test data
            AllBooks.ThisBook = TestItem;
            //add the record
            PrimaryKey = AllBooks.Add();
            //set the primary key of the test data
            TestItem.BookId = PrimaryKey;
            //find the record
            AllBooks.ThisBook.Find(PrimaryKey);
            //delete the record
            AllBooks.Delete();
            //now find the record
            Boolean Found = AllBooks.ThisBook.Find(PrimaryKey);
            //test to see that the values are the same
            Assert.IsFalse(Found);
        }*/

        [TestMethod]
        public void ReportByBookTitleMethodOK()
        {
            //create an instance of the class with unfiltering results
            clsBookCollection AllBooks = new clsBookCollection();
            //create an instance of the filtered data
            clsBookCollection FilteredBooks = new clsBookCollection();
            //apply a blank string (should return all records)
            FilteredBooks.ReportByBookTitle("");
            //test to see that the two values are the same
            Assert.AreEqual(AllBooks.Count, FilteredBooks.Count);
        }

        [TestMethod]
        public void ReportByBookTitleNoneFound()
        {
            //create an instance of the filtered data
            clsBookCollection FilteredBooks = new clsBookCollection();
            //apply a title that doesn't exist
            FilteredBooks.ReportByBookTitle("00000000");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredBooks.Count);
        }

        [TestMethod]
        public void ReportByBookTitleTestDataFound()
        {
            //create an instance of the filtered data
            clsBookCollection FilteredBooks = new clsBookCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a title that doesn't exist
            FilteredBooks.ReportByBookTitle("Cooking book");
            //check that the correct number of records are found
            if(FilteredBooks.Count == 2)
            {
                //check that the first record is id 7
                if(FilteredBooks.BookList[0].BookId != 7)
                {
                    OK = false;
                }
                //check that the first records is id 15
                if(FilteredBooks.BookList[1].BookId != 15)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
    }
