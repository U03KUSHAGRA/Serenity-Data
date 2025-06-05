using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Forms
{
    [FormScript("SerenityData.Suppliers")]
    [BasedOnRow(typeof(SuppliersRow), CheckNames = true)]
    public class SuppliersForm
    {
        [MediumHalfWidth(UntilNext =true)]
        public string SupplierName { get; set; }
        public int TenantId { get; set; }
    }
}