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
    [ConnectionKey("SerenityData"), Module("SerenityData"), TableName("[dbo].[TotalSales]")]
    [DisplayName("Total Sales"), InstanceName("Total Sales")]
    [ReadPermission(SerenityDataPermissionKeys.TotalSales.View)]
    [ModifyPermission(SerenityDataPermissionKeys.TotalSales.Modify)]
    [DeletePermission(SerenityDataPermissionKeys.TotalSales.Delete)]
    public sealed class TotalSalesRow : Row<TotalSalesRow.RowFields>, IIdRow
    {
        [DisplayName("Sale Id"), Column("SaleID"), Identity, IdProperty]
        public int? SaleId
        {
            get => fields.SaleId[this];
            set => fields.SaleId[this] = value;
        }

        [DisplayName("Report Date")]
        public DateTime? ReportDate
        {
            get => fields.ReportDate[this];
            set => fields.ReportDate[this] = value;
        }

        [DisplayName("Total Amount"), Size(12), Scale(2)]
        public decimal? TotalAmount
        {
            get => fields.TotalAmount[this];
            set => fields.TotalAmount[this] = value;
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

        public TotalSalesRow()
            : base()
        {
        }

        public TotalSalesRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field SaleId;
            public DateTimeField ReportDate;
            public DecimalField TotalAmount;
            public Int32Field TenantId;

            public StringField TenantTenantName;
        }
    }
}
