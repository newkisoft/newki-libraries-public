
using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public class RequestStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id{get;set;}
        public string Status{get;set;}        
    }
}
