
using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class AgentCustomer
    {
        public int CustomerId{get;set;}
        public int AgentId { get; set; }  

        [JsonIgnore]
        public Agent Agent{get;set;}        
        public Customer Customer{get;set;}
        public double Rate{get;set;}
    }
}
