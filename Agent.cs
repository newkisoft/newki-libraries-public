using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
    public class Agent
    {
        public int AgentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Street Address")]
        public string Address { get; set; }
        public string City { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Website{get;set;}
        public string Vergi{get;set;}
        public IList<AgentCustomer> Customers{get;set;}
    }
}
