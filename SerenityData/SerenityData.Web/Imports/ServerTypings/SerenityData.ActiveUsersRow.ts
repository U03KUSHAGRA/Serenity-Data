namespace SerenityData.SerenityData {
    export interface ActiveUsersRow {
        UserId?: number;
        Email?: string;
        TenantId?: number;
        TenantTenantName?: string;
    }

    export namespace ActiveUsersRow {
        export const idProperty = 'UserId';
        export const nameProperty = 'Email';
        export const localTextPrefix = 'SerenityData.ActiveUsers';
        export const deletePermission = 'SerenityData:ActiveUsers:Delete';
        export const insertPermission = 'SerenityData:ActiveUsers:Modify';
        export const readPermission = 'SerenityData:ActiveUsers:View';
        export const updatePermission = 'SerenityData:ActiveUsers:Modify';

        export declare const enum Fields {
            UserId = "UserId",
            Email = "Email",
            TenantId = "TenantId",
            TenantTenantName = "TenantTenantName"
        }
    }
}
