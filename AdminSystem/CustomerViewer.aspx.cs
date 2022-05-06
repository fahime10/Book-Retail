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
        Response.Write(TheCustomer.CustomerID + "\n");
        Response.Write(TheCustomer.CustomerFirstName + "\n");
        Response.Write(TheCustomer.CustomerLastName + "\n");
        Response.Write(TheCustomer.CustomerAddress + "\n");
        Response.Write(TheCustomer.CustomerAccCreated + "\n");



    }
}