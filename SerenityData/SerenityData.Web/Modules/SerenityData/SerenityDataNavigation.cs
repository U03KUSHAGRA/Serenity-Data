using Serenity.Navigation;
using MyPages = SerenityData.SerenityData.Pages;

[assembly: NavigationLink(int.MaxValue, "SerenityData/Active Users", typeof(MyPages.ActiveUsersController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "SerenityData/Categories", typeof(MyPages.CategoriesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "SerenityData/Products", typeof(MyPages.ProductsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "SerenityData/Software", typeof(MyPages.SoftwareController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "SerenityData/Stock Names", typeof(MyPages.StockNamesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "SerenityData/Stock Transactions", typeof(MyPages.StockTransactionsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "SerenityData/Suppliers", typeof(MyPages.SuppliersController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "SerenityData/Tenants", typeof(MyPages.TenantsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "SerenityData/Total Sales", typeof(MyPages.TotalSalesController), icon: null)]