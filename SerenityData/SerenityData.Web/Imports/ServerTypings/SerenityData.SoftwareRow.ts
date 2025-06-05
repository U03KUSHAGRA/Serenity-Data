namespace SerenityData.SerenityData {
    export interface SoftwareRow {
        DeliveryId?: number;
        ProductName?: string;
        DeliveredOn?: string;
        TenantId?: number;
        TenantTenantName?: string;
    }

    export namespace SoftwareRow {
        export const idProperty = 'DeliveryId';
        export const nameProperty = 'ProductName';
        export const localTextPrefix = 'SerenityData.Software';
        export const deletePermission = 'SerenityData:Software:Delete';
        export const insertPermission = 'SerenityData:Software:Modify';
        export const readPermission = 'SerenityData:Software:View';
        export const updatePermission = 'SerenityData:Software:Modify';

        export declare const enum Fields {
            DeliveryId = "DeliveryId",
            ProductName = "ProductName",
            DeliveredOn = "DeliveredOn",
            TenantId = "TenantId",
            TenantTenantName = "TenantTenantName"
        }
    }
}
