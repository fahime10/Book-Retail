using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 BookId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the bookto be processed
        BookId = Convert.ToInt32(Session["BookId"]);
        if(IsPostBack == false)
        {
            //if this is not a new record
            if(BookId != -1)
            {
                DisplayBook();
            }
        }
    }

    void DisplayBook()
    {
        //create an instance of clsBookCollection
        clsBookCollection AllBooks = new clsBookCollection();
        //find the record to update
        AllBooks.ThisBook.Find(BookId);
        //display the data for this record
        txtBookId.Text = AllBooks.ThisBook.BookId.ToString();
        txtBookTitle.Text = AllBooks.ThisBook.BookTitle;
        txtBookPrice.Text = AllBooks.ThisBook.BookPrice.ToString();
        txtBookQuantity.Text = AllBooks.ThisBook.BookQuantity.ToString();
        txtDateReceived.Text = AllBooks.ThisBook.DateReceived.ToString();
        chkBookAvailability.Checked = AllBooks.ThisBook.BookAvailability;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock ABook = new clsStock();
        //capture the title
        string bookTitle = txtBookTitle.Text;
        //capture the price
        string bookPrice = txtBookPrice.Text;
        //capture the quantity
        string bookQuantity = txtBookQuantity.Text;
        //capture the date received
        string dateReceived = txtDateReceived.Text;
        //variable to store the error message
        string Error = "";
        //validate the data
        Error = ABook.Valid(bookTitle, bookPrice, bookQuantity, dateReceived);
        if (Error == "")
        {
            //capture the id
            ABook.BookId = BookId;
            //capture the title
            ABook.BookTitle = bookTitle;
            //capture the price
            ABook.BookPrice = Convert.ToDouble(bookPrice);
            //capture the quantity
            ABook.BookQuantity = Convert.ToInt32(bookQuantity);
            //capture the date received
            ABook.DateReceived = Convert.ToDateTime(dateReceived);
            //capture availability
            ABook.BookAvailability = chkBookAvailability.Checked;
            //create a new instance of clsBookCollection
            clsBookCollection AllBooks = new clsBookCollection();

            //if this is a new record, then add the data
            if(BookId == -1)
            {
                //set the ThisBook property
                AllBooks.ThisBook = ABook;
                //add the new record
                AllBooks.Add();
            }
            else //otherwise, it must be an update
            {
                //find the record to update
                AllBooks.ThisBook.Find(BookId);
                //set the ThisAddress property
                AllBooks.ThisBook = ABook;
                //update the record
                AllBooks.Update();
            }
            //redirect to the list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock ABook = new clsStock();
        int bookId;
        Boolean Found = false;
        bookId = Convert.ToInt32(txtBookId.Text);
        Found = ABook.Find(bookId);

        if (Found == true)
        {
            txtBookTitle.Text = ABook.BookTitle;
            txtBookPrice.Text = ABook.BookPrice.ToString();
            txtBookQuantity.Text = ABook.BookQuantity.ToString();
            txtDateReceived.Text = ABook.DateReceived.ToString();
        }
    }
}