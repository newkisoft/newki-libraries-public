
using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class CommercialInvoiceDocumentFile
    {
        public CommercialInvoiceDocumentFile()
        {
        }
        public int DocumentFileId {get;set;}
        public int CommercialInvoiceId{get;set;}

        [JsonIgnore]
        public CommercialInvoice CommercialInvoice {get;set;}
        public DocumentFile File{get;set;}
    }
}
