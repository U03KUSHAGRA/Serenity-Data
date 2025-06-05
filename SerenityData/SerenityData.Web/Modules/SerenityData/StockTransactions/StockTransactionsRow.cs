using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;
using System.Transactions;
using VanilaProject.Modules.SerenityData;

namespace SerenityData.SerenityData
{
    [ConnectionKey("SerenityData"), Module("SerenityData"), TableName("[dbo].[StockTransactions]")]
    [DisplayName("Stock Transactions"), InstanceName("Stock Transactions")]
    [ReadPermission(SerenityDataPermissionKeys.StockTransactions.View)]
    [ModifyPermission(SerenityDataPermissionKeys.StockTransactions.Modify)]
    [DeletePermission(SerenityDataPermissionKeys.StockTransactions.Delete)]
    public sealed class StockTransactionsRow : Row<StockTransactionsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Transaction Id"), Column("TransactionID"), Identity, IdProperty]
        public int? TransactionId
        {
            get => fields.TransactionId[this];
            set => fields.TransactionId[this] = value;
        }

        [DisplayName("Product"), Column("ProductID"), ForeignKey("[dbo].[Products]", "ProductID"), LeftJoin("jProduct"), TextualField("ProductProductName")]
        public int? ProductId
        {
            get => fields.ProductId[this];
            set => fields.ProductId[this] = value;
        }

        [DisplayName("Quantity")]
        public int? Quantity
        {
            get => fields.Quantity[this];
            set => fields.Quantity[this] = value;
        }

        [DisplayName("Type"), Size(10), QuickSearch, NameProperty]
        public string Type
        {
            get => fields.Type[this];
            set => fields.Type[this] = value;
        }

        [DisplayName("Date")]
        public DateTime? Date
        {
            get => fields.Date[this];
            set => fields.Date[this] = value;
        }

        [DisplayName("Tenant"), Column("TenantID"), ForeignKey("[dbo].[Tenants]", "TenantID"), LeftJoin("jTenant"), TextualField("TenantTenantName")]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Product Name"), Expression("jProduct.[ProductName]")]
        public string ProductProductName
        {
            get => fields.ProductProductName[this];
            set => fields.ProductProductName[this] = value;
        }

        [DisplayName("Product Category Id"), Expression("jProduct.[CategoryID]")]
        public int? ProductCategoryId
        {
            get => fields.ProductCategoryId[this];
            set => fields.ProductCategoryId[this] = value;
        }

        [DisplayName("Product Supplier Id"), Expression("jProduct.[SupplierID]")]
        public int? ProductSupplierId
        {
            get => fields.ProductSupplierId[this];
            set => fields.ProductSupplierId[this] = value;
        }

        [DisplayName("Product Unit Price"), Expression("jProduct.[UnitPrice]")]
        public decimal? ProductUnitPrice
        {
            get => fields.ProductUnitPrice[this];
            set => fields.ProductUnitPrice[this] = value;
        }

        [DisplayName("Product Tenant Id"), Expression("jProduct.[TenantID]")]
        public int? ProductTenantId
        {
            get => fields.ProductTenantId[this];
            set => fields.ProductTenantId[this] = value;
        }

        [DisplayName("Tenant Name"), Expression("jTenant.[TenantName]")]
        public string TenantTenantName
        {
            get => fields.TenantTenantName[this];
            set => fields.TenantTenantName[this] = value;
        }

        public StockTransactionsRow()
            : base()
        {
        }

        public StockTransactionsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field TransactionId;
            public Int32Field ProductId;
            public Int32Field Quantity;
            public StringField Type;
            public DateTimeField Date;
            public Int32Field TenantId;

            public StringField ProductProductName;
            public Int32Field ProductCategoryId;
            public Int32Field ProductSupplierId;
            public DecimalField ProductUnitPrice;
            public Int32Field ProductTenantId;

            public StringField TenantTenantName;
        }
    }
}
