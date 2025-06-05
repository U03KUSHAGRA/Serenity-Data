namespace SerenityData {
    export interface GetNextOrderNumberResponse extends Serenity.ServiceResponse {
        OrderNumber?: number;
        Serial?: string;
    }
}
