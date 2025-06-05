using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Columns
{
    [ColumnsScript("SerenityData.TotalSales")]
    [BasedOnRow(typeof(TotalSalesRow), CheckNames = true)]
    public class TotalSalesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Width(30)]
        public int SaleId { get; set; }
        [Width(60)]
        public DateTime ReportDate { get; set; }
        [Width(120)]
        public decimal TotalAmount { get; set; }
        [Width(120)]
        public string TenantTenantName { get; set; }
    }
}