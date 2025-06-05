namespace SerenityData.SerenityData {
    export interface ProductsForm {
        ProductName: Serenity.StringEditor;
        CategoryId: Serenity.IntegerEditor;
        SupplierId: Serenity.IntegerEditor;
        UnitPrice: Serenity.DecimalEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class ProductsForm extends Serenity.PrefixedContext {
        static formKey = 'SerenityData.Products';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductsForm.init)  {
                ProductsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DecimalEditor;

                Q.initFormType(ProductsForm, [
                    'ProductName', w0,
                    'CategoryId', w1,
                    'SupplierId', w1,
                    'UnitPrice', w2,
                    'TenantId', w1
                ]);
            }
        }
    }
}
