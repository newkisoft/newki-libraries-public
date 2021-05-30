using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace newkilibraries.website
{
  public class Order 
    {
        [Key]
        public int OrderId{get;set;}
        public DateTimeOffset CreatedDate {get;set;}= DateTime.Now;
        public DateTimeOffset ModifiedDate {get;set;} = DateTime.Now;
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address{get;set;}        
        public double ExchangeRate{get;set;}
        public string StripeToken{get;set;}
        public List<OrderProduct> Products{get;set;}
    }
}
