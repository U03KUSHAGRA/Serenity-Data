namespace SerenityData.SerenityData {
    export interface TotalSalesRow {
        SaleId?: number;
        ReportDate?: string;
        TotalAmount?: number;
        TenantId?: number;
        TenantTenantName?: string;
    }

    export namespace TotalSalesRow {
        export const idProperty = 'SaleId';
        export const localTextPrefix = 'SerenityData.TotalSales';
        export const deletePermission = 'SerenityData:TotalSales:Delete';
        export const insertPermission = 'SerenityData:TotalSales:Modify';
        export const readPermission = 'SerenityData:TotalSales:View';
        export const updatePermission = 'SerenityData:TotalSales:Modify';

        export declare const enum Fields {
            SaleId = "SaleId",
            ReportDate = "ReportDate",
            TotalAmount = "TotalAmount",
            TenantId = "TenantId",
            TenantTenantName = "TenantTenantName"
        }
    }
}
