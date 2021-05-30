using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace newkilibraries.inventory
{
   public class Order
    {
        public Order(){   
            Files = new List<OrderDocumentFile>();

        }
        
        public int OrderId { get; set; }             
        public DateTimeOffset OrderDate { get; set; }        
        public Customer Customer{get;set;}       
        public IList<OrderDocumentFile> Files{get;set;}
        public string Comment{get;set;}
        public string Status{get;set;}

    }
}
