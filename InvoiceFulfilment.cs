using System;

namespace newkilibraries
{
    public class InvoiceFulfilment
    {
        public InvoiceFulfilment(){   

        }
        public int InvoiceFulfilmentId{get;set;}
        public int LabourVendorId{get;set;}
        public int InvoiceId { get; set; }
        public int NumberOfBoxes{get;set;}      
        public double Rate{get;set;}          
        public  Vendor Labour{get;set;}
        public DateTimeOffset PaymentDate{get;set;}

    }
}
