using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private double mTotalPrice;
        public int unitQuantity;

        public bool isStaff { get; set; }

        public DateTime DateAdded { get; set; }
        public string ShipAddress { get; set; }
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
        public int OrderID { get; set; }

        public bool Find(double totalPrice)
        {
            mTotalPrice = 33.46;
            return true;
        }
    }
}