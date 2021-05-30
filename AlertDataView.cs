using System.ComponentModel.DataAnnotations.Schema;

namespace newkilibraries
{
    public enum AlertTypes
    {
        Tekstilkent,
        All
    }
    public class AlertDataView:DataView
    {       
        public string AlertType{get;set;}
    }
}
