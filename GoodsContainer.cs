using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace newkilibraries
{
    public class GoodsContainer
    {
        public int GoodsContainerId{get;set;}
        public string Name {get;set;}
        public DateTimeOffset ImportDate{get;set;}
        public DateTimeOffset ReleaseDate{get;set;}     
        public string Note{get;set;}        
        public List<GoodsContainerPallet> GoodsContainerPallets{get;set;}
        public List<GoodsContainerDocumentFile> Files{get;set;}
    }
}
