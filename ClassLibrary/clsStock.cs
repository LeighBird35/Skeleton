using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool available { get; set; }
        public DateTime dayAdded { get; set; }
        public long bookId { get; set; }
        public string bookSearches { get; set; }
        public string bookDescription { get; set; }
        public double price { get; set; }
    }
}