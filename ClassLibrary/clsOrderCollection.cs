using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {




        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder thisOrder = new clsOrder();

        public clsOrderCollection()
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblOrder_selectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();

                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.unitQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["unitQuantity"]);
                AnOrder.totalPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["totalPrice"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["orderPlacedDate"]);
                AnOrder.ShipAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShipAddress"]);
                AnOrder.isStaff = Convert.ToBoolean(DB.DataTable.Rows[Index]["isStaff"]);

                mOrderList.Add(AnOrder);
                Index++;
            }
        }


        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //worry ab later
            }
        }
        public clsOrder ThisOrder { get; set; }


    }
}


