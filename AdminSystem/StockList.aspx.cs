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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session to indicate this is a new record
        Session["BookId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 BookId;
        //if a record has been selected from the list
        if(lstBookList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            BookId = Convert.ToInt32(lstBookList.SelectedValue);
            //store the data in the session object
            Session["BookId"] = BookId;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}