    using System;
using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
 public class FdyPrice
    {
        public string RequestNumber{get;set;}        
        [Key]
        public int Id{get;set;}
        public string Name{get;set;}
        public string Lustre{get;set;}
        public string Intermingle{get;set;}
        public string Color{get;set;}
        public string ColorCode{get;set;}              
        public string Price{get;set;}
    }
}