using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public class BillBank
    {       
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillId { get; set; }
        public string Description{get;set;}
        public double Amount{get;set;}
        public DateTimeOffset  BillDate{get;set;}
    }
}
