using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Forms
{
    [FormScript("SerenityData.Products")]
    [BasedOnRow(typeof(ProductsRow), CheckNames = true)]
    public class ProductsForm
    {
        public string ProductName { get; set; }
        [MediumQuarterWidth(UntilNext =true)]
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public decimal UnitPrice { get; set; }
        public int TenantId { get; set; }
    }
}