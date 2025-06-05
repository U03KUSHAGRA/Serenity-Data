
namespace SerenityData.SerenityData {

    @Serenity.Decorators.registerClass()
    export class TotalSalesGrid extends Serenity.EntityGrid<TotalSalesRow, any> {
        protected getColumnsKey() { return TotalSalesColumns.columnsKey; }
        protected getDialogType() { return TotalSalesDialog; }
        protected getIdProperty() { return TotalSalesRow.idProperty; }
        protected getInsertPermission() { return TotalSalesRow.insertPermission; }
        protected getLocalTextPrefix() { return TotalSalesRow.localTextPrefix; }
        protected getService() { return TotalSalesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}