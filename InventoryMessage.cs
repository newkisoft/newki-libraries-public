using System;

namespace newkilibraries
{
    public class InventoryMessage
    {
        public DateTimeOffset MessageDate {get;set;}
        public string RequestNumber{get;set;}                
        public string Command{get;set;}
        public string Message{get;set;}
    }
}