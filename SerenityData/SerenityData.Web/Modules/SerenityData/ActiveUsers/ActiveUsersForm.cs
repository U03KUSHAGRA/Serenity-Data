using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Forms
{
    [FormScript("SerenityData.ActiveUsers")]
    [BasedOnRow(typeof(ActiveUsersRow), CheckNames = true)]
    public class ActiveUsersForm
    {
        [MediumHalfWidth(UntilNext =true)]
        public string Email { get; set; }
        public int TenantId { get; set; }
    }
}