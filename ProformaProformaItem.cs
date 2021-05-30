using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class ProformaProformaItem
    {     
        public ProformaItem ProformaItem{get;set;}
        [JsonIgnore]
        public Proforma Proforma{get;set;}
        public int ProformaId{get;set;}
        public int ProformaItemId{get;set;}  
        public double Price{get;set;}
        public double Weight{get;set;}
    }
}
