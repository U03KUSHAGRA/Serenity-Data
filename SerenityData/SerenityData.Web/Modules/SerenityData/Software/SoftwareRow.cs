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
    [ConnectionKey("SerenityData"), Module("SerenityData"), TableName("[dbo].[Software]")]
    [DisplayName("Software"), InstanceName("Software")]
    [ReadPermission(SerenityDataPermissionKeys.Software.View)]
    [ModifyPermission(SerenityDataPermissionKeys.Software.Modify)]
    [DeletePermission(SerenityDataPermissionKeys.Software.Delete)]
    public sealed class SoftwareRow : Row<SoftwareRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Delivery Id"), Column("DeliveryID"), Identity, IdProperty]
        public int? DeliveryId
        {
            get => fields.DeliveryId[this];
            set => fields.DeliveryId[this] = value;
        }

        [DisplayName("Product Name"), Size(100), QuickSearch, NameProperty]
        public string ProductName
        {
            get => fields.ProductName[this];
            set => fields.ProductName[this] = value;
        }

        [DisplayName("Delivered On")]
        public DateTime? DeliveredOn
        {
            get => fields.DeliveredOn[this];
            set => fields.DeliveredOn[this] = value;
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

        public SoftwareRow()
            : base()
        {
        }

        public SoftwareRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field DeliveryId;
            public StringField ProductName;
            public DateTimeField DeliveredOn;
            public Int32Field TenantId;

            public StringField TenantTenantName;
        }
    }
}
