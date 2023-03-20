using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public DateTime ContractDate { get; set; }
        public string EmailAddress { get; set; }
        public string TelephoneNo { get; set; }
        public bool CurrentSupplier { get; set; }

        public bool Find(int SupplierID)
        {
            //always return true
            return true;
        }
    }
    }
    
}