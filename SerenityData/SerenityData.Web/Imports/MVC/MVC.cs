
namespace MVC
{
    public static class Views
    {
        public static class Administration
        {
            public static class Language
            {
                public const string LanguageIndex = "~/Modules/Administration/Language/LanguageIndex.cshtml";
            }

            public static class Role
            {
                public const string RoleIndex = "~/Modules/Administration/Role/RoleIndex.cshtml";
            }

            public static class Translation
            {
                public const string TranslationIndex = "~/Modules/Administration/Translation/TranslationIndex.cshtml";
            }

            public static class User
            {
                public const string UserIndex = "~/Modules/Administration/User/UserIndex.cshtml";
            }

        }

        public static class Common
        {
            public static class Dashboard
            {
                public const string DashboardIndex = "~/Modules/Common/Dashboard/DashboardIndex.cshtml";
                public const string Index2 = "~/Modules/Common/Dashboard/Index2.cshtml";
            }
        }

        public static class Errors
        {
            public const string AccessDenied = "~/Views/Errors/AccessDenied.cshtml";
            public const string ValidationError = "~/Views/Errors/ValidationError.cshtml";
        }

        public static class Membership
        {
            public static class Account
            {
                public const string AccountLogin = "~/Modules/Membership/Account/AccountLogin.cshtml";
                public static class ChangePassword
                {
                    public const string AccountChangePassword = "~/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml";
                }

                public static class ForgotPassword
                {
                    public const string AccountForgotPassword = "~/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml";
                }

                public static class ResetPassword
                {
                    public const string AccountResetPassword = "~/Modules/Membership/Account/ResetPassword/AccountResetPassword.cshtml";
                    public const string AccountResetPasswordEmail = "~/Modules/Membership/Account/ResetPassword/AccountResetPasswordEmail.cshtml";
                }

                public static class SignUp
                {
                    public const string AccountActivateEmail = "~/Modules/Membership/Account/SignUp/AccountActivateEmail.cshtml";
                    public const string AccountSignUp = "~/Modules/Membership/Account/SignUp/AccountSignUp.cshtml";
                }
            }

        }

        public static class SerenityData
        {
            public static class ActiveUsers
            {
                public const string ActiveUsersIndex = "~/Modules/SerenityData/ActiveUsers/ActiveUsersIndex.cshtml";
            }

            public static class Categories
            {
                public const string CategoriesIndex = "~/Modules/SerenityData/Categories/CategoriesIndex.cshtml";
            }

            public static class Products
            {
                public const string ProductsIndex = "~/Modules/SerenityData/Products/ProductsIndex.cshtml";
            }

            public static class Software
            {
                public const string SoftwareIndex = "~/Modules/SerenityData/Software/SoftwareIndex.cshtml";
            }

            public static class StockNames
            {
                public const string StockNamesIndex = "~/Modules/SerenityData/StockNames/StockNamesIndex.cshtml";
            }

            public static class StockTransactions
            {
                public const string StockTransactionsIndex = "~/Modules/SerenityData/StockTransactions/StockTransactionsIndex.cshtml";
            }

            public static class Suppliers
            {
                public const string SuppliersIndex = "~/Modules/SerenityData/Suppliers/SuppliersIndex.cshtml";
            }

            public static class Tenants
            {
                public const string TenantsIndex = "~/Modules/SerenityData/Tenants/TenantsIndex.cshtml";
            }

            public static class TotalSales
            {
                public const string TotalSalesIndex = "~/Modules/SerenityData/TotalSales/TotalSalesIndex.cshtml";
            }
        }

        public static class Shared
        {
            public const string _Layout = "~/Views/Shared/_Layout.cshtml";
            public const string _LayoutHead = "~/Views/Shared/_LayoutHead.cshtml";
            public const string _LayoutNoNavigation = "~/Views/Shared/_LayoutNoNavigation.cshtml";
            public const string _Sidebar = "~/Views/Shared/_Sidebar.cshtml";
            public const string Error = "~/Views/Shared/Error.cshtml";
        }

    }
}
