namespace SerenityData.SerenityData {
    export interface SuppliersRow {
        SupplierId?: number;
        SupplierName?: string;
        TenantId?: number;
        TenantTenantName?: string;
    }

    export namespace SuppliersRow {
        export const idProperty = 'SupplierId';
        export const nameProperty = 'SupplierName';
        export const localTextPrefix = 'SerenityData.Suppliers';
        export const deletePermission = 'SerenityData:Suppliers:Delete';
        export const insertPermission = 'SerenityData:Suppliers:Modify';
        export const readPermission = 'SerenityData:Suppliers:View';
        export const updatePermission = 'SerenityData:Suppliers:Modify';

        export declare const enum Fields {
            SupplierId = "SupplierId",
            SupplierName = "SupplierName",
            TenantId = "TenantId",
            TenantTenantName = "TenantTenantName"
        }
    }
}
