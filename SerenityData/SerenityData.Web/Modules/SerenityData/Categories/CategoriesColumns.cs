using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Columns
{
    [ColumnsScript("SerenityData.Categories")]
    [BasedOnRow(typeof(CategoriesRow), CheckNames = true)]
    public class CategoriesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Width(30)]
        public int CategoryId { get; set; }
        [EditLink, Width(120)]
        public string CategoryName { get; set; }
        [Width(120)]
        public string TenantTenantName { get; set; }
    }
}