using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Forms
{
    [FormScript("SerenityData.StockTransactions")]
    [BasedOnRow(typeof(StockTransactionsRow), CheckNames = true)]
    public class StockTransactionsForm
    {
        [MediumHalfLargeThirdWidth(UntilNext =true)]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public int TenantId { get; set; }
    }
}