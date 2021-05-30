using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public class BillDataView
    {       
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillId { get; set; }
        public string Data{get;set;}
    }
}
