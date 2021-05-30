using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class Pallet
    {
        public Pallet()
        {
        }
        public int PalletId { get; set; }
        public string PalletNumber { get; set; }
        public string Barcode { get; set; }
        public string YarnType { get; set; }
        public int Denier { get; set; }
        public int Filament { get; set; }
        public string Lustre { get; set; }
        public string Intermingle { get; set; }
        public string Color { get; set; }
        public string ColorCode { get; set; }
        public string BobbinSize { get; set; }
        public string PalletName { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public double RemainWeight { get; set; }
        public bool Sold { get; set; }
        public string Note { get; set; }
        public string Lot { get; set; }
        public string Warehouse { get; set; }
        public string Details { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string ThumbnailImage { get; set; }
        public int NumberOfItems { get; set; }
        public int RemainingItems { get; set; }
        public bool IsOnlineProduct{get;set;}
        public bool IsDelivered{get;set;}
        public DateTimeOffset DeliveryDate{get;set;}
        [JsonIgnore]
        public IList<InvoicePallet> InvoicePallets { get; set; }
    }
}
