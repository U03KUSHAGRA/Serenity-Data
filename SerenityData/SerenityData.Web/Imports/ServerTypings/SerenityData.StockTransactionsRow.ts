namespace SerenityData.SerenityData {
    export interface StockTransactionsRow {
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

    export namespace StockTransactionsRow {
        export const idProperty = 'TransactionId';
        export const nameProperty = 'Type';
        export const localTextPrefix = 'SerenityData.StockTransactions';
        export const deletePermission = 'SerenityData:StockTransactions:Delete';
        export const insertPermission = 'SerenityData:StockTransactions:Modify';
        export const readPermission = 'SerenityData:StockTransactions:View';
        export const updatePermission = 'SerenityData:StockTransactions:Modify';

        export declare const enum Fields {
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
