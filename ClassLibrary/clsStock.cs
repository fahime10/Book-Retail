using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool BookAvailability { get; set; }
        public DateTime DateReceived { get; set; }
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public int BookQuantity { get; set; }
        public double BookPrice { get; set; }
    }
}