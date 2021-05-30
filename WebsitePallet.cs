using System;
using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
   public class WebsitePallet
    {
        [Key]
        public int PalletId {get;set;}
        public string PalletGeneratedNumber{get;set;}
        public string YarnType{get;set;}
        public string Denier{get;set;}
        public string Filament{get;set;}
        public string Intermingle{get;set;}
        public string Color{get;set;}
        public string ColorCode{get;set;}
        public string BobbinSize{get;set;}
    }
}
