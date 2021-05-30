using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class InvoicePallet
    {     
        public Pallet Pallet{get;set;}
        [JsonIgnore]
        public Invoice Invoice{get;set;}
        public int InvoiceId{get;set;}
        public int PalletId{get;set;}        
        public double Weight{get;set;}
    }
}
