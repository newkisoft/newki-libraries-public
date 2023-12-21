
using System.ComponentModel.DataAnnotations;
using System;

namespace newkilibraries
{
    public class UserRole
    {
        [Key]
        public string UserId { get; set; }
        [Key]
        public string RoleId { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
