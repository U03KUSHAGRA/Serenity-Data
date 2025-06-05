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
    [ConnectionKey("SerenityData"), Module("SerenityData"), TableName("[dbo].[ActiveUsers]")]
    [DisplayName("Active Users"), InstanceName("Active Users")]
    [ReadPermission(SerenityDataPermissionKeys.ActiveUsers.View)]
    [ModifyPermission(SerenityDataPermissionKeys.ActiveUsers.Modify)]
    [DeletePermission(SerenityDataPermissionKeys.ActiveUsers.Delete)]
    public sealed class ActiveUsersRow : Row<ActiveUsersRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("User Id"), Column("UserID"), Identity, IdProperty]
        public int? UserId
        {
            get => fields.UserId[this];
            set => fields.UserId[this] = value;
        }

        [DisplayName("Email"), Size(100), QuickSearch, NameProperty]
        public string Email
        {
            get => fields.Email[this];
            set => fields.Email[this] = value;
        }

        [DisplayName("Tenant"), Column("TenantID"), ForeignKey("[dbo].[Tenants]", "TenantID"), LeftJoin("jTenant"), TextualField("TenantTenantName")]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Tenant Name"), Expression("jTenant.[TenantName]")]
        public string TenantTenantName
        {
            get => fields.TenantTenantName[this];
            set => fields.TenantTenantName[this] = value;
        }

        public ActiveUsersRow()
            : base()
        {
        }

        public ActiveUsersRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field UserId;
            public StringField Email;
            public Int32Field TenantId;

            public StringField TenantTenantName;
        }
    }
}
