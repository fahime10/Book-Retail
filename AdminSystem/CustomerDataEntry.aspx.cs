using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void chkExistingAcc_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
       /* clsCustomer TheCustomer = new clsCustomer();
        TheCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        TheCustomer.CustomerFirstName = txtCustomerFirstName.Text;
        TheCustomer.CustomerLastName = txtCustomerLastName.Text;
        TheCustomer.CustomerAddress = txtCustomerAddress.Text;
        TheCustomer.CustomerAccCreated = Convert.ToDateTime(txtCustomerAccCreated.Text);
        TheCustomer.ExistingAcc = chkExistingAcc.Checked;
        Session["TheCustomer"] = TheCustomer;
        Response.Write("CustomerViewer.aspx");*/
        clsCustomer TheCustomer = new clsCustomer();
        string CustomerFirstName = txtCustomerFirstName.Text;
        string CustomerLastName = txtCustomerLastName.Text;
        string CustomerAddress = txtCustomerAddress.Text;
        string CustomerAccountCreated = txtCustomerAccCreated.Text;
        string Error = "";
        Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccountCreated);
        if (Error == "")
        {
            TheCustomer.CustomerFirstName = CustomerFirstName;
            TheCustomer.CustomerLastName = CustomerLastName;
            TheCustomer.CustomerAddress = CustomerAddress;
            TheCustomer.CustomerAccCreated = Convert.ToDateTime(CustomerAccountCreated);
            Session["TheCustomer"] = TheCustomer;
            Response.Write("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer TheCustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = TheCustomer.Find(CustomerID);
        if (Found == true)
        {
            txtCustomerFirstName.Text = TheCustomer.CustomerFirstName;
            txtCustomerLastName.Text = TheCustomer.CustomerLastName;
            txtCustomerAddress.Text = TheCustomer.CustomerAddress;
            txtCustomerAccCreated.Text = TheCustomer.CustomerAccCreated.ToString();
        }

    }
}