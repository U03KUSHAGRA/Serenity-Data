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
    [ConnectionKey("SerenityData"), Module("SerenityData"), TableName("[dbo].[Suppliers]")]
    [DisplayName("Suppliers"), InstanceName("Suppliers")]
    [ReadPermission(SerenityDataPermissionKeys.Suppliers.View)]
    [ModifyPermission(SerenityDataPermissionKeys.Suppliers.Modify)]
    [DeletePermission(SerenityDataPermissionKeys.Suppliers.Delete)]
    public sealed class SuppliersRow : Row<SuppliersRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Supplier Id"), Column("SupplierID"), Identity, IdProperty]
        public int? SupplierId
        {
            get => fields.SupplierId[this];
            set => fields.SupplierId[this] = value;
        }

        [DisplayName("Supplier Name"), Size(100), QuickSearch, NameProperty]
        public string SupplierName
        {
            get => fields.SupplierName[this];
            set => fields.SupplierName[this] = value;
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

        public SuppliersRow()
            : base()
        {
        }

        public SuppliersRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field SupplierId;
            public StringField SupplierName;
            public Int32Field TenantId;

            public StringField TenantTenantName;
        }
    }
}
