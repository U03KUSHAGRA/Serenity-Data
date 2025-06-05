using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Columns
{
    [ColumnsScript("SerenityData.Suppliers")]
    [BasedOnRow(typeof(SuppliersRow), CheckNames = true)]
    public class SuppliersColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Width(30)]
        public int SupplierId { get; set; }
        [EditLink, Width(120)]
        public string SupplierName { get; set; }
        [Width(120)]
        public string TenantTenantName { get; set; }
    }
}