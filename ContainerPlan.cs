using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
    public class ContainerPlan
    {
        public int ContainerPlanId{get;set;}
        public string Name {get;set;}
        public DateTimeOffset EstimateArrivalDate{get;set;}        
        public string Note{get;set;}                        
        public List<ContainerPlanPalletPlan> PalletPlans{get;set;}
        public List<ContainerPlanDocumentFile> Files{get;set;}
    }
}
