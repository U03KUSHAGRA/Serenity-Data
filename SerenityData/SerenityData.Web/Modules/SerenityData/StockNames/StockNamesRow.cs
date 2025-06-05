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
    [ConnectionKey("SerenityData"), Module("SerenityData"), TableName("[dbo].[StockNames]")]
    [DisplayName("Stock Names"), InstanceName("Stock Names")]
    [ReadPermission(SerenityDataPermissionKeys.StockNames.View)]
    [ModifyPermission(SerenityDataPermissionKeys.StockNames.Modify)]
    [DeletePermission(SerenityDataPermissionKeys.StockNames.Delete)]
    public sealed class StockNamesRow : Row<StockNamesRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Label Id"), Column("LabelID"), Identity, IdProperty]
        public int? LabelId
        {
            get => fields.LabelId[this];
            set => fields.LabelId[this] = value;
        }

        [DisplayName("Label Name"), Size(100), QuickSearch, NameProperty]
        public string LabelName
        {
            get => fields.LabelName[this];
            set => fields.LabelName[this] = value;
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

        public StockNamesRow()
            : base()
        {
        }

        public StockNamesRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field LabelId;
            public StringField LabelName;
            public Int32Field TenantId;

            public StringField TenantTenantName;
        }
    }
}
