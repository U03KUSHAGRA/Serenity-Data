namespace SerenityData.SerenityData {
    export interface CategoriesRow {
        CategoryId?: number;
        CategoryName?: string;
        TenantId?: number;
        TenantTenantName?: string;
    }

    export namespace CategoriesRow {
        export const idProperty = 'CategoryId';
        export const nameProperty = 'CategoryName';
        export const localTextPrefix = 'SerenityData.Categories';
        export const deletePermission = 'SerenityData:Categories:Delete';
        export const insertPermission = 'SerenityData:Categories:Modify';
        export const readPermission = 'SerenityData:Categories:View';
        export const updatePermission = 'SerenityData:Categories:Modify';

        export declare const enum Fields {
            CategoryId = "CategoryId",
            CategoryName = "CategoryName",
            TenantId = "TenantId",
            TenantTenantName = "TenantTenantName"
        }
    }
}
