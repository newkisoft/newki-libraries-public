using System;

namespace newkilibraries
{
    public class WebsiteInvoice
    {
        public WebsiteInvoice()
        {

        }
        public string Id { get; set; }

        public string InvoiceDate { get; set; }
        public string InvoiceDueDate { get; set; }

        public string Email { get; set; }

        public string TotalUsd { get; set; }

        public string Tax { get; set; }
        public string Kdv { get; set; }
        public string ExchangeRate { get; set; }
        public int StateInvoiceNumber { get; set; }
        public string Discount { get; set; }
        public string Paid { get; set; }
        public string Currency { get; set; }
        public string Files { get; set; }
        public string Comment { get; set; }
        public string DriverName { get; set; }
        public string DriverRegistrationNumber { get; set; }

    }
}
