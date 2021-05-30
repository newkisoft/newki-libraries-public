using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
    public class Proforma
    {
        public Proforma(){   
            ProformaProformaItems = new List<ProformaProformaItem>();            
            Files = new List<ProformaDocumentFile>();

        }        
        public int ProformaId { get; set; }
                
        public DateTimeOffset ProformaDate { get; set; }
        [Display(Name = "Invoice Due Date")]
        public DateTimeOffset ProformaDueDate { get; set; }

        [Display(Name = "Customer")]
        public Customer Customer{get;set;}    

        public string Seller{get;set;}   
        public string Consignee{get;set;}
        public string Buyer{get;set;}
        public DateTimeOffset ValidUntil{get;set;}
        public string CountryOfBeneficiary{get;set;}
        public string FreightForwarder{get;set;}
        public string CountryOfOrigin{get;set;}
        public string CountryOfDestination{get;set;}
        public string PartialShipment{get;set;}
        public string TermsOfDelivery{get;set;}
        public string RelevantLocation{get;set;}
        public string TransportBy{get;set;}
        public string Port{get;set;}
        public string TermsOfPayment{get;set;}
        public string HsCode{get;set;}
        public string PackageDescription{get;set;}
        public string TotalGross{get;set;}
        public string Size{get;set;}
        public string BankAccounts{get;set;}
        public string ProformaNumber{get;set;}
        [Display(Name = "TotalUsd")]
        public double TotalUsd{get;set;}

        [Display(Name = "Tax")]
        public double Tax{get;set;}
        public double Kdv{get;set;}
        [Display(Name = "Exchange Rate")]
        public double ExchangeRate{get;set;}
        public double Discount{get;set;}
        public double Paid{get;set;}
        public string Currency {get;set;}        
        public IList<ProformaProformaItem> ProformaProformaItems{get;set;}        
        public IList<ProformaDocumentFile> Files{get;set;}        
        public string Comment{get;set;}
    }
}
