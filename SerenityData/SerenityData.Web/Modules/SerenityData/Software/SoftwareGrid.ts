
namespace SerenityData.SerenityData {

    @Serenity.Decorators.registerClass()
    export class SoftwareGrid extends Serenity.EntityGrid<SoftwareRow, any> {
        protected getColumnsKey() { return SoftwareColumns.columnsKey; }
        protected getDialogType() { return SoftwareDialog; }
        protected getIdProperty() { return SoftwareRow.idProperty; }
        protected getInsertPermission() { return SoftwareRow.insertPermission; }
        protected getLocalTextPrefix() { return SoftwareRow.localTextPrefix; }
        protected getService() { return SoftwareService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}