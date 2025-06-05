
namespace SerenityData.SerenityData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class TotalSalesDialog extends Serenity.EntityDialog<TotalSalesRow, any> {
        protected getFormKey() { return TotalSalesForm.formKey; }
        protected getIdProperty() { return TotalSalesRow.idProperty; }
        protected getLocalTextPrefix() { return TotalSalesRow.localTextPrefix; }
        protected getService() { return TotalSalesService.baseUrl; }
        protected getDeletePermission() { return TotalSalesRow.deletePermission; }
        protected getInsertPermission() { return TotalSalesRow.insertPermission; }
        protected getUpdatePermission() { return TotalSalesRow.updatePermission; }

        protected form = new TotalSalesForm(this.idPrefix);

    }
}