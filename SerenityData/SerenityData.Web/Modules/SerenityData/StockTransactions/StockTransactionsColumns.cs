using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Columns
{
    [ColumnsScript("SerenityData.StockTransactions")]
    [BasedOnRow(typeof(StockTransactionsRow), CheckNames = true)]
    public class StockTransactionsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Width(30)]
        public int TransactionId { get; set; }
        [Width(120)]
        public string ProductProductName { get; set; }
        [Width(60)]
        public int Quantity { get; set; }
        [EditLink, Width(120)]
        public string Type { get; set; }
        [Width(120)]
        public DateTime Date { get; set; }
        [Width(120)]
        public string TenantTenantName { get; set; }
    }
}