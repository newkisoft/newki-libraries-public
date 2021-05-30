using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public class VendorDataView
    {       
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorId { get; set; }
        public string Data{get;set;}
    }
}
