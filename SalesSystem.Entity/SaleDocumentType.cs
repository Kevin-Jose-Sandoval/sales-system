using System;
using System.Collections.Generic;

namespace SalesSystem.Entity
{
    public partial class SaleDocumentType
    {
        public SaleDocumentType()
        {
            Sales = new HashSet<Sale>();
        }

        public int SaleDocumentTypeId { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RegisterDate { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
