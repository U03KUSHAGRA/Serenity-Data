namespace SerenityData.SerenityData {
    export interface ProductsRow {
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

    export namespace ProductsRow {
        export const idProperty = 'ProductId';
        export const nameProperty = 'ProductName';
        export const localTextPrefix = 'SerenityData.Products';
        export const deletePermission = 'SerenityData:Products:Delete';
        export const insertPermission = 'SerenityData:Products:Modify';
        export const readPermission = 'SerenityData:Products:View';
        export const updatePermission = 'SerenityData:Products:Modify';

        export declare const enum Fields {
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
