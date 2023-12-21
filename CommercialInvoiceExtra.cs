using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
    public class CommercialInvoiceExtra
    {
       [Key]
        public int CommercialInvoiceExtraId { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
    }
}
