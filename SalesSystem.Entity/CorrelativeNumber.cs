using System;
using System.Collections.Generic;

namespace SalesSystem.Entity
{
    public partial class CorrelativeNumber
    {
        public int CorrelativeNumberId { get; set; }
        public int? LastNumber { get; set; }
        public int? NumberOfDigits { get; set; }
        public string? Management { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
