using System.ComponentModel;
using Serenity.ComponentModel;

namespace VanilaProject.Modules.SerenityData
{
    [NestedPermissionKeys]
    [DisplayName("SerenityData")]
    public class SerenityDataPermissionKeys
    {
        [DisplayName("ActiveUsers")]
        public class ActiveUsers
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "SerenityData:ActiveUsers:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "SerenityData:ActiveUsers:Modify";
            public const string View = "SerenityData:ActiveUsers:View";
        }
        [DisplayName("Categories")]
        public class Categories
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "SerenityData:Categories:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "SerenityData:Categories:Modify";
            public const string View = "SerenityData:Categories:View";
        }
        [DisplayName("Products")]
        public class Products
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "SerenityData:Products:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "SerenityData:Products:Modify";
            public const string View = "SerenityData:Products:View";
        }
        [DisplayName("Software")]
        public class Software
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "SerenityData:Software:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "SerenityData:Software:Modify";
            public const string View = "SerenityData:Software:View";
        }
        [DisplayName("StockNames")]
        public class StockNames
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "SerenityData:StockNames:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "SerenityData:StockNames:Modify";
            public const string View = "SerenityData:StockNames:View";
        }
        [DisplayName("StockTransactions")]
        public class StockTransactions
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "SerenityData:StockTransactions:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "SerenityData:StockTransactions:Modify";
            public const string View = "SerenityData:StockTransactions:View";
        }
        [DisplayName("Suppliers")]
        public class Suppliers
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "SerenityData:Suppliers:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "SerenityData:Suppliers:Modify";
            public const string View = "SerenityData:Suppliers:View";
        }
        [DisplayName("Tenants")]
        public class Tenants
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "SerenityData:Tenants:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "SerenityData:Tenants:Modify";
            public const string View = "SerenityData:Tenants:View";
        }
        [DisplayName("TotalSales")]
        public class TotalSales
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "SerenityData:TotalSales:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "SerenityData:TotalSales:Modify";
            public const string View = "SerenityData:TotalSales:View";
        }
        [Description("[General]")]
        public const string General = "SerenityData:General";
    }
}
