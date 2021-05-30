using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
    public class PalletFilter
    {
        [Key]
        public int PalletFilterId{get;set;}
        public string ColumnName{get;set;}                
        public string Keywords{get;set;}
    }
}
