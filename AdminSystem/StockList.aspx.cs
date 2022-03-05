using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayBooks();
        }
    }

    void DisplayBooks()
    {
        //create an instance of the clsBookCollection
        clsBookCollection AllBooks = new clsBookCollection();
        //set the data source to list of addresses in the collection
        lstBookList.DataSource = AllBooks.BookList;
        //set the name of the primary key
        lstBookList.DataValueField = "BookId";
        //set the data field to display
        lstBookList.DataTextField = "BookTitle";
        //bind data to the list
        lstBookList.DataBind();
    }
}