using System;
using System.Collections.Generic;

namespace SalesSystem.Entity
{
    public partial class User
    {
        public User()
        {
            Sales = new HashSet<Sale>();
        }

        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int? RolId { get; set; }
        public string? PhotoUrl { get; set; }
        public string? PhotoName { get; set; }
        public string? Key { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RegisterDate { get; set; }

        public virtual Rol? Rol { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
