using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Columns
{
    [ColumnsScript("SerenityData.Products")]
    [BasedOnRow(typeof(ProductsRow), CheckNames = true)]
    public class ProductsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Width(30)]
        public int ProductId { get; set; }
        [EditLink, Width(120)]
        public string ProductName { get; set; }
        [Width(120)]
        public string CategoryCategoryName { get; set; }
        [Width(120)]
        public string SupplierSupplierName { get; set; }
        [Width(120)]
        public decimal UnitPrice { get; set; }
        [Width(120)]
        public string TenantTenantName { get; set; }
    }
}