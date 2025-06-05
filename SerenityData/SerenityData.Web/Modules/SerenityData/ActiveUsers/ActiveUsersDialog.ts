
namespace SerenityData.SerenityData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class ActiveUsersDialog extends Serenity.EntityDialog<ActiveUsersRow, any> {
        protected getFormKey() { return ActiveUsersForm.formKey; }
        protected getIdProperty() { return ActiveUsersRow.idProperty; }
        protected getLocalTextPrefix() { return ActiveUsersRow.localTextPrefix; }
        protected getNameProperty() { return ActiveUsersRow.nameProperty; }
        protected getService() { return ActiveUsersService.baseUrl; }
        protected getDeletePermission() { return ActiveUsersRow.deletePermission; }
        protected getInsertPermission() { return ActiveUsersRow.insertPermission; }
        protected getUpdatePermission() { return ActiveUsersRow.updatePermission; }

        protected form = new ActiveUsersForm(this.idPrefix);

    }
}