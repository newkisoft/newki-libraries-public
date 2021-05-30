using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class ProformaItem
    {
        public ProformaItem()
        {
        }
        public int ProformaItemId {get;set;}
        public string Description{get;set;}
        [JsonIgnore]
        public IList<ProformaProformaItem> Proformas{get;set;}
    }
}
