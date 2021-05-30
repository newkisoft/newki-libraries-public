using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
    public class News
    {        
        [Key]
        public int Id{get;set;}
        public string EnglishTitle{get;set;}
        public string TurkeyTitle{get;set;}
        public string EnglishDescription{get;set;}
        public string TurkeyDescription{get;set;}
    }
}
