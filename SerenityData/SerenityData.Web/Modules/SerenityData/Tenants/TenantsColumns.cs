using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Columns
{
    [ColumnsScript("SerenityData.Tenants")]
    [BasedOnRow(typeof(TenantsRow), CheckNames = true)]
    public class TenantsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Width(30)]
        public int TenantId { get; set; }
        [EditLink, Width(120)]
        public string TenantName { get; set; }
    }
}