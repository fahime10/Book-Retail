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
        clsCustomer TheCustomer = new clsCustomer();
        TheCustomer = (clsCustomer)Session["TheCustomer"];
        Response.Write(TheCustomer.CustomerID);
        Response.Write(TheCustomer.CustomerFirstName);
        Response.Write(TheCustomer.CustomerLastName);
        Response.Write(TheCustomer.CustomerAddress);
        Response.Write(TheCustomer.CustomerAccCreated);



    }
}