/// <reference types="serenity.corelib" />
/// <reference types="jquery" />
/// <reference types="jquery.blockui" />
/// <reference types="jquery.validation" />
/// <reference types="jqueryui" />
/// <reference types="serenity.pro.ui" />
/// <reference types="serenity.pro.extensions" />
declare namespace SerenityData.Administration {
    class LanguageColumns {
        static columnsKey: string;
    }
}
declare namespace SerenityData.Administration {
    interface LanguageForm {
        LanguageId: Serenity.StringEditor;
        LanguageName: Serenity.StringEditor;
    }
    class LanguageForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.Administration {
    interface LanguageRow {
        Id?: number;
        LanguageId?: string;
        LanguageName?: string;
    }
    namespace LanguageRow {
        const idProperty = "Id";
        const nameProperty = "LanguageName";
        const localTextPrefix = "Administration.Language";
        const lookupKey = "Administration.Language";
        function getLookup(): Q.Lookup<LanguageRow>;
        const deletePermission = "Administration:Translation";
        const insertPermission = "Administration:Translation";
        const readPermission = "Administration:Translation";
        const updatePermission = "Administration:Translation";
        const enum Fields {
            Id = "Id",
            LanguageId = "LanguageId",
            LanguageName = "LanguageName"
        }
    }
}
declare namespace SerenityData.Administration {
    namespace LanguageService {
        const baseUrl = "Administration/Language";
        function Create(request: Serenity.SaveRequest<LanguageRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<LanguageRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<LanguageRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LanguageRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Administration/Language/Create",
            Update = "Administration/Language/Update",
            Delete = "Administration/Language/Delete",
            Retrieve = "Administration/Language/Retrieve",
            List = "Administration/Language/List"
        }
    }
}
declare namespace SerenityData.Administration {
    namespace PermissionKeys {
        const Security = "Administration:Security";
        const Translation = "Administration:Translation";
    }
}
declare namespace SerenityData.Administration {
    class RoleColumns {
        static columnsKey: string;
    }
}
declare namespace SerenityData.Administration {
    interface RoleForm {
        RoleName: Serenity.StringEditor;
    }
    class RoleForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.Administration {
    interface RolePermissionListRequest extends Serenity.ServiceRequest {
        RoleID?: number;
        Module?: string;
        Submodule?: string;
    }
}
declare namespace SerenityData.Administration {
    interface RolePermissionListResponse extends Serenity.ListResponse<string> {
    }
}
declare namespace SerenityData.Administration {
    interface RolePermissionRow {
        RolePermissionId?: number;
        RoleId?: number;
        PermissionKey?: string;
        RoleRoleName?: string;
    }
    namespace RolePermissionRow {
        const idProperty = "RolePermissionId";
        const nameProperty = "PermissionKey";
        const localTextPrefix = "Administration.RolePermission";
        const deletePermission = "Administration:Security";
        const insertPermission = "Administration:Security";
        const readPermission = "Administration:Security";
        const updatePermission = "Administration:Security";
        const enum Fields {
            RolePermissionId = "RolePermissionId",
            RoleId = "RoleId",
            PermissionKey = "PermissionKey",
            RoleRoleName = "RoleRoleName"
        }
    }
}
declare namespace SerenityData.Administration {
    namespace RolePermissionService {
        const baseUrl = "Administration/RolePermission";
        function Update(request: RolePermissionUpdateRequest, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: RolePermissionListRequest, onSuccess?: (response: RolePermissionListResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Update = "Administration/RolePermission/Update",
            List = "Administration/RolePermission/List"
        }
    }
}
declare namespace SerenityData.Administration {
    interface RolePermissionUpdateRequest extends Serenity.ServiceRequest {
        RoleID?: number;
        Module?: string;
        Submodule?: string;
        Permissions?: string[];
    }
}
declare namespace SerenityData.Administration {
    interface RoleRow {
        RoleId?: number;
        RoleName?: string;
    }
    namespace RoleRow {
        const idProperty = "RoleId";
        const nameProperty = "RoleName";
        const localTextPrefix = "Administration.Role";
        const lookupKey = "Administration.Role";
        function getLookup(): Q.Lookup<RoleRow>;
        const deletePermission = "Administration:Security";
        const insertPermission = "Administration:Security";
        const readPermission = "Administration:Security";
        const updatePermission = "Administration:Security";
        const enum Fields {
            RoleId = "RoleId",
            RoleName = "RoleName"
        }
    }
}
declare namespace SerenityData.Administration {
    namespace RoleService {
        const baseUrl = "Administration/Role";
        function Create(request: Serenity.SaveRequest<RoleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<RoleRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RoleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RoleRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Administration/Role/Create",
            Update = "Administration/Role/Update",
            Delete = "Administration/Role/Delete",
            Retrieve = "Administration/Role/Retrieve",
            List = "Administration/Role/List"
        }
    }
}
declare namespace SerenityData.Administration {
    interface TranslationItem {
        Key?: string;
        SourceText?: string;
        TargetText?: string;
        CustomText?: string;
    }
}
declare namespace SerenityData.Administration {
    interface TranslationListRequest extends Serenity.ListRequest {
        SourceLanguageID?: string;
        TargetLanguageID?: string;
    }
}
declare namespace SerenityData.Administration {
    namespace TranslationService {
        const baseUrl = "Administration/Translation";
        function List(request: TranslationListRequest, onSuccess?: (response: Serenity.ListResponse<TranslationItem>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: TranslationUpdateRequest, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            List = "Administration/Translation/List",
            Update = "Administration/Translation/Update"
        }
    }
}
declare namespace SerenityData.Administration {
    interface TranslationUpdateRequest extends Serenity.ServiceRequest {
        TargetLanguageID?: string;
        Translations?: {
            [key: string]: string;
        };
    }
}
declare namespace SerenityData.Administration {
    class UserColumns {
        static columnsKey: string;
    }
}
declare namespace SerenityData.Administration {
    interface UserForm {
        Username: Serenity.StringEditor;
        DisplayName: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        UserImage: Serenity.ImageUploadEditor;
        Password: Serenity.PasswordEditor;
        PasswordConfirm: Serenity.PasswordEditor;
        Source: Serenity.StringEditor;
    }
    class UserForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.Administration {
    interface UserPermissionListRequest extends Serenity.ServiceRequest {
        UserID?: number;
        Module?: string;
        Submodule?: string;
    }
}
declare namespace SerenityData.Administration {
    interface UserPermissionRow {
        UserPermissionId?: number;
        UserId?: number;
        PermissionKey?: string;
        Granted?: boolean;
        Username?: string;
        User?: string;
    }
    namespace UserPermissionRow {
        const idProperty = "UserPermissionId";
        const nameProperty = "PermissionKey";
        const localTextPrefix = "Administration.UserPermission";
        const deletePermission = "Administration:Security";
        const insertPermission = "Administration:Security";
        const readPermission = "Administration:Security";
        const updatePermission = "Administration:Security";
        const enum Fields {
            UserPermissionId = "UserPermissionId",
            UserId = "UserId",
            PermissionKey = "PermissionKey",
            Granted = "Granted",
            Username = "Username",
            User = "User"
        }
    }
}
declare namespace SerenityData.Administration {
    namespace UserPermissionService {
        const baseUrl = "Administration/UserPermission";
        function Update(request: UserPermissionUpdateRequest, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: UserPermissionListRequest, onSuccess?: (response: Serenity.ListResponse<UserPermissionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ListRolePermissions(request: UserPermissionListRequest, onSuccess?: (response: Serenity.ListResponse<string>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ListPermissionKeys(request: Serenity.ServiceRequest, onSuccess?: (response: Serenity.ListResponse<string>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Update = "Administration/UserPermission/Update",
            List = "Administration/UserPermission/List",
            ListRolePermissions = "Administration/UserPermission/ListRolePermissions",
            ListPermissionKeys = "Administration/UserPermission/ListPermissionKeys"
        }
    }
}
declare namespace SerenityData.Administration {
    interface UserPermissionUpdateRequest extends Serenity.ServiceRequest {
        UserID?: number;
        Module?: string;
        Submodule?: string;
        Permissions?: UserPermissionRow[];
    }
}
declare namespace SerenityData.Administration {
    interface UserRoleListRequest extends Serenity.ServiceRequest {
        UserID?: number;
    }
}
declare namespace SerenityData.Administration {
    interface UserRoleListResponse extends Serenity.ListResponse<number> {
    }
}
declare namespace SerenityData.Administration {
    interface UserRoleRow {
        UserRoleId?: number;
        UserId?: number;
        RoleId?: number;
        Username?: string;
        User?: string;
    }
    namespace UserRoleRow {
        const idProperty = "UserRoleId";
        const localTextPrefix = "Administration.UserRole";
        const deletePermission = "Administration:Security";
        const insertPermission = "Administration:Security";
        const readPermission = "Administration:Security";
        const updatePermission = "Administration:Security";
        const enum Fields {
            UserRoleId = "UserRoleId",
            UserId = "UserId",
            RoleId = "RoleId",
            Username = "Username",
            User = "User"
        }
    }
}
declare namespace SerenityData.Administration {
    namespace UserRoleService {
        const baseUrl = "Administration/UserRole";
        function Update(request: UserRoleUpdateRequest, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: UserRoleListRequest, onSuccess?: (response: UserRoleListResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Update = "Administration/UserRole/Update",
            List = "Administration/UserRole/List"
        }
    }
}
declare namespace SerenityData.Administration {
    interface UserRoleUpdateRequest extends Serenity.ServiceRequest {
        UserID?: number;
        Roles?: number[];
    }
}
declare namespace SerenityData.Administration {
    interface UserRow {
        UserId?: number;
        Username?: string;
        Source?: string;
        PasswordHash?: string;
        PasswordSalt?: string;
        DisplayName?: string;
        Email?: string;
        UserImage?: string;
        LastDirectoryUpdate?: string;
        IsActive?: number;
        Password?: string;
        PasswordConfirm?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }
    namespace UserRow {
        const idProperty = "UserId";
        const isActiveProperty = "IsActive";
        const nameProperty = "Username";
        const localTextPrefix = "Administration.User";
        const lookupKey = "Administration.User";
        function getLookup(): Q.Lookup<UserRow>;
        const deletePermission = "Administration:Security";
        const insertPermission = "Administration:Security";
        const readPermission = "Administration:Security";
        const updatePermission = "Administration:Security";
        const enum Fields {
            UserId = "UserId",
            Username = "Username",
            Source = "Source",
            PasswordHash = "PasswordHash",
            PasswordSalt = "PasswordSalt",
            DisplayName = "DisplayName",
            Email = "Email",
            UserImage = "UserImage",
            LastDirectoryUpdate = "LastDirectoryUpdate",
            IsActive = "IsActive",
            Password = "Password",
            PasswordConfirm = "PasswordConfirm",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
declare namespace SerenityData.Administration {
    namespace UserService {
        const baseUrl = "Administration/User";
        function Create(request: Serenity.SaveRequest<UserRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<UserRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Undelete(request: Serenity.UndeleteRequest, onSuccess?: (response: Serenity.UndeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<UserRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<UserRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Administration/User/Create",
            Update = "Administration/User/Update",
            Delete = "Administration/User/Delete",
            Undelete = "Administration/User/Undelete",
            Retrieve = "Administration/User/Retrieve",
            List = "Administration/User/List"
        }
    }
}
declare namespace SerenityData {
    interface GetLastOrderNumberRequest extends Serenity.ServiceRequest {
        OrderNumber?: number;
    }
}
declare namespace SerenityData {
    interface GetNextOrderNumberResponse extends Serenity.ServiceResponse {
        OrderNumber?: number;
        Serial?: string;
    }
}
declare namespace SerenityData.Membership {
    interface ChangePasswordForm {
        OldPassword: Serenity.PasswordEditor;
        NewPassword: Serenity.PasswordEditor;
        ConfirmPassword: Serenity.PasswordEditor;
    }
    class ChangePasswordForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.Membership {
    interface ChangePasswordRequest extends Serenity.ServiceRequest {
        OldPassword?: string;
        NewPassword?: string;
        ConfirmPassword?: string;
    }
}
declare namespace SerenityData.Membership {
    interface ForgotPasswordForm {
        Email: Serenity.EmailAddressEditor;
    }
    class ForgotPasswordForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.Membership {
    interface ForgotPasswordRequest extends Serenity.ServiceRequest {
        Email?: string;
    }
}
declare namespace SerenityData.Membership {
    interface LoginForm {
        Username: Serenity.StringEditor;
        Password: Serenity.PasswordEditor;
    }
    class LoginForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.Membership {
    interface LoginRequest extends Serenity.ServiceRequest {
        Username?: string;
        Password?: string;
    }
}
declare namespace SerenityData.Membership {
    interface ResetPasswordForm {
        NewPassword: Serenity.PasswordEditor;
        ConfirmPassword: Serenity.PasswordEditor;
    }
    class ResetPasswordForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.Membership {
    interface ResetPasswordRequest extends Serenity.ServiceRequest {
        Token?: string;
        NewPassword?: string;
        ConfirmPassword?: string;
    }
}
declare namespace SerenityData.Membership {
    interface SignUpForm {
        DisplayName: Serenity.StringEditor;
        Email: Serenity.EmailAddressEditor;
        ConfirmEmail: Serenity.EmailAddressEditor;
        Password: Serenity.PasswordEditor;
        ConfirmPassword: Serenity.PasswordEditor;
    }
    class SignUpForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.Membership {
    interface SignUpRequest extends Serenity.ServiceRequest {
        DisplayName?: string;
        Email?: string;
        Password?: string;
    }
}
declare namespace SerenityData {
    interface ScriptUserDefinition {
        Username?: string;
        DisplayName?: string;
        IsAdmin?: boolean;
        Permissions?: {
            [key: string]: boolean;
        };
    }
}
declare namespace SerenityData.SerenityData {
    class ActiveUsersColumns {
        static columnsKey: string;
    }
}
declare namespace SerenityData.SerenityData {
    interface ActiveUsersForm {
        Email: Serenity.StringEditor;
        TenantId: Serenity.IntegerEditor;
    }
    class ActiveUsersForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.SerenityData {
    interface ActiveUsersRow {
        UserId?: number;
        Email?: string;
        TenantId?: number;
        TenantTenantName?: string;
    }
    namespace ActiveUsersRow {
        const idProperty = "UserId";
        const nameProperty = "Email";
        const localTextPrefix = "SerenityData.ActiveUsers";
        const deletePermission = "SerenityData:ActiveUsers:Delete";
        const insertPermission = "SerenityData:ActiveUsers:Modify";
        const readPermission = "SerenityData:ActiveUsers:View";
        const updatePermission = "SerenityData:ActiveUsers:Modify";
        const enum Fields {
            UserId = "UserId",
            Email = "Email",
            TenantId = "TenantId",
            TenantTenantName = "TenantTenantName"
        }
    }
}
declare namespace SerenityData.SerenityData {
    namespace ActiveUsersService {
        const baseUrl = "SerenityData/ActiveUsers";
        function Create(request: Serenity.SaveRequest<ActiveUsersRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ActiveUsersRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ActiveUsersRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ActiveUsersRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "SerenityData/ActiveUsers/Create",
            Update = "SerenityData/ActiveUsers/Update",
            Delete = "SerenityData/ActiveUsers/Delete",
            Retrieve = "SerenityData/ActiveUsers/Retrieve",
            List = "SerenityData/ActiveUsers/List"
        }
    }
}
declare namespace SerenityData.SerenityData {
    class CategoriesColumns {
        static columnsKey: string;
    }
}
declare namespace SerenityData.SerenityData {
    interface CategoriesForm {
        CategoryName: Serenity.StringEditor;
        TenantId: Serenity.IntegerEditor;
    }
    class CategoriesForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.SerenityData {
    interface CategoriesRow {
        CategoryId?: number;
        CategoryName?: string;
        TenantId?: number;
        TenantTenantName?: string;
    }
    namespace CategoriesRow {
        const idProperty = "CategoryId";
        const nameProperty = "CategoryName";
        const localTextPrefix = "SerenityData.Categories";
        const deletePermission = "SerenityData:Categories:Delete";
        const insertPermission = "SerenityData:Categories:Modify";
        const readPermission = "SerenityData:Categories:View";
        const updatePermission = "SerenityData:Categories:Modify";
        const enum Fields {
            CategoryId = "CategoryId",
            CategoryName = "CategoryName",
            TenantId = "TenantId",
            TenantTenantName = "TenantTenantName"
        }
    }
}
declare namespace SerenityData.SerenityData {
    namespace CategoriesService {
        const baseUrl = "SerenityData/Categories";
        function Create(request: Serenity.SaveRequest<CategoriesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<CategoriesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CategoriesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CategoriesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "SerenityData/Categories/Create",
            Update = "SerenityData/Categories/Update",
            Delete = "SerenityData/Categories/Delete",
            Retrieve = "SerenityData/Categories/Retrieve",
            List = "SerenityData/Categories/List"
        }
    }
}
declare namespace SerenityData.SerenityData {
    class ProductsColumns {
        static columnsKey: string;
    }
}
declare namespace SerenityData.SerenityData {
    interface ProductsForm {
        ProductName: Serenity.StringEditor;
        CategoryId: Serenity.IntegerEditor;
        SupplierId: Serenity.IntegerEditor;
        UnitPrice: Serenity.DecimalEditor;
        TenantId: Serenity.IntegerEditor;
    }
    class ProductsForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.SerenityData {
    interface ProductsRow {
        ProductId?: number;
        ProductName?: string;
        CategoryId?: number;
        SupplierId?: number;
        UnitPrice?: number;
        TenantId?: number;
        CategoryCategoryName?: string;
        CategoryTenantId?: number;
        SupplierSupplierName?: string;
        SupplierTenantId?: number;
        TenantTenantName?: string;
    }
    namespace ProductsRow {
        const idProperty = "ProductId";
        const nameProperty = "ProductName";
        const localTextPrefix = "SerenityData.Products";
        const deletePermission = "SerenityData:Products:Delete";
        const insertPermission = "SerenityData:Products:Modify";
        const readPermission = "SerenityData:Products:View";
        const updatePermission = "SerenityData:Products:Modify";
        const enum Fields {
            ProductId = "ProductId",
            ProductName = "ProductName",
            CategoryId = "CategoryId",
            SupplierId = "SupplierId",
            UnitPrice = "UnitPrice",
            TenantId = "TenantId",
            CategoryCategoryName = "CategoryCategoryName",
            CategoryTenantId = "CategoryTenantId",
            SupplierSupplierName = "SupplierSupplierName",
            SupplierTenantId = "SupplierTenantId",
            TenantTenantName = "TenantTenantName"
        }
    }
}
declare namespace SerenityData.SerenityData {
    namespace ProductsService {
        const baseUrl = "SerenityData/Products";
        function Create(request: Serenity.SaveRequest<ProductsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<ProductsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ProductsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ProductsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "SerenityData/Products/Create",
            Update = "SerenityData/Products/Update",
            Delete = "SerenityData/Products/Delete",
            Retrieve = "SerenityData/Products/Retrieve",
            List = "SerenityData/Products/List"
        }
    }
}
declare namespace SerenityData.SerenityData {
    class SoftwareColumns {
        static columnsKey: string;
    }
}
declare namespace SerenityData.SerenityData {
    interface SoftwareForm {
        ProductName: Serenity.StringEditor;
        DeliveredOn: Serenity.DateEditor;
        TenantId: Serenity.IntegerEditor;
    }
    class SoftwareForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.SerenityData {
    interface SoftwareRow {
        DeliveryId?: number;
        ProductName?: string;
        DeliveredOn?: string;
        TenantId?: number;
        TenantTenantName?: string;
    }
    namespace SoftwareRow {
        const idProperty = "DeliveryId";
        const nameProperty = "ProductName";
        const localTextPrefix = "SerenityData.Software";
        const deletePermission = "SerenityData:Software:Delete";
        const insertPermission = "SerenityData:Software:Modify";
        const readPermission = "SerenityData:Software:View";
        const updatePermission = "SerenityData:Software:Modify";
        const enum Fields {
            DeliveryId = "DeliveryId",
            ProductName = "ProductName",
            DeliveredOn = "DeliveredOn",
            TenantId = "TenantId",
            TenantTenantName = "TenantTenantName"
        }
    }
}
declare namespace SerenityData.SerenityData {
    namespace SoftwareService {
        const baseUrl = "SerenityData/Software";
        function Create(request: Serenity.SaveRequest<SoftwareRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<SoftwareRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<SoftwareRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<SoftwareRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "SerenityData/Software/Create",
            Update = "SerenityData/Software/Update",
            Delete = "SerenityData/Software/Delete",
            Retrieve = "SerenityData/Software/Retrieve",
            List = "SerenityData/Software/List"
        }
    }
}
declare namespace SerenityData.SerenityData {
    class StockNamesColumns {
        static columnsKey: string;
    }
}
declare namespace SerenityData.SerenityData {
    interface StockNamesForm {
        LabelName: Serenity.StringEditor;
        TenantId: Serenity.IntegerEditor;
    }
    class StockNamesForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.SerenityData {
    interface StockNamesRow {
        LabelId?: number;
        LabelName?: string;
        TenantId?: number;
        TenantTenantName?: string;
    }
    namespace StockNamesRow {
        const idProperty = "LabelId";
        const nameProperty = "LabelName";
        const localTextPrefix = "SerenityData.StockNames";
        const deletePermission = "SerenityData:StockNames:Delete";
        const insertPermission = "SerenityData:StockNames:Modify";
        const readPermission = "SerenityData:StockNames:View";
        const updatePermission = "SerenityData:StockNames:Modify";
        const enum Fields {
            LabelId = "LabelId",
            LabelName = "LabelName",
            TenantId = "TenantId",
            TenantTenantName = "TenantTenantName"
        }
    }
}
declare namespace SerenityData.SerenityData {
    namespace StockNamesService {
        const baseUrl = "SerenityData/StockNames";
        function Create(request: Serenity.SaveRequest<StockNamesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<StockNamesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<StockNamesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<StockNamesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "SerenityData/StockNames/Create",
            Update = "SerenityData/StockNames/Update",
            Delete = "SerenityData/StockNames/Delete",
            Retrieve = "SerenityData/StockNames/Retrieve",
            List = "SerenityData/StockNames/List"
        }
    }
}
declare namespace SerenityData.SerenityData {
    class StockTransactionsColumns {
        static columnsKey: string;
    }
}
declare namespace SerenityData.SerenityData {
    interface StockTransactionsForm {
        ProductId: Serenity.IntegerEditor;
        Quantity: Serenity.IntegerEditor;
        Type: Serenity.StringEditor;
        Date: Serenity.DateEditor;
        TenantId: Serenity.IntegerEditor;
    }
    class StockTransactionsForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.SerenityData {
    interface StockTransactionsRow {
        TransactionId?: number;
        ProductId?: number;
        Quantity?: number;
        Type?: string;
        Date?: string;
        TenantId?: number;
        ProductProductName?: string;
        ProductCategoryId?: number;
        ProductSupplierId?: number;
        ProductUnitPrice?: number;
        ProductTenantId?: number;
        TenantTenantName?: string;
    }
    namespace StockTransactionsRow {
        const idProperty = "TransactionId";
        const nameProperty = "Type";
        const localTextPrefix = "SerenityData.StockTransactions";
        const deletePermission = "SerenityData:StockTransactions:Delete";
        const insertPermission = "SerenityData:StockTransactions:Modify";
        const readPermission = "SerenityData:StockTransactions:View";
        const updatePermission = "SerenityData:StockTransactions:Modify";
        const enum Fields {
            TransactionId = "TransactionId",
            ProductId = "ProductId",
            Quantity = "Quantity",
            Type = "Type",
            Date = "Date",
            TenantId = "TenantId",
            ProductProductName = "ProductProductName",
            ProductCategoryId = "ProductCategoryId",
            ProductSupplierId = "ProductSupplierId",
            ProductUnitPrice = "ProductUnitPrice",
            ProductTenantId = "ProductTenantId",
            TenantTenantName = "TenantTenantName"
        }
    }
}
declare namespace SerenityData.SerenityData {
    namespace StockTransactionsService {
        const baseUrl = "SerenityData/StockTransactions";
        function Create(request: Serenity.SaveRequest<StockTransactionsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<StockTransactionsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<StockTransactionsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<StockTransactionsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "SerenityData/StockTransactions/Create",
            Update = "SerenityData/StockTransactions/Update",
            Delete = "SerenityData/StockTransactions/Delete",
            Retrieve = "SerenityData/StockTransactions/Retrieve",
            List = "SerenityData/StockTransactions/List"
        }
    }
}
declare namespace SerenityData.SerenityData {
    class SuppliersColumns {
        static columnsKey: string;
    }
}
declare namespace SerenityData.SerenityData {
    interface SuppliersForm {
        SupplierName: Serenity.StringEditor;
        TenantId: Serenity.IntegerEditor;
    }
    class SuppliersForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.SerenityData {
    interface SuppliersRow {
        SupplierId?: number;
        SupplierName?: string;
        TenantId?: number;
        TenantTenantName?: string;
    }
    namespace SuppliersRow {
        const idProperty = "SupplierId";
        const nameProperty = "SupplierName";
        const localTextPrefix = "SerenityData.Suppliers";
        const deletePermission = "SerenityData:Suppliers:Delete";
        const insertPermission = "SerenityData:Suppliers:Modify";
        const readPermission = "SerenityData:Suppliers:View";
        const updatePermission = "SerenityData:Suppliers:Modify";
        const enum Fields {
            SupplierId = "SupplierId",
            SupplierName = "SupplierName",
            TenantId = "TenantId",
            TenantTenantName = "TenantTenantName"
        }
    }
}
declare namespace SerenityData.SerenityData {
    namespace SuppliersService {
        const baseUrl = "SerenityData/Suppliers";
        function Create(request: Serenity.SaveRequest<SuppliersRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<SuppliersRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<SuppliersRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<SuppliersRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "SerenityData/Suppliers/Create",
            Update = "SerenityData/Suppliers/Update",
            Delete = "SerenityData/Suppliers/Delete",
            Retrieve = "SerenityData/Suppliers/Retrieve",
            List = "SerenityData/Suppliers/List"
        }
    }
}
declare namespace SerenityData.SerenityData {
    class TenantsColumns {
        static columnsKey: string;
    }
}
declare namespace SerenityData.SerenityData {
    interface TenantsForm {
        TenantName: Serenity.StringEditor;
    }
    class TenantsForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.SerenityData {
    interface TenantsRow {
        TenantId?: number;
        TenantName?: string;
    }
    namespace TenantsRow {
        const idProperty = "TenantId";
        const nameProperty = "TenantName";
        const localTextPrefix = "SerenityData.Tenants";
        const deletePermission = "SerenityData:Tenants:Delete";
        const insertPermission = "SerenityData:Tenants:Modify";
        const readPermission = "SerenityData:Tenants:View";
        const updatePermission = "SerenityData:Tenants:Modify";
        const enum Fields {
            TenantId = "TenantId",
            TenantName = "TenantName"
        }
    }
}
declare namespace SerenityData.SerenityData {
    namespace TenantsService {
        const baseUrl = "SerenityData/Tenants";
        function Create(request: Serenity.SaveRequest<TenantsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<TenantsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TenantsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TenantsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "SerenityData/Tenants/Create",
            Update = "SerenityData/Tenants/Update",
            Delete = "SerenityData/Tenants/Delete",
            Retrieve = "SerenityData/Tenants/Retrieve",
            List = "SerenityData/Tenants/List"
        }
    }
}
declare namespace SerenityData.SerenityData {
    class TotalSalesColumns {
        static columnsKey: string;
    }
}
declare namespace SerenityData.SerenityData {
    interface TotalSalesForm {
        ReportDate: Serenity.DateEditor;
        TotalAmount: Serenity.DecimalEditor;
        TenantId: Serenity.IntegerEditor;
    }
    class TotalSalesForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace SerenityData.SerenityData {
    interface TotalSalesRow {
        SaleId?: number;
        ReportDate?: string;
        TotalAmount?: number;
        TenantId?: number;
        TenantTenantName?: string;
    }
    namespace TotalSalesRow {
        const idProperty = "SaleId";
        const localTextPrefix = "SerenityData.TotalSales";
        const deletePermission = "SerenityData:TotalSales:Delete";
        const insertPermission = "SerenityData:TotalSales:Modify";
        const readPermission = "SerenityData:TotalSales:View";
        const updatePermission = "SerenityData:TotalSales:Modify";
        const enum Fields {
            SaleId = "SaleId",
            ReportDate = "ReportDate",
            TotalAmount = "TotalAmount",
            TenantId = "TenantId",
            TenantTenantName = "TenantTenantName"
        }
    }
}
declare namespace SerenityData.SerenityData {
    namespace TotalSalesService {
        const baseUrl = "SerenityData/TotalSales";
        function Createe(request: Serenity.SaveRequest<TotalSalesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: Serenity.SaveRequest<TotalSalesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TotalSalesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TotalSalesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Createe = "SerenityData/TotalSales/Createe",
            Update = "SerenityData/TotalSales/Update",
            Delete = "SerenityData/TotalSales/Delete",
            Retrieve = "SerenityData/TotalSales/Retrieve",
            List = "SerenityData/TotalSales/List"
        }
    }
}
declare namespace SerenityData.Texts {
}
declare namespace VanilaProject.Modules.SerenityData {
    namespace SerenityDataPermissionKeys {
        const General = "SerenityData:General";
    }
}
declare namespace SerenityData.Administration {
    class LanguageDialog extends Serenity.EntityDialog<LanguageRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: LanguageForm;
    }
}
declare namespace SerenityData.Administration {
    class LanguageGrid extends Serenity.EntityGrid<LanguageRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof LanguageDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getDefaultSortBy(): LanguageRow.Fields[];
    }
}
declare namespace SerenityData.Administration {
    class RoleDialog extends Serenity.EntityDialog<RoleRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: RoleForm;
        protected getToolbarButtons(): Serenity.ToolButton[];
        protected updateInterface(): void;
    }
}
declare namespace SerenityData.Administration {
    class RoleGrid extends Serenity.EntityGrid<RoleRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof RoleDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getDefaultSortBy(): RoleRow.Fields[];
    }
}
declare namespace SerenityData.Administration {
    class RolePermissionDialog extends Serenity.TemplatedDialog<RolePermissionDialogOptions> {
        private permissions;
        constructor(opt: RolePermissionDialogOptions);
        protected getDialogOptions(): JQueryUI.DialogOptions;
        protected getTemplate(): string;
    }
    interface RolePermissionDialogOptions {
        roleID?: number;
        title?: string;
    }
}
declare namespace SerenityData.Administration {
    class TranslationGrid extends Serenity.EntityGrid<TranslationItem, any> {
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        private hasChanges;
        private searchText;
        private sourceLanguage;
        private targetLanguage;
        private targetLanguageKey;
        constructor(container: JQuery);
        protected onClick(e: JQueryEventObject, row: number, cell: number): any;
        protected getColumns(): Slick.Column[];
        protected createToolbarExtensions(): void;
        protected saveChanges(language: string): PromiseLike<any>;
        protected onViewSubmit(): boolean;
        protected getButtons(): Serenity.ToolButton[];
        protected createQuickSearchInput(): void;
        protected onViewFilter(item: TranslationItem): boolean;
        protected usePager(): boolean;
    }
}
declare namespace SerenityData.Administration {
    class UserDialog extends Serenity.EntityDialog<UserRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getIsActiveProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: UserForm;
        constructor();
        protected getToolbarButtons(): Serenity.ToolButton[];
        protected updateInterface(): void;
        protected afterLoadEntity(): void;
    }
}
declare namespace SerenityData.Administration {
    class UserGrid extends Serenity.EntityGrid<UserRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof UserDialog;
        protected getIdProperty(): string;
        protected getIsActiveProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getDefaultSortBy(): UserRow.Fields[];
    }
}
declare namespace SerenityData.Authorization {
    let userDefinition: ScriptUserDefinition;
    function hasPermission(permissionKey: string): boolean;
}
declare namespace SerenityData.Administration {
    class PermissionCheckEditor extends Serenity.DataGrid<PermissionCheckItem, PermissionCheckEditorOptions> {
        protected getIdProperty(): string;
        private searchText;
        private byParentKey;
        constructor(container: JQuery, opt: PermissionCheckEditorOptions);
        private getItemGrantRevokeClass;
        private roleOrImplicit;
        private getItemEffectiveClass;
        protected getColumns(): Slick.Column[];
        setItems(items: PermissionCheckItem[]): void;
        protected onViewSubmit(): boolean;
        protected onViewFilter(item: PermissionCheckItem): boolean;
        private matchContains;
        private getDescendants;
        protected onClick(e: any, row: any, cell: any): void;
        private getParentKey;
        protected getButtons(): Serenity.ToolButton[];
        protected createToolbarExtensions(): void;
        private getSortedGroupAndPermissionKeys;
        get value(): UserPermissionRow[];
        set value(value: UserPermissionRow[]);
        private _rolePermissions;
        get rolePermissions(): string[];
        set rolePermissions(value: string[]);
        private _implicitPermissions;
        set implicitPermissions(value: Q.Dictionary<string[]>);
    }
    interface PermissionCheckEditorOptions {
        showRevoke?: boolean;
    }
    interface PermissionCheckItem {
        ParentKey?: string;
        Key?: string;
        Title?: string;
        IsGroup?: boolean;
        GrantRevoke?: boolean;
    }
}
declare namespace SerenityData.Administration {
    class UserPermissionDialog extends Serenity.TemplatedDialog<UserPermissionDialogOptions> {
        private permissions;
        constructor(opt: UserPermissionDialogOptions);
        protected getDialogOptions(): JQueryUI.DialogOptions;
        protected getTemplate(): string;
    }
    interface UserPermissionDialogOptions {
        userID?: number;
        username?: string;
    }
}
declare namespace SerenityData.Administration {
    class RoleCheckEditor extends Serenity.CheckTreeEditor<Serenity.CheckTreeItem<any>, any> {
        private searchText;
        constructor(div: JQuery);
        protected createToolbarExtensions(): void;
        protected getButtons(): any[];
        protected getTreeItems(): Serenity.CheckTreeItem<any>[];
        protected onViewFilter(item: any): boolean;
    }
}
declare namespace SerenityData.Administration {
    class UserRoleDialog extends Serenity.TemplatedDialog<UserRoleDialogOptions> {
        private permissions;
        constructor(opt: UserRoleDialogOptions);
        protected getDialogOptions(): JQueryUI.DialogOptions;
        protected getTemplate(): string;
    }
    interface UserRoleDialogOptions {
        userID: number;
        username: string;
    }
}
declare namespace SerenityData.LanguageList {
    function getValue(): string[][];
}
declare namespace SerenityData.ScriptInitialization {
}
declare namespace SerenityData.DialogUtils {
    function pendingChangesConfirmation(element: JQuery, hasPendingChanges: () => boolean): void;
}
declare namespace SerenityData.Common {
    class InlineImageFormatter implements Slick.Formatter, Serenity.IInitializeColumn {
        format(ctx: Slick.FormatterContext): string;
        initializeColumn(column: Slick.Column): void;
        fileProperty: string;
        thumb: boolean;
    }
}
declare namespace SerenityData.Common {
    class SidebarSearch extends Serenity.Widget<any> {
        private menuUL;
        constructor(input: JQuery, menuUL: JQuery);
        protected updateMatchFlags(text: string): void;
    }
}
declare namespace SerenityData.Membership {
    class LoginPanel extends Serenity.PropertyPanel<LoginRequest, any> {
        protected getFormKey(): string;
        constructor(container: JQuery);
        protected redirectToReturnUrl(): void;
        protected getTemplate(): string;
    }
}
declare namespace SerenityData.Membership {
    class ChangePasswordPanel extends Serenity.PropertyPanel<ChangePasswordRequest, any> {
        protected getFormKey(): string;
        private form;
        constructor(container: JQuery);
        getTemplate(): string;
    }
}
declare namespace SerenityData.Membership {
    class ForgotPasswordPanel extends Serenity.PropertyPanel<ForgotPasswordRequest, any> {
        protected getFormKey(): string;
        private form;
        constructor(container: JQuery);
    }
}
declare namespace SerenityData.Membership {
    class ResetPasswordPanel extends Serenity.PropertyPanel<ResetPasswordRequest, any> {
        protected getFormKey(): string;
        private form;
        constructor(container: JQuery);
    }
}
declare namespace SerenityData.Membership {
    class SignUpPanel extends Serenity.PropertyPanel<SignUpRequest, any> {
        protected getFormKey(): string;
        private form;
        constructor(container: JQuery);
    }
}
declare namespace SerenityData.SerenityData {
    class ActiveUsersDialog extends Serenity.EntityDialog<ActiveUsersRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: ActiveUsersForm;
    }
}
declare namespace SerenityData.SerenityData {
    class ActiveUsersGrid extends Serenity.EntityGrid<ActiveUsersRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ActiveUsersDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace SerenityData.SerenityData {
    class CategoriesDialog extends Serenity.EntityDialog<CategoriesRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: CategoriesForm;
    }
}
declare namespace SerenityData.SerenityData {
    class CategoriesGrid extends Serenity.EntityGrid<CategoriesRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof CategoriesDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace SerenityData.SerenityData {
    class ProductsDialog extends Serenity.EntityDialog<ProductsRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: ProductsForm;
    }
}
declare namespace SerenityData.SerenityData {
    class ProductsGrid extends Serenity.EntityGrid<ProductsRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ProductsDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace SerenityData.SerenityData {
    class SoftwareDialog extends Serenity.EntityDialog<SoftwareRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: SoftwareForm;
    }
}
declare namespace SerenityData.SerenityData {
    class SoftwareGrid extends Serenity.EntityGrid<SoftwareRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof SoftwareDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace SerenityData.SerenityData {
    class StockNamesDialog extends Serenity.EntityDialog<StockNamesRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: StockNamesForm;
    }
}
declare namespace SerenityData.SerenityData {
    class StockNamesGrid extends Serenity.EntityGrid<StockNamesRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof StockNamesDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace SerenityData.SerenityData {
    class StockTransactionsDialog extends Serenity.EntityDialog<StockTransactionsRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: StockTransactionsForm;
    }
}
declare namespace SerenityData.SerenityData {
    class StockTransactionsGrid extends Serenity.EntityGrid<StockTransactionsRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof StockTransactionsDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace SerenityData.SerenityData {
    class SuppliersDialog extends Serenity.EntityDialog<SuppliersRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: SuppliersForm;
    }
}
declare namespace SerenityData.SerenityData {
    class SuppliersGrid extends Serenity.EntityGrid<SuppliersRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof SuppliersDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace SerenityData.SerenityData {
    class TenantsDialog extends Serenity.EntityDialog<TenantsRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: TenantsForm;
    }
}
declare namespace SerenityData.SerenityData {
    class TenantsGrid extends Serenity.EntityGrid<TenantsRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof TenantsDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace SerenityData.SerenityData {
    class TotalSalesDialog extends Serenity.EntityDialog<TotalSalesRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: TotalSalesForm;
    }
}
declare namespace SerenityData.SerenityData {
    class TotalSalesGrid extends Serenity.EntityGrid<TotalSalesRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof TotalSalesDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
