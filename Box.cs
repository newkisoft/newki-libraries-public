using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class Box
    {
        public Box()
        {
        }
        public int BoxId {get;set;}       
        public Pallet Pallet{get;set;}
        public int PalletId{get;set;}
        public string Barcode{get;set;}
        public string YarnType{get;set;}
        public int Denier{get;set;}
        public int Filament{get;set;}
        public string Intermingle{get;set;}
        public string Color{get;set;}
        public string ColorCode{get;set;}
        public string BobbinSize{get;set;}        
        public double Weight{get;set;}
        public double Price{get;set;}
        public double RemainWeight{get;set;}
        public bool Sold{get;set;}        
        public string Note{get;set;}
        public bool IsDelivered{get;set;}
        public DateTimeOffset DeliveryDate{get;set;}
        [JsonIgnore]
        public IList<InvoiceBox> InvoiceBoxess{get;set;}
    }
}
