using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public class BoxDataView
    {        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BoxId { get; set; }
        public string Data{get;set;}
    }
}
