
namespace SerenityData.SerenityData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class StockTransactionsDialog extends Serenity.EntityDialog<StockTransactionsRow, any> {
        protected getFormKey() { return StockTransactionsForm.formKey; }
        protected getIdProperty() { return StockTransactionsRow.idProperty; }
        protected getLocalTextPrefix() { return StockTransactionsRow.localTextPrefix; }
        protected getNameProperty() { return StockTransactionsRow.nameProperty; }
        protected getService() { return StockTransactionsService.baseUrl; }
        protected getDeletePermission() { return StockTransactionsRow.deletePermission; }
        protected getInsertPermission() { return StockTransactionsRow.insertPermission; }
        protected getUpdatePermission() { return StockTransactionsRow.updatePermission; }

        protected form = new StockTransactionsForm(this.idPrefix);

    }
}