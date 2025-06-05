namespace SerenityData.SerenityData {
    export interface TenantsRow {
        TenantId?: number;
        TenantName?: string;
    }

    export namespace TenantsRow {
        export const idProperty = 'TenantId';
        export const nameProperty = 'TenantName';
        export const localTextPrefix = 'SerenityData.Tenants';
        export const deletePermission = 'SerenityData:Tenants:Delete';
        export const insertPermission = 'SerenityData:Tenants:Modify';
        export const readPermission = 'SerenityData:Tenants:View';
        export const updatePermission = 'SerenityData:Tenants:Modify';

        export declare const enum Fields {
            TenantId = "TenantId",
            TenantName = "TenantName"
        }
    }
}
