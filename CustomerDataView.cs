using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public class CustomerDataView
    {       
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }
        public string Data{get;set;}
    }
}
