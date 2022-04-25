using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrder();
            }
        }

    }

    void DisplayOrder()
    {
        clsOrderCollection Order = new clsOrderCollection();
        Order.ThisOrder.Find(OrderID);

        txtOrderID.Text = Order.ThisOrder.OrderID.ToString();
        chkStaff.Text = Order.ThisOrder.isStaff.ToString();
        txtUnitQuantity.Text = Order.ThisOrder.unitQuantity.ToString();
        txtTotalPrice.Text = Order.ThisOrder.totalPrice.ToString();
        txtOrderPlacedDate.Text = Order.ThisOrder.OrderDate.ToString();
        txtShipAddress.Text = Order.ThisOrder.ShipAddress.ToString();

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string ShipAddress = txtShipAddress.Text;
        string OrderDate = txtOrderPlacedDate.Text;
        string UnitQuantity = txtUnitQuantity.Text;
        string TotalPrice = txtTotalPrice.Text;

        string Error = "";
        Error = AnOrder.Valid(UnitQuantity, TotalPrice, ShipAddress, OrderDate);
        if (Error == "")
        {
            AnOrder.OrderID = OrderID;
            AnOrder.isStaff = chkStaff.Checked;
            AnOrder.unitQuantity = Convert.ToInt32(UnitQuantity);
            AnOrder.totalPrice = Convert.ToInt32(TotalPrice);
            AnOrder.ShipAddress = ShipAddress;
            AnOrder.OrderDate =Convert.ToDateTime(OrderDate);

            clsOrderCollection OrderList = new clsOrderCollection();

            if (OrderID == -1)
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");
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