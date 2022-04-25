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
            DisplayOrders();
        }

    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "shipAddress";
        lstOrderList.DataBind();
    }



    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;

        if(lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        
        if(lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrderConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByShipAddress(txbShipAddress.Text);
        lstOrderList.DataSource = Orders.OrderList;

        lstOrderList.DataValueField = "OrderID";

        lstOrderList.DataTextField = "ShipAddress";

        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByShipAddress("");
        txbShipAddress.Text = "";
        lstOrderList.DataSource = Orders.OrderList;

        lstOrderList.DataValueField = "OrderID";

        lstOrderList.DataTextField = "ShipAddress";

        lstOrderList.DataBind();
    }
}