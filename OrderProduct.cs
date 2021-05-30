using System;
using newkilibraries.website;

namespace newkilibraries
{
   public class OrderProduct
    {
        public OrderProduct()
        {
        }
        public int OrderProductId{get;set;}
        public int Quantity{get;set;}
        public int ProductId {get;set;}                
        public int OrderId{get;set;}
        public OnlineProduct Product{get;set;}
        public Order Order{get;set;}
    }
}
