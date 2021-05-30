using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class InvoiceBox
    {     
        public Box Box{get;set;}
        [JsonIgnore]
        public Invoice Invoice{get;set;}
        public int BoxId{get;set;}
        public int InvoiceId{get;set;}        
        public double Weight{get;set;}
    }
}
