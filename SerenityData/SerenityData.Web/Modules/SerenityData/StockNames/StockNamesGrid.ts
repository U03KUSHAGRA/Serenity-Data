
namespace SerenityData.SerenityData {

    @Serenity.Decorators.registerClass()
    export class StockNamesGrid extends Serenity.EntityGrid<StockNamesRow, any> {
        protected getColumnsKey() { return StockNamesColumns.columnsKey; }
        protected getDialogType() { return StockNamesDialog; }
        protected getIdProperty() { return StockNamesRow.idProperty; }
        protected getInsertPermission() { return StockNamesRow.insertPermission; }
        protected getLocalTextPrefix() { return StockNamesRow.localTextPrefix; }
        protected getService() { return StockNamesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}