using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int StaffNo { get; set; }
        public string StaffName { get; set; }
        public string StaffDesc { get; set; }
        public double StaffWage { get; set; }
        public string StaffDob { get; set; }
        public bool StaffAvaliable { get; set; }
    }
}