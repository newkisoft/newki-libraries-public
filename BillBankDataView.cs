using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public class BillBankDataView
    {       
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillId { get; set; }
        public string Data{get;set;}
    }
}
