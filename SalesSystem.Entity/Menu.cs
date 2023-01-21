﻿using System;
using System.Collections.Generic;

namespace SalesSystem.Entity
{
    public partial class Menu
    {
        public Menu()
        {
            InverseParentMenu = new HashSet<Menu>();
            RolMenus = new HashSet<RolMenu>();
        }

        public int MenuId { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
        public string? Controller { get; set; }
        public string? ActionPage { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int? ParentMenuId { get; set; }

        public virtual Menu? ParentMenu { get; set; }
        public virtual ICollection<Menu> InverseParentMenu { get; set; }
        public virtual ICollection<RolMenu> RolMenus { get; set; }
    }
}
