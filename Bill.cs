using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public class Bill
    {
        public Bill()
        {
            Files = new List<BillDocumentFile>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillId { get; set; }
        [Display(Name = "Bill / Invoice Number")]
        public string BillName { get; set; }
        [Display(Name = "Vendor Bill / Invoice #")]
        public string VendorInvoiceNumber { get; set; }
        [Display(Name = "Bill Date")]
        public DateTimeOffset BillDate { get; set; }
        [Display(Name = "Bill Due Date")]
        public DateTimeOffset BillDueDate { get; set; }        
        public double Amount{get;set;}
        public double UsdAmount{get;set;}
        public double EuroAmount{get;set;}
        public double Paid{get;set;}
        public double KDV{get;set;}
        public Vendor Vendor{get;set;}
        public double ExchangeRate{get;set;}
        public string Comment{get;set;}        
        public string Currency{get;set;}
        public IList<BillDocumentFile> Files{get;set;}
    }
}
