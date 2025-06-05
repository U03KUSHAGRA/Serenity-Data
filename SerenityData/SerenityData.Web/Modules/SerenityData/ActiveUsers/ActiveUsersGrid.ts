
namespace SerenityData.SerenityData {

    @Serenity.Decorators.registerClass()
    export class ActiveUsersGrid extends Serenity.EntityGrid<ActiveUsersRow, any> {
        protected getColumnsKey() { return ActiveUsersColumns.columnsKey; }
        protected getDialogType() { return ActiveUsersDialog; }
        protected getIdProperty() { return ActiveUsersRow.idProperty; }
        protected getInsertPermission() { return ActiveUsersRow.insertPermission; }
        protected getLocalTextPrefix() { return ActiveUsersRow.localTextPrefix; }
        protected getService() { return ActiveUsersService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}