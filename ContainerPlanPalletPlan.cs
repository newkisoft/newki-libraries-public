
using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class ContainerPlanPalletPlan
    {
        public int PalletPlanId {get;set;}
        public int ContainerPlanId{get;set;}
        public string Customer{get;set;}
        
        public PalletPlan PalletPlan {get;set;}
        [JsonIgnore]
        public ContainerPlan ContainerPlan{get;set;}
    }
}
