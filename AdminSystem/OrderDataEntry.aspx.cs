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
        clsOrder AnOrder = new clsOrder();
        string ShipAddress = txtShipAddress.Text;
        string OrderDate = txtOrderPlacedDate.Text;
        string UnitQuantity = txtUnitQuantity.Text;
        string OrderID = txtOrderID.Text;
        string TotalPrice = txtTotalPrice.Text;

        string Error = "";
        Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
        if (Error == "")
        {
            AnOrder.ShipAddress = ShipAddress;
            AnOrder.OrderDate =Convert.ToDateTime(OrderDate);
            Session["An Order"] = AnOrder;
            Response.Write("OrderViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = AnOrder.Find(OrderID);
        if(Found == true)
        {
            txtUnitQuantity.Text = AnOrder.unitQuantity.ToString();
            txtTotalPrice.Text = AnOrder.totalPrice.ToString();
            txtShipAddress.Text = AnOrder.ShipAddress;
            txtOrderPlacedDate.Text = AnOrder.OrderDate.ToString();


        }
    }
}