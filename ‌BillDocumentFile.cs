
using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class BillDocumentFile
    {
        public BillDocumentFile()
        {
        }
        public int DocumentFileId {get;set;}
        public int BillId{get;set;}

        [JsonIgnore]
        public Bill Bill {get;set;}
        public DocumentFile File{get;set;}
    }
}
