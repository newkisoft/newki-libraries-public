
using System.ComponentModel.DataAnnotations;
using System;

namespace newkilibraries
{
    public class User
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
