using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Columns
{
    [ColumnsScript("SerenityData.Software")]
    [BasedOnRow(typeof(SoftwareRow), CheckNames = true)]
    public class SoftwareColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Width(30)]
        public int DeliveryId { get; set; }
        [EditLink, Width(120)]
        public string ProductName { get; set; }
        [Width(120)]
        public DateTime DeliveredOn { get; set; }
        [Width(120)]
        public string TenantTenantName { get; set; }
    }
}