using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int unitQuantity;

        public bool isStaff { get; set; }

        public DateTime DateAdded { get; set; }
        public string ShipAddress { get; set; }
        public double totalPrice { get; set; }
        public int OrderID { get; set; }
    }
}