using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private double mTotalPrice;
        private DateTime mDateAdded;
        private int mUnitQuantity;
        private string mShipAddress;
        private bool mIsStaff;
        private int mOrderID;

        public int unitQuantity
        {
            get
            {
                return mUnitQuantity;
            }

            set
            {
                mUnitQuantity = value;
            }
        }

        public bool isStaff
        {
            get
            {
                return mIsStaff;
            }
            set
            {
                mIsStaff = value;
            }
        }

        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public string ShipAddress
        {
            get
            {
                return mShipAddress;
            }
            set
            {
                mShipAddress = value;
            }
        }
        public double totalPrice
        {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }
        public int OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }

        public bool Find(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            if (DB.Count == 1)
               {
                   mTotalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["totalPrice"]);
                   mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["orderPlacedDate"]);
                   mUnitQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["unitQuantity"]);
                   mIsStaff = Convert.ToBoolean(DB.DataTable.Rows[0]["isStaff"]);
                   mShipAddress = Convert.ToString(DB.DataTable.Rows[0]["ShipAddress"]);
                   mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                   return true;

               }
               else
               {
                   return false;
               }

            
        }
    }
}