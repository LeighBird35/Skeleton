using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        
        public bool OrderSearch { get; set; }
        public DateTime DateAdded { get; set; }
        public long OrderID { get; set; } 
        public bool OrderDelivery { get; set; }
        public string OrderAddress { get; set; }
        public string OrderReturn { get; set; }
        public bool Active { get; set; }
    }
}
