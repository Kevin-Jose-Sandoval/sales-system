using System;
using System.Collections.Generic;

namespace SalesSystem.Entity
{
    public partial class Rol
    {
        public Rol()
        {
            RolMenus = new HashSet<RolMenu>();
            Users = new HashSet<User>();
        }

        public int RolId { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RegisterDate { get; set; }

        public virtual ICollection<RolMenu> RolMenus { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
