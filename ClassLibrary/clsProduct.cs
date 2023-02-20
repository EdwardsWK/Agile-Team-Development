using System;

namespace ClassLibrary
{
    public class clsProduct
    { 
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public DateTime DateAdded { get; set; }
        public int StockCount { get; set; }
        public float Price { get; set; }
        public bool Available { get; set; }
    }
}