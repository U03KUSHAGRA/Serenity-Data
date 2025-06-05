using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Forms
{
    [FormScript("SerenityData.TotalSales")]
    [BasedOnRow(typeof(TotalSalesRow), CheckNames = true)]
    public class TotalSalesForm
    {
        [MediumHalfLargeThirdWidth(UntilNext =true)]
        public DateTime ReportDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int TenantId { get; set; }
    }
}