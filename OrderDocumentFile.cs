
using newkilibraries.inventory;

using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class OrderDocumentFile
    {
        public OrderDocumentFile()
        {
        }
        public int DocumentFileId {get;set;}
        public int OrderId{get;set;}

        [JsonIgnore]
        public Order Order {get;set;}
        public DocumentFile File{get;set;}
    }
}
