using System;

namespace newkilibraries
{
    public class InvoicePayment
    {
        public InvoicePayment(){   

        }
        public int InvoicePaymentId{get;set;}
        public int InvoiceId { get; set; }
        public double Amount{get;set;}      
        public double ExchangeRate{get;set;}          
        public DateTimeOffset PaymentDate{get;set;}

    }
}
