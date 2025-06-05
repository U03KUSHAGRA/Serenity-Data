namespace SerenityData.SerenityData {
    export interface SuppliersForm {
        SupplierName: Serenity.StringEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class SuppliersForm extends Serenity.PrefixedContext {
        static formKey = 'SerenityData.Suppliers';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SuppliersForm.init)  {
                SuppliersForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(SuppliersForm, [
                    'SupplierName', w0,
                    'TenantId', w1
                ]);
            }
        }
    }
}
