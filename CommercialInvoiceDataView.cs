using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public class CommercialInvoiceDataView
    {       
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CommercialInvoiceId { get; set; }
        public string Data{get;set;}
    }
}
