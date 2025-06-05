
namespace SerenityData.SerenityData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class StockNamesDialog extends Serenity.EntityDialog<StockNamesRow, any> {
        protected getFormKey() { return StockNamesForm.formKey; }
        protected getIdProperty() { return StockNamesRow.idProperty; }
        protected getLocalTextPrefix() { return StockNamesRow.localTextPrefix; }
        protected getNameProperty() { return StockNamesRow.nameProperty; }
        protected getService() { return StockNamesService.baseUrl; }
        protected getDeletePermission() { return StockNamesRow.deletePermission; }
        protected getInsertPermission() { return StockNamesRow.insertPermission; }
        protected getUpdatePermission() { return StockNamesRow.updatePermission; }

        protected form = new StockNamesForm(this.idPrefix);

    }
}