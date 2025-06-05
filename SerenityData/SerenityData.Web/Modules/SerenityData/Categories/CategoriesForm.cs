using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Forms
{
    [FormScript("SerenityData.Categories")]
    [BasedOnRow(typeof(CategoriesRow), CheckNames = true)]
    public class CategoriesForm
    {
        [MediumHalfWidth(UntilNext =true)]
        public string CategoryName { get; set; }
        public int TenantId { get; set; }
    }
}