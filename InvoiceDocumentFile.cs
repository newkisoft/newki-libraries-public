
using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class InvoiceDocumentFile
    {
        public InvoiceDocumentFile()
        {
        }
        public int DocumentFileId {get;set;}
        public int InvoiceId{get;set;}

        [JsonIgnore]
        public Invoice Invoice {get;set;}
        public DocumentFile File{get;set;}
    }
}
