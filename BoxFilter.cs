using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
    public class BoxFilter
    {
        [Key]
        public int BoxFilterId{get;set;}
        public string ColumnName{get;set;}                
        public string Keywords{get;set;}
    }
}
