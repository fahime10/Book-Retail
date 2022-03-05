using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
            //capture the title
            ABook.BookTitle = bookTitle;
            //capture the price
            ABook.BookPrice = Convert.ToDouble(bookPrice);
            //capture the quantity
            ABook.BookQuantity = Convert.ToInt32(bookQuantity);
            //capture the date received
            ABook.DateReceived = Convert.ToDateTime(dateReceived);
            //store the book in the session object
            Session["ABook"] = ABook;
            //redirect to the viewer page
            Response.Redirect("StockViewer.aspx");
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