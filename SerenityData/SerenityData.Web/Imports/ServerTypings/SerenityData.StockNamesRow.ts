namespace SerenityData.SerenityData {
    export interface StockNamesRow {
        LabelId?: number;
        LabelName?: string;
        TenantId?: number;
        TenantTenantName?: string;
    }

    export namespace StockNamesRow {
        export const idProperty = 'LabelId';
        export const nameProperty = 'LabelName';
        export const localTextPrefix = 'SerenityData.StockNames';
        export const deletePermission = 'SerenityData:StockNames:Delete';
        export const insertPermission = 'SerenityData:StockNames:Modify';
        export const readPermission = 'SerenityData:StockNames:View';
        export const updatePermission = 'SerenityData:StockNames:Modify';

        export declare const enum Fields {
            LabelId = "LabelId",
            LabelName = "LabelName",
            TenantId = "TenantId",
            TenantTenantName = "TenantTenantName"
        }
    }
}
