using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ThisCustomer.Find(CustomerID);
        txtCustomerID.Text = Customers.ThisCustomer.CustomerID.ToString();
        txtCustomerFirstName.Text = Customers.ThisCustomer.CustomerFirstName;
        txtCustomerLastName.Text = Customers.ThisCustomer.CustomerLastName;
        txtCustomerAddress.Text = Customers.ThisCustomer.CustomerAddress;
        txtCustomerAccCreated.Text = Customers.ThisCustomer.CustomerAccCreated.ToString();
        chkExistingAcc.Checked = Customers.ThisCustomer.ExistingAcc;
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
        string CustomerAccCreated = txtCustomerAccCreated.Text;
        string Error = "";
        Error = TheCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerAccCreated);
        if (Error == "")
        {
            TheCustomer.CustomerID = CustomerID;
            TheCustomer.CustomerFirstName = CustomerFirstName;
            TheCustomer.CustomerLastName = CustomerLastName;
            TheCustomer.CustomerAddress = CustomerAddress;
            TheCustomer.CustomerAccCreated = Convert.ToDateTime(CustomerAccCreated);
            TheCustomer.ExistingAcc = chkExistingAcc.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //CustomerList.ThisCustomer = TheCustomer;
            //CustomerList.Add();
            //Response.Write("CustomerViewer.aspx");

            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = TheCustomer;
                CustomerList.Add();
            }
            Response.Redirect("CustomerList.aspx");
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