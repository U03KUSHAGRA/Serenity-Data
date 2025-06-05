namespace SerenityData.SerenityData {
    export interface StockNamesForm {
        LabelName: Serenity.StringEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class StockNamesForm extends Serenity.PrefixedContext {
        static formKey = 'SerenityData.StockNames';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!StockNamesForm.init)  {
                StockNamesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(StockNamesForm, [
                    'LabelName', w0,
                    'TenantId', w1
                ]);
            }
        }
    }
}
