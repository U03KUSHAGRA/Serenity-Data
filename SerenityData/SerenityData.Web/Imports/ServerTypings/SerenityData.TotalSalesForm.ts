namespace SerenityData.SerenityData {
    export interface TotalSalesForm {
        ReportDate: Serenity.DateEditor;
        TotalAmount: Serenity.DecimalEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class TotalSalesForm extends Serenity.PrefixedContext {
        static formKey = 'SerenityData.TotalSales';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TotalSalesForm.init)  {
                TotalSalesForm.init = true;

                var s = Serenity;
                var w0 = s.DateEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(TotalSalesForm, [
                    'ReportDate', w0,
                    'TotalAmount', w1,
                    'TenantId', w2
                ]);
            }
        }
    }
}
