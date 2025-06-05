namespace SerenityData.SerenityData {
    export interface SoftwareForm {
        ProductName: Serenity.StringEditor;
        DeliveredOn: Serenity.DateEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class SoftwareForm extends Serenity.PrefixedContext {
        static formKey = 'SerenityData.Software';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SoftwareForm.init)  {
                SoftwareForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(SoftwareForm, [
                    'ProductName', w0,
                    'DeliveredOn', w1,
                    'TenantId', w2
                ]);
            }
        }
    }
}
