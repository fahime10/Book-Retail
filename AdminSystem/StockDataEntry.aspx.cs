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
        clsStock ABook = new clsStock();
        //capture the attributes
        ABook.BookId = Convert.ToInt32(txtBookId.Text);
        ABook.BookTitle = txtBookTitle.Text;
        ABook.BookPrice = Convert.ToDouble(txtBookPrice.Text);
        ABook.BookQuantity = Convert.ToInt32(txtBookQuantity.Text);
        ABook.DateReceived = Convert.ToDateTime(txtDateReceived.Text);
        ABook.BookAvailability = chkBookAvailability.Checked;
        //store the attributes in the session object
        Session["ABook"] = ABook;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}