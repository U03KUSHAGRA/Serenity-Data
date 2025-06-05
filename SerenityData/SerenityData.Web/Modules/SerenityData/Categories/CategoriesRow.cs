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
    [ConnectionKey("SerenityData"), Module("SerenityData"), TableName("[dbo].[Categories]")]
    [DisplayName("Categories"), InstanceName("Categories")]
    [ReadPermission(SerenityDataPermissionKeys.Categories.View)]
    [ModifyPermission(SerenityDataPermissionKeys.Categories.Modify)]
    [DeletePermission(SerenityDataPermissionKeys.Categories.Delete)]
    public sealed class CategoriesRow : Row<CategoriesRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Category Id"), Column("CategoryID"), Identity, IdProperty]
        public int? CategoryId
        {
            get => fields.CategoryId[this];
            set => fields.CategoryId[this] = value;
        }

        [DisplayName("Category Name"), Size(100), NotNull, QuickSearch, NameProperty]
        public string CategoryName
        {
            get => fields.CategoryName[this];
            set => fields.CategoryName[this] = value;
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

        public CategoriesRow()
            : base()
        {
        }

        public CategoriesRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CategoryId;
            public StringField CategoryName;
            public Int32Field TenantId;

            public StringField TenantTenantName;
        }
    }
}
