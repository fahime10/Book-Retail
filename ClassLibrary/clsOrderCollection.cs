using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {




        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();


        public clsOrderCollection()
        {


            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblOrder_selectAll");

            PopulateArray(DB);

           
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
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@isStaff", mThisOrder.isStaff);
            DB.AddParameter("@unitQuantity", mThisOrder.unitQuantity);
            DB.AddParameter("@totalPrice", mThisOrder.totalPrice);
            DB.AddParameter("@orderPlacedDate", mThisOrder.OrderDate);
            DB.AddParameter("@ShipAddress", mThisOrder.ShipAddress);

            return DB.Execute("sproc_tblOrder_Insert");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@isStaff", mThisOrder.isStaff);
            DB.AddParameter("@unitQuantity", mThisOrder.unitQuantity);
            DB.AddParameter("@totalPrice", mThisOrder.totalPrice);
            DB.AddParameter("@orderPlacedDate", mThisOrder.OrderDate);
            DB.AddParameter("@ShipAddress", mThisOrder.ShipAddress);

            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByShipAddress(string ShipAddress)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ShipAddress", ShipAddress);
            DB.Execute("sproc_tblOrder_FilterByShipAddress");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data in the parameter db
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while(Index < RecordCount)
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

    }
}


