
using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class GoodsContainerDocumentFile
    {
        public GoodsContainerDocumentFile()
        {
        }
        public int DocumentFileId {get;set;}
        public int GoodsContainerId{get;set;}

        [JsonIgnore]
        public GoodsContainer GoodsContaienr {get;set;}
        public DocumentFile File{get;set;}
    }
}
