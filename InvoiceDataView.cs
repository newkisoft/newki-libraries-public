using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public class InvoiceDataView
    {       
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceId { get; set; }
        public string Data{get;set;}
    }
}
