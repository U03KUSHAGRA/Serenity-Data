namespace SerenityData.SerenityData {
    export interface CategoriesForm {
        CategoryName: Serenity.StringEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class CategoriesForm extends Serenity.PrefixedContext {
        static formKey = 'SerenityData.Categories';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CategoriesForm.init)  {
                CategoriesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(CategoriesForm, [
                    'CategoryName', w0,
                    'TenantId', w1
                ]);
            }
        }
    }
}
