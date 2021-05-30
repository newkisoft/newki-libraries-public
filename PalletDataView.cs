using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public class PalletDataView
    {        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PalletId { get; set; }
        public string Data{get;set;}
    }
}
