
namespace SerenityData.SerenityData {

    @Serenity.Decorators.registerClass()
    export class ProductsGrid extends Serenity.EntityGrid<ProductsRow, any> {
        protected getColumnsKey() { return ProductsColumns.columnsKey; }
        protected getDialogType() { return ProductsDialog; }
        protected getIdProperty() { return ProductsRow.idProperty; }
        protected getInsertPermission() { return ProductsRow.insertPermission; }
        protected getLocalTextPrefix() { return ProductsRow.localTextPrefix; }
        protected getService() { return ProductsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}