using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Forms
{
    [FormScript("SerenityData.Tenants")]
    [BasedOnRow(typeof(TenantsRow), CheckNames = true)]
    public class TenantsForm
    {
        [MediumHalfWidth]
        public string TenantName { get; set; }
    }
}