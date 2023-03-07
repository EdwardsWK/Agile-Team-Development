using System;

namespace ClassLibrary
{
    public class clsReview
    {
        public int ReviewID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }
        public bool Approved { get; set; }
    }
}