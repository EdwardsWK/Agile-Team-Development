﻿using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderID { get; set; }
        public DateTime OrderPlaced { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double OrderTotal { get; set; }
        public bool OrderCompleted { get; set; }
    }
}