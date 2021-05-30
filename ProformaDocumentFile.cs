
using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class ProformaDocumentFile
    {
        public ProformaDocumentFile()
        {
        }
        public int DocumentFileId {get;set;}
        public int ProformaId{get;set;}

        [JsonIgnore]
        public Proforma Proforma {get;set;}
        public DocumentFile File{get;set;}
    }
}
