namespace SerenityData.SerenityData {
    export namespace TotalSalesService {
        export const baseUrl = 'SerenityData/TotalSales';

        export declare function Createe(request: Serenity.SaveRequest<TotalSalesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<TotalSalesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TotalSalesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TotalSalesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Createe = "SerenityData/TotalSales/Createe",
            Update = "SerenityData/TotalSales/Update",
            Delete = "SerenityData/TotalSales/Delete",
            Retrieve = "SerenityData/TotalSales/Retrieve",
            List = "SerenityData/TotalSales/List"
        }

        [
            'Createe', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>TotalSalesService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
