using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenityData.SerenityData.Columns
{
    [ColumnsScript("SerenityData.ActiveUsers")]
    [BasedOnRow(typeof(ActiveUsersRow), CheckNames = true)]
    public class ActiveUsersColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Width(30)]
        public int UserId { get; set; }

        [EditLink, Width(120)]
        public string Email { get; set; }
        [Width(120)]
        public string TenantTenantName { get; set; }
    }
}