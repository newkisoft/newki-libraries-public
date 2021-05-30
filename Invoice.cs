using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
    public class Invoice
    {
        public Invoice(){   
            InvoicePallets = new List<InvoicePallet>();
            InvoiceBoxes = new List<InvoiceBox>();
            Files = new List<InvoiceDocumentFile>();

        }
        [Display(Name = "Invoice Number")]
        public int InvoiceId { get; set; }
        public int ProformaId{get;set;}
                
        [Display(Name = "Invoice Date")]
        public DateTimeOffset InvoiceDate { get; set; }
        [Display(Name = "Invoice Due Date")]
        public DateTimeOffset InvoiceDueDate { get; set; }

        [Display(Name = "Customer")]
        public Customer Customer{get;set;}       

        [Display(Name = "TotalUsd")]
        public double TotalUsd{get;set;}

        [Display(Name = "Tax")]
        public double Tax{get;set;}
        public double Kdv{get;set;}
        [Display(Name = "Exchange Rate")]
        public double ExchangeRate{get;set;}
        public int StateInvoiceNumber{get;set;}        
        public double Discount{get;set;}
        public double Paid{get;set;}
        public string Currency {get;set;}        
        public IList<InvoicePallet> InvoicePallets{get;set;}
        public IList<Invoice‌Box> InvoiceBoxes{get;set;}
        public IList<InvoiceDocumentFile> Files{get;set;}
        public IList<InvoicePayment> Payments{get;set;}
        public int OrderId{get;set;}
        public string Comment{get;set;}
        public string DriverName{get;set;}
        public string DriverRegistrationNumber{get;set;}
        public bool HasOfficialInvoice{get;set;}

    }
}
