using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public class DataView
    {       
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Data{get;set;}
    }
}
