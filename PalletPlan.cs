using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
    public class PalletPlan
    {
        [Key]
        public int PalletPlanId{get;set;}
        public string Details{get;set;}                
        public double Weight{get;set;}
    }
}
