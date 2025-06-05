using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Columns
{
    [ColumnsScript("SerenityData.StockNames")]
    [BasedOnRow(typeof(StockNamesRow), CheckNames = true)]
    public class StockNamesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Width(30)]
        public int LabelId { get; set; }
        [EditLink, Width(120)]
        public string LabelName { get; set; }
        [Width(120)]
        public string TenantTenantName { get; set; }
    }
}