using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
    public class InvoiceExtra
    {
        [Key]
        public int InvoiceExtraId { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
    }
}
