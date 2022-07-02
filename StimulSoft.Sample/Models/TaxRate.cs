using System;
using System.Collections.Generic;

namespace StimulSoft.Sample.Models
{
    public partial class TaxRate
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int TaxCategoryId { get; set; }
        public int CountryId { get; set; }
        public int StateProvinceId { get; set; }
        public string? Zip { get; set; }
        public decimal Percentage { get; set; }
    }
}
