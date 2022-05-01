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

        public DateTime OrderDate
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

        public string Valid(string UnitQuantity, String TotalPrice, string ShipAddress, string OrderDate)
        {
            String Error = "";
            DateTime DateTemp;

            if (ShipAddress.Length == 0)
            {
                Error = Error + "The ship address may not be blank";
            }

            if (ShipAddress.Length > 100)
            {
                Error = Error + "The ship address must not exceed 100 characters. ";
            }

            if (UnitQuantity.Length == 0)
            {
                Error = Error + "The unit quantity may not be blank";

            }

            if(UnitQuantity.Length > 10)
            {
                Error = Error + "The unit quantity may not exceed 100 characters.";
            }

            if(TotalPrice.Length == 0)
            {
                Error = Error + "The total price may not be blank";
            }

            if(TotalPrice.Length > 10)
            {
                Error = Error + "The total price cannot exceed 10 characters.";
            }


            try
            {
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past. ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future. ";
                }

            }
            catch
            {
                Error = Error + "The date was not a valid date! ";
            }
            

            return Error;
        }


    }
}