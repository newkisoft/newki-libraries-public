using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Display(Name = "Street Address")]
        public string Address { get; set; }
        public string City { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Gmail{get;set;}
        public string Website{get;set;}
        public string Vergi{get;set;}
        public int Rate{get;set;}
        [JsonIgnore]
        public IList<AgentCustomer> Agents{get;set;}
    }
}
