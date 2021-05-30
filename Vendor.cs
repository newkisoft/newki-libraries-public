using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
    public class Vendor
    { 
        public int VendorId { get; set; }
        [Required]
        public string VendorName { get; set; }
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
    }
}
