
using System.ComponentModel.DataAnnotations;
using System;

namespace newkilibraries
{
    public class Role
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Link { get; set; }
    }
}
