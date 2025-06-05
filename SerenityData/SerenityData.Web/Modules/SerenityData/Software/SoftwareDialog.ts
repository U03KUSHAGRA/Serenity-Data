
namespace SerenityData.SerenityData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class SoftwareDialog extends Serenity.EntityDialog<SoftwareRow, any> {
        protected getFormKey() { return SoftwareForm.formKey; }
        protected getIdProperty() { return SoftwareRow.idProperty; }
        protected getLocalTextPrefix() { return SoftwareRow.localTextPrefix; }
        protected getNameProperty() { return SoftwareRow.nameProperty; }
        protected getService() { return SoftwareService.baseUrl; }
        protected getDeletePermission() { return SoftwareRow.deletePermission; }
        protected getInsertPermission() { return SoftwareRow.insertPermission; }
        protected getUpdatePermission() { return SoftwareRow.updatePermission; }

        protected form = new SoftwareForm(this.idPrefix);

    }
}