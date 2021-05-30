using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public class ProformaDataView
    {       
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProformaId { get; set; }
        public string Data{get;set;}
    }
}
