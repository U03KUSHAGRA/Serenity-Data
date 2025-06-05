namespace SerenityData.SerenityData {
    export interface StockTransactionsForm {
        ProductId: Serenity.IntegerEditor;
        Quantity: Serenity.IntegerEditor;
        Type: Serenity.StringEditor;
        Date: Serenity.DateEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class StockTransactionsForm extends Serenity.PrefixedContext {
        static formKey = 'SerenityData.StockTransactions';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!StockTransactionsForm.init)  {
                StockTransactionsForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(StockTransactionsForm, [
                    'ProductId', w0,
                    'Quantity', w0,
                    'Type', w1,
                    'Date', w2,
                    'TenantId', w0
                ]);
            }
        }
    }
}
