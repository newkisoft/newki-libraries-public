using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace newkilibraries
{
    public class InvoiceDataView
    {       
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]    
        public string Id { get; set; }
        public Invoice Invoice{get;set;}
    }
}
