using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Forms
{
    [FormScript("SerenityData.Software")]
    [BasedOnRow(typeof(SoftwareRow), CheckNames = true)]
    public class SoftwareForm
    {
        [MediumHalfLargeThirdWidth(UntilNext =true)]
        public string ProductName { get; set; }
        public DateTime DeliveredOn { get; set; }
        public int TenantId { get; set; }
    }
}