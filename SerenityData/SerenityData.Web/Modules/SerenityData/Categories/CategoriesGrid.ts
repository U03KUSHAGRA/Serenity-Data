
namespace SerenityData.SerenityData {

    @Serenity.Decorators.registerClass()
    export class CategoriesGrid extends Serenity.EntityGrid<CategoriesRow, any> {
        protected getColumnsKey() { return CategoriesColumns.columnsKey; }
        protected getDialogType() { return CategoriesDialog; }
        protected getIdProperty() { return CategoriesRow.idProperty; }
        protected getInsertPermission() { return CategoriesRow.insertPermission; }
        protected getLocalTextPrefix() { return CategoriesRow.localTextPrefix; }
        protected getService() { return CategoriesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}