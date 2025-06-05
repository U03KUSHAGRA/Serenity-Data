
namespace SerenityData.SerenityData {

    @Serenity.Decorators.registerClass()
    export class StockTransactionsGrid extends Serenity.EntityGrid<StockTransactionsRow, any> {
        protected getColumnsKey() { return StockTransactionsColumns.columnsKey; }
        protected getDialogType() { return StockTransactionsDialog; }
        protected getIdProperty() { return StockTransactionsRow.idProperty; }
        protected getInsertPermission() { return StockTransactionsRow.insertPermission; }
        protected getLocalTextPrefix() { return StockTransactionsRow.localTextPrefix; }
        protected getService() { return StockTransactionsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}