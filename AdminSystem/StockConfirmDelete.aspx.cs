using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 BookId;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the book to be deleted from the session object
        BookId = Convert.ToInt32(Session["BookId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of clsBookCollection
        clsBookCollection AllBooks = new clsBookCollection();
        //find the record to delete
        AllBooks.ThisBook.Find(BookId);
        //delete the record
        AllBooks.Delete();
        //redirect to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("StockList.aspx");
    }
}