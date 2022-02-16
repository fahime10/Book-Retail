using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock ABook = new clsStock();
        //get the data from the session object
        ABook = (clsStock)Session["ABook"];
        //display the attributes for this entry
        Response.Write(ABook.BookId + "\n");
        Response.Write(ABook.BookTitle + "\n");
        Response.Write(ABook.BookPrice + "\n");
        Response.Write(ABook.BookQuantity + "\n");
        Response.Write(ABook.BookAvailability + "\n");
        Response.Write(ABook.DateReceived + "\n");
    }
}