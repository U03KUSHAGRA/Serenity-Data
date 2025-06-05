namespace SerenityData.SerenityData {
    export interface ActiveUsersForm {
        Email: Serenity.StringEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class ActiveUsersForm extends Serenity.PrefixedContext {
        static formKey = 'SerenityData.ActiveUsers';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ActiveUsersForm.init)  {
                ActiveUsersForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(ActiveUsersForm, [
                    'Email', w0,
                    'TenantId', w1
                ]);
            }
        }
    }
}
