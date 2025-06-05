using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;
using VanilaProject.Modules.SerenityData;

namespace SerenityData.SerenityData
{
    [ConnectionKey("SerenityData"), Module("SerenityData"), TableName("[dbo].[Tenants]")]
    [DisplayName("Tenants"), InstanceName("Tenants")]
    [ReadPermission(SerenityDataPermissionKeys.Tenants.View)]
    [ModifyPermission(SerenityDataPermissionKeys.Tenants.Modify)]
    [DeletePermission(SerenityDataPermissionKeys.Tenants.Delete)]
    public sealed class TenantsRow : Row<TenantsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Tenant Id"), Column("TenantID"), PrimaryKey, NotNull, IdProperty]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Tenant Name"), Size(100), NotNull, QuickSearch, NameProperty]
        public string TenantName
        {
            get => fields.TenantName[this];
            set => fields.TenantName[this] = value;
        }

        public TenantsRow()
            : base()
        {
        }

        public TenantsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field TenantId;
            public StringField TenantName;
        }
    }
}
