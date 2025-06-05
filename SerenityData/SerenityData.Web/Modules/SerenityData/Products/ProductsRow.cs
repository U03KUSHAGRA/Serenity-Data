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
    [ConnectionKey("SerenityData"), Module("SerenityData"), TableName("[dbo].[Products]")]
    [DisplayName("Products"), InstanceName("Products")]
    [ReadPermission(SerenityDataPermissionKeys.Products.View)]
    [ModifyPermission(SerenityDataPermissionKeys.Products.Modify)]
    [DeletePermission(SerenityDataPermissionKeys.Products.Delete)]
    public sealed class ProductsRow : Row<ProductsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Product Id"), Column("ProductID"), Identity, IdProperty]
        public int? ProductId
        {
            get => fields.ProductId[this];
            set => fields.ProductId[this] = value;
        }

        [DisplayName("Product Name"), Size(100), QuickSearch, NameProperty]
        public string ProductName
        {
            get => fields.ProductName[this];
            set => fields.ProductName[this] = value;
        }

        [DisplayName("Category"), Column("CategoryID"), ForeignKey("[dbo].[Categories]", "CategoryID"), LeftJoin("jCategory"), TextualField("CategoryCategoryName")]
        public int? CategoryId
        {
            get => fields.CategoryId[this];
            set => fields.CategoryId[this] = value;
        }

        [DisplayName("Supplier"), Column("SupplierID"), ForeignKey("[dbo].[Suppliers]", "SupplierID"), LeftJoin("jSupplier"), TextualField("SupplierSupplierName")]
        public int? SupplierId
        {
            get => fields.SupplierId[this];
            set => fields.SupplierId[this] = value;
        }

        [DisplayName("Unit Price"), Size(10), Scale(2)]
        public decimal? UnitPrice
        {
            get => fields.UnitPrice[this];
            set => fields.UnitPrice[this] = value;
        }

        [DisplayName("Tenant"), Column("TenantID"), ForeignKey("[dbo].[Tenants]", "TenantID"), LeftJoin("jTenant"), TextualField("TenantTenantName")]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Category Name"), Expression("jCategory.[CategoryName]")]
        public string CategoryCategoryName
        {
            get => fields.CategoryCategoryName[this];
            set => fields.CategoryCategoryName[this] = value;
        }

        [DisplayName("Category Tenant Id"), Expression("jCategory.[TenantID]")]
        public int? CategoryTenantId
        {
            get => fields.CategoryTenantId[this];
            set => fields.CategoryTenantId[this] = value;
        }

        [DisplayName("Supplier Name"), Expression("jSupplier.[SupplierName]")]
        public string SupplierSupplierName
        {
            get => fields.SupplierSupplierName[this];
            set => fields.SupplierSupplierName[this] = value;
        }

        [DisplayName("Supplier Tenant Id"), Expression("jSupplier.[TenantID]")]
        public int? SupplierTenantId
        {
            get => fields.SupplierTenantId[this];
            set => fields.SupplierTenantId[this] = value;
        }

        [DisplayName("Tenant Name"), Expression("jTenant.[TenantName]")]
        public string TenantTenantName
        {
            get => fields.TenantTenantName[this];
            set => fields.TenantTenantName[this] = value;
        }

        public ProductsRow()
            : base()
        {
        }

        public ProductsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ProductId;
            public StringField ProductName;
            public Int32Field CategoryId;
            public Int32Field SupplierId;
            public DecimalField UnitPrice;
            public Int32Field TenantId;

            public StringField CategoryCategoryName;
            public Int32Field CategoryTenantId;

            public StringField SupplierSupplierName;
            public Int32Field SupplierTenantId;

            public StringField TenantTenantName;
        }
    }
}
