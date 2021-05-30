using System.Text.Json.Serialization;

namespace newkilibraries
{
    public class GoodsContainerPallet
    {
        public int GoodsContainerId{get;set;}
        public int PalletId{get;set;}
        [JsonIgnore]
        public GoodsContainer GoodsContaienr{get;set;}
        public Pallet Pallet{get;set;}
    }
}
