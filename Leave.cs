using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
    public class Leave
    {
        public Leave(){   
        }        
        public int LeaveId { get; set; }                
        public DateTimeOffset LeaveStartDate { get; set; }
        public DateTimeOffset LeaveEndDate { get; set; }
        public string Description{get;set;}
        public int VendorId{get;set;}
        public Vendor Vendor{get;set;}
    }
}
