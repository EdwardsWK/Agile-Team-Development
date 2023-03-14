using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffID { get; set; }
        public string StaffFirstName { get; set; }
        public string StaffLastName { get; set; }
        public string StaffEmail { get; set; }
        public string StaffPassword { get; set; }
        public DateTime StaffDateJoined { get; set; }
        public bool StaffIsManager { get; set; }

    }
}