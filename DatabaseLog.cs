using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public class DatabaseLog
    {
        public DatabaseLog()
        {
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public int DatabaseLogId {get;set;}        
        public DateTimeOffset EntryDate{get;set;}
        public string Description{get;set;}        
    }
}
