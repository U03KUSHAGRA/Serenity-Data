using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Forms
{
    [FormScript("SerenityData.StockNames")]
    [BasedOnRow(typeof(StockNamesRow), CheckNames = true)]
    public class StockNamesForm
    {
        [MediumHalfWidth(UntilNext =true)]
        public string LabelName { get; set; }
        public int TenantId { get; set; }
    }
}