using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
namespace SerenityData.Web.Modules.Api
{
    public class ApiDataModel
    {
        public string Message { get; set; }
    }
    #region Banner
    public class ResponseGetAllBanner
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<BannerData> Data { get; set; }
    }
    public class BannerData
    {

        public int BannerID { get; set; }
        public string BannerImage { get; set; }

    }
    public class BasicBannerData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int BannerID { get; set; }
        public string BannerImage { get; set; }

    }
    #endregion

    #region ProductType
    public class ResponseGetAllProductType
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<ProductTypeData> Data { get; set; }
    }
    public class ProductTypeData
    {

        public int ProductTypeID { get; set; }
        public string ProductTypeName { get; set; }
        public string AppImage { get; set; }

    }
    public class BasicProductTypeData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ProductTypeID { get; set; }
        public string ProductTypeName { get; set; }
        public string AppImage { get; set; }
    }
    #endregion

    #region ItemCategory
    public class ResponseGetAllItemCategory
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<ItemCategoryData> Data { get; set; }
    }
    public class ItemCategoryData
    {

        public int ItemCategoryID { get; set; }
        public string ItemCategoryName { get; set; }
        public string AppImage { get; set; }

    }
    public class BasicItemCategoryData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ItemCategoryID { get; set; }
        public string ItemCategoryName { get; set; }
        public string AppImage { get; set; }
    }
    #endregion

    #region ItemType
    public class ResponseGetAllItemType
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<ItemTypeData> Data { get; set; }
    }
    public class ItemTypeData
    {

        public int ItemTypeID { get; set; }
        public string ItemTypeName { get; set; }
        public string AppImage { get; set; }

    }
    public class BasicItemTypeData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ItemTypeID { get; set; }
        public string ItemTypeName { get; set; }
        public string AppImage { get; set; }
    }
    #endregion

    #region getItem
    public class ResponseGetAllItem
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<ItemData> Data { get; set; }
    }
    public class ItemData
    {

        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string AppImage { get; set; }

    }
    public class BasicItemData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string AppImage { get; set; }
    }
    #endregion

    #region Create Customer
    public class CustomerRequest
    {
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileDeviceId { get; set; }

    }

    public class CustomerResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int CustomerId { get; set; }

    }

    #endregion

    #region Login
    public class LoginRequest
    {
        public string MobileNumber { get; set; }
        public string Password { get; set; }
    }
    public class LoginResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public LoginData Data { get; set; }
    }
    public class LoginData
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int BillingAddressId { get; set; }
        public int ShippingAddressId { get; set; }
        public bool RequireReLogin { get; set; }
        public bool IsInactive { get; set; }
        public string LastDeviceAddress { get; set; }

    }
    public class LoginBesicData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int BillingAddressId { get; set; }
        public int ShippingAddressId { get; set; }
        public bool RequireReLogin { get; set; }
        public bool IsInactive { get; set; }
        public string LastDeviceAddress { get; set; }

    }
    #endregion

    #region CheckMobileDevice
    public class MobileDeviceRequest
    {
        public int CustomerId { get; set; }
        public string MobileDeviceId { get; set; }
        public string FriendlyName { get; set; }
    }
    public class MobileDeviceResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public MobileDeviceData Data { get; set; }
    }
    public class MobileDeviceData
    {
        public int DeviceId { get; set; }
        public int CustomerId { get; set; }
        public string FriendlyName { get; set; }
        public string AddedOn { get; set; }
        public bool IsActive { get; set; }
        public string MobileDeviceId { get; set; }


    }
    public class MobileDeviceBesicData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int DeviceId { get; set; }
        public int CustomerId { get; set; }
        public string FriendlyName { get; set; }
        public string AddedOn { get; set; }
        public bool IsActive { get; set; }
        public string MobileDeviceId { get; set; }
    }
    #endregion

    #region CRUD_API
    #region State
    public class StateRequest
    {
        public int StateId { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
    }

    public class StateResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int StateId { get; set; }

    }
    #endregion

    #region City
    public class CityRequest
    {
        public int CityId { get; set; }
        public int StateId { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
    }

    public class CityResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int CityId { get; set; }

    }
    #endregion

    #region CityArea
    public class CityAreaRequest
    {
        public int CityAreaId { get; set; }
        public string AreaName { get; set; }
        public string ReckonCode { get; set; }
        public int CityId { get; set; }
        public string PostalCodeStart { get; set; }
        public string PostalCodeEnd { get; set; }
    }

    public class CityAreaResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int CityAreaId { get; set; }

    }
    #endregion

    #region Branch
    public class BranchRequest
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string ReckonCode { get; set; }
        public string BranchAddress { get; set; }
        public string PostalCode { get; set; }
        public string LandlineNumber { get; set; }
    }

    public class BranchResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int BranchId { get; set; }

    }
    #endregion

    #region BranchArea
    public class BranchAreaRequest
    {
        public int BranchAreaId { get; set; }
        public int BranchId { get; set; }
        public int AreaId { get; set; }
        public string ResponsiblePerson { get; set; }
        public string MobileNumber { get; set; }
    }

    public class BranchAreaResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int BranchAreaId { get; set; }

    }
    #endregion

    #region ChemicalComposition
    public class ChemicalCompositionRequest
    {
        public int ChemicalCompositionId { get; set; }
        public string ChemicalCompositionName { get; set; }
        public string ReckonCode { get; set; }
    }

    public class ChemicalCompositionResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ChemicalCompositionId { get; set; }

    }
    #endregion

    #region ManufacturingCompany
    public class ManufacturingCompanyRequest
    {
        public int ManufacturingCompanyId { get; set; }
       
        public string ManufacturingCompanyName { get; set; }
      
        public string ReckonCode { get; set; }
    }

    public class ManufacturingCompanyResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ManufacturingCompanyId { get; set; }

    }
    #endregion


    #region ItemType
    public class ItemTypeRequest
    {
        public int ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }
        public string ReckonCode { get; set; }
        public int ProductTypeId { get; set; }
        public string AppImage { get; set; }
        public bool Discontinued { get; set; }
        public bool NotApplicableForMobileSale { get; set; }
    }

    public class ItemTypeResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ItemTypeId { get; set; }

    }
    #endregion

    #region ItemCategory
    public class ItemCategoryRequest
    {
        public int ItemCategoryId { get; set; }
       
        public string ItemCategoryName { get; set; }
        
        public string ReckonCode { get; set; }
       
        public int ProductTypeId { get; set; }

        public string AppImage { get; set; }

        public bool Discontinued { get; set; }

        public bool NotApplicableForMobileSale { get; set; }
    }

    public class ItemCategoryResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ItemCategoryId { get; set; }

    }
    #endregion

    #region ProductType
    public class ProductTypeRequest
    {
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public string AppImage { get; set; }
        public bool Discontinued { get; set; }
        public bool NotApplicableForMobileSale { get; set; }
    }

    public class ProductTypeResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ProductTypeId { get; set; }

    }
    #endregion

    #region CreateItem
    public class ItemRequest
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string PrintName { get; set; }
        public decimal Mrp { get; set; }
        public string ReckonCode { get; set; }
        public string BarCode { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal GstRate { get; set; }
        public int ManufacturingCompanyId { get; set; }
        public string PackingName { get; set; }
        public int ProductTYpeId { get; set; }
        public int ChemicalCompositionId { get; set; }
        public int ItemTypeId { get; set; }
        public int ItemCategoryId { get; set; }
        public string Remark { get; set; }
        public string AppImage { get; set; }
        public bool IMarked { get; set; }
        public bool Discontinued { get; set; }
        public bool NegativeStockBilling { get; set; }
        public bool NotApplicableForMobileSale { get; set; }
        public bool TopProduct { get; set; }
        public bool OfferProduct { get; set; }
        public bool RecommendedProduct { get; set; }
    }

    public class ItemResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ItemId { get; set; }

    }
    #endregion

    #region ItemStock
     public class ItemStockRequest
     {
         public int ItemId { get; set; }
         public decimal SaleableStock { get; set; }
         public decimal NonSaleableStock { get; set; }
     }

    public class ItemStockResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ItemId { get; set; }

    }

    #endregion

    #region BranchStock
    public class BranchStockRequest
    {
        public int BranchId { get; set; }
        public int ItemId { get; set; }
        public decimal SaleableStock { get; set; }
        public decimal NonSaleableStock { get; set; }
    }

    public class BranchStockResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int BranchStockId { get; set; }

    }

    #endregion



    #endregion

    //======================Shivani (29/10/2022) Start===================================
    #region ItemByCategoryAndProductType
    public class CategoryDataByProductType
    {
        public string ProductTypeID { get; set; }

    }
    public class ResponseGetAllCategoryDataByProductType
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<ItemCategoryDataByProductType> Data { get; set; }
    }
    public class ItemCategoryDataByProductType
    {
        public string ItemCategoryID { get; set; }

        public string ItemCategoryName { get; set; }
        public string AppImage { get; set; }

    }
    public class BasicCategoryDataByProductType
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public string ItemCategoryID { get; set; }
        public string ItemCategoryName { get; set; }
        public string AppImage { get; set; }
    }
    #endregion

    #region ItemByCategoryAndProductType
    public class ItemByProductTypeAndCategory
    {
        public string ProductTypeID { get; set; }
        public string ItemCategoryID { get; set; }

    }
    public class ResponseGetAllItemByProductTypeAndCategory
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<ItemDataByProductTypeAndCategory> Data { get; set; }
    }
    public class ItemDataByProductTypeAndCategory
    {

        public string ItemID { get; set; }

        public string ItemName { get; set; }
        public string AppImage { get; set; }

    }
    public class BasicItemDataByProductTypeAndCategory
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string AppImage { get; set; }
    }
    #endregion
    //======================Shivani (29/10/2022) End===================================



    //======================Shivani (05/11/2022) Start===================================
    #region ProductTypeWiseBrand
    public class RequestProductTypeWiseBrand
    {
        public int ProductTypeID { get; set; }
    }
    public class ResponseProductTypeWiseBrand
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<ProductTypeWiseBrand> Data { get; set; }
    }
    public class ProductTypeWiseBrand
    {
        public int ManufacturingCompanyID { get; set; }
        public string ManufacturingCompanyName { get; set; }
        public string AppImage { get; set; }
    }
    public class BasicProductTypeWiseBrand
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ManufacturingCompanyID { get; set; }
        public string ManufacturingCompanyName { get; set; }
        public string AppImage { get; set; }
    }
    #endregion

    #region ProductTypeWiseCategory
    public class RequestProductTypeWiseCategory
    {
        public int ProductTypeID { get; set; }
    }
    public class ResponseProductTypeWiseCategory
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<ProductTypeWiseCategory> Data { get; set; }
    }
    public class ProductTypeWiseCategory
    {
        public int ItemCategoryID { get; set; }
        public string ItemCategoryName { get; set; }
        public string AppImage { get; set; }
    }
    public class BasicProductTypeWiseCategory
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ItemCategoryID { get; set; }
        public string ItemCategoryName { get; set; }
        public string AppImage { get; set; }
    }
    #endregion

    #region GetAllItem
    public class RequestBrandWiseItem
    {
        public int? ProductTypeID { get; set; }
        public int? ManufacturingCompanyID { get; set; }
    }
    public class ResponseAllItem
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<AllItem> Data { get; set; }
    }
    public class AllItem
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string AppImage { get; set; }
        public decimal MRP { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal Margin { get; set; }
        public decimal ItemRating { get; set; }
        //public string ItemCategoryId { get; set; }
        //public string ProductTypeId{ get; set; }
        //public string ManufacturingCompanyID { get; set; }
    }
    public class BasicAllItem
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string AppImage { get; set; }
        public decimal MRP { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal Margin { get; set; }
        public decimal ItemRating { get; set; }
    }
    #endregion

    #region ItemCategoryWiseItem
    public class RequestItemCategoryWiseItem
    {
        public int? ProductTypeID { get; set; }
        public int? ItemCategoryID { get; set; }
    }
    #endregion

    #region GetItemDetail
    public class RequestItemDetail
    {
        public int ItemID { get; set; }
    }

    public class ResponseItemDetail
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<ItemDetail> Data { get; set; }
    }
    public class ItemDetail
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string AppImage { get; set; }
        public decimal MRP { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal Margin { get; set; }
        //public string ManufacturingCompanyID { get; set; }
        //public string ProductTypeID { get; set; }
        //public string ItemCategoryID { get; set; }
        public string Description{ get; set; }
        public decimal ItemRating { get; set; }
        //public string ProductTypeId{ get; set; }

    }
    public class BasicItemDetail
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string AppImage { get; set; }
        public decimal MRP { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal Margin { get; set; }
        //public string ManufacturingCompanyID { get; set; }
        //public string ProductTypeID { get; set; }
        //public string ItemCategoryID { get; set; }
        public string Description { get; set; }
        public decimal ItemRating { get; set; }
    }
    #endregion
    //======================Shivani (05/11/2022) End===================================

    //======================Shivani (09/11/2022) Start===================================
    #region getAllBestSeller
    public class ResponseAllBestSeller
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<AllBestSeller> Data { get; set; }
    }
    public class AllBestSeller
    {

        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string AppImage { get; set; }
        public decimal MRP { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal Margin { get; set; }
        public decimal ItemRating { get; set; }
        //public string ManufacturingCompanyName { get; set; }
        //public string ProductTypeName { get; set; }
        //public string ItemCategoryName { get; set; }
        public string Description { get; set; }

    }
    public class BasicAllBestSeller
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string AppImage { get; set; }
        public decimal MRP { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal Margin { get; set; }
        public decimal ItemRating { get; set; }
        //public string ManufacturingCompanyName { get; set; }
        //public string ProductTypeName { get; set; }
        //public string ItemCategoryName { get; set; }
        public string Description { get; set; }
    }
    #endregion

    #region AddToCart
    public class RequestAddToCart
    {
        public int ItemID { get; set; }
        public int CustomerID { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
    public class ResponseAddToCart
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
       
    }
    
    public class BasicAddToCart
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        
    }
    #endregion

    #region GetCartList
    public class RequestGetCartList
    {
        public int CustomerID { get; set; }
    }
    public class ResponseGetCartList
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int CartCount { get; set; }
        public decimal TotalMRP { get; set; }
        public decimal TotalBillValue { get; set; }
        public decimal TotalSavings { get; set; }
        public bool IsMadicine { get; set; }
        public List<GetCartList> Data { get; set; }
    }
    public class GetCartList
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string AppImage { get; set; }
        public decimal MRP { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal Margin { get; set; }
        public decimal ItemRating { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public int CartDetailID { get; set; }
    }
    public class BasicGetCartList
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public decimal TotalMRP { get; set; }
        public decimal TotalBillValue { get; set; }
        public decimal TotalSavings { get; set; }
        public bool IsMadicine { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string AppImage { get; set; }
        public decimal MRP { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal Margin { get; set; }
        public decimal ItemRating { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public int CartDetailID { get; set; }
    }
    #endregion

    #region RemoveCart
    public class RequestRemoveCart
    {
        public int CustomerID { get; set; }
        public int CartDetailID { get; set; }
    }
    public class ResponseRemoveCart
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
    }
    
    #endregion

    #region UpdateCart
    public class RequestUpdateCart
    {
        public int CustomerID { get; set; }
        public int CartDetailID { get; set; }
        public int Quantity { get; set; }
    }
    public class ResponseUpdateCart
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        
    }
    
    #endregion

    #region OrderPlaced
    public class RequestOrderPlaced
    {
        public int CustomerID { get; set; }
        public int AddressID { get; set; }
        public string Prescription { get; set; }
    }
    public class ResponseOrderPlaced
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int CustomerOrderID { get; set; }
    }
   
    #endregion

    #region GetOrderDetail
    public class RequestGetOrderDetail
    {
        public int CustomerOrderID { get; set; }
    }
    public class ResponseGetOrderDetail
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int PaymentStatusValue { get; set; }
        public string PaymentStatus { get; set; }
        public int OrderStatusValue { get; set; }
        public string OrderStatus { get; set; }
        public int PaymentMethodValue { get; set; }
        public string PaymentMethod { get; set; }
        public int BillingStatusValue { get; set; }
        public string BillingStatus { get; set; }
        public int OrderNo { get; set; }
        public string OrderDate { get; set; }
        public int OrderItem { get; set; }
        public decimal TotalValue { get; set; }
        public int TotalQuantity { get; set; }
        public string BillNumber { get; set; }
        public string BillFile { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
        public List<GetOrderDetail> Data { get; set; }
    }
    public class GetOrderDetail
    {
       
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string AppImage { get; set; }
        public decimal MRP { get; set; }
        public int Quantity { get; set; }
       
    }
    public class BasicGetOrderDetail
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int CustomerOrderID { get; set; }
        public int PaymentStatusValue { get; set; }
        public string PaymentStatus { get; set; }
        public int OrderStatusValue { get; set; }
        public string OrderStatus { get; set; }
        public int PaymentMethodValue { get; set; }
        public string PaymentMethod { get; set; }
        public int BillingStatusValue { get; set; }
        public string BillingStatus { get; set; }
        public int OrderNo { get; set; }
        public string OrderDate { get; set; }
        public int OrderItem { get; set; }
        public decimal TotalValue { get; set; }
        public int TotalQuantity { get; set; }
        public string BillNumber { get; set; }
        public string BillFile { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string AppImage { get; set; }
        public decimal MRP { get; set; }
        public int Quantity { get; set; }
        
    }
    #endregion
    //======================Shivani (09/11/2022) End===================================

    #region GetOrder
    public class RequestGetOrder
    {
        public int CustomerID { get; set; }
    }
    public class ResponseGetOrder
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
       
        public List<GetOrder> Data { get; set; }
    }
    public class GetOrder
    {

        public int CustomerOrderID { get; set; }
        public int PaymentStatusValue { get; set; }
        public string PaymentStatus { get; set; }
        public int OrderStatusValue { get; set; }
        public string OrderStatus { get; set; }
        public int PaymentMethodValue { get; set; }
        public string PaymentMethod { get; set; }
        public int BillingStatusValue { get; set; }
        public string BillingStatus { get; set; }
        public int OrderNo { get; set; }
        public string OrderDate { get; set; }
        public int OrderItem { get; set; }
        public decimal TotalValue { get; set; }
        public int TotalQuantity { get; set; }
        public string BillNumber { get; set; }
        public string BillFile { get; set; }

    }
    public class BasicGetOrder
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int CustomerOrderID { get; set; }
        public int PaymentStatusValue { get; set; }
        public string PaymentStatus { get; set; }
        public int OrderStatusValue { get; set; }
        public string OrderStatus { get; set; }
        public int PaymentMethodValue { get; set; }
        public string PaymentMethod { get; set; }
        public int BillingStatusValue { get; set; }
        public string BillingStatus { get; set; }
        public int OrderNo { get; set; }
        public string OrderDate { get; set; }
        public int OrderItem { get; set; }
        public decimal TotalValue { get; set; }
        public int TotalQuantity { get; set; }
        public string BillNumber { get; set; }
        public string BillFile { get; set; }
       

    }
    #endregion

    #region AddCustomerAddress
    public class CustomerAddressRequest
    {
        public int CustomerID { get; set; }
        public string FriendlyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public int AreaID { get; set; }
        public int CityID { get; set; }
        public int StateID { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }


    }
    public class CustomerAddressResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }

    }

    #endregion

    #region StateList
    public class ResponseGetAllState
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<StateData> Data { get; set; }
    }
    public class StateData
    {

        public int StateID { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }

    }
    public class BasicStateData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int StateID { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
    }
    #endregion

    #region CityList
    public class RequestGetAllCity
    {
        public int StateID { get; set; }
       
    }
    public class ResponseGetAllCity
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<CityData> Data { get; set; }
    }
    public class CityData
    {

        public int CityID { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }

    }
    public class BasicCityData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int CityID { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
    }
    #endregion

    #region AreaList
    public class RequestGetAllArea
    {
        public int CityID { get; set; }

    }
    public class ResponseGetAllArea
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<AreaData> Data { get; set; }
    }
    public class AreaData
    {

        public int AreaID { get; set; }
        public string AreaName { get; set; }

    }
    public class BasicAreaData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int AreaID { get; set; }
        public string AreaName { get; set; }
    }
    #endregion

    #region Update Customer Address
    public class CustomerAddressUpdateRequest
    {
        public int AddressID { get; set; }
        public string FriendlyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public int AreaID { get; set; }
        


    }
    public class CustomerAddressUpdateResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }

    }

    #endregion

    #region Get All Customer Addresses

    public class GetAllCustomerAddressesRequest
    {
        public int CustomerID { get; set; }
        
    }
    public class CustomerAddressData
    {
        public int AddressID { get; set; }
        public int CustomerID { get; set; }
        public string FriendlyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public int AreaID { get; set; }
        public int CityID { get; set; }
        public int StateID { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }


    }
    public class GetAllCustomerAddressesResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }

        public List<CustomerAddressData> Data { get; set; }

    }

    public class BasicCustomerAddressData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int AddressID { get; set; }
        public int CustomerID { get; set; }
        public string FriendlyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public int AreaID { get; set; }
        public int CityID { get; set; }
        public int StateID { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }


    }
    #endregion

    #region ChangePassword
    public class PasswordChangeRequest
    {
        public int CustomerID { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
    public class PasswordChangeResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
    }

    #endregion

    #region ForgotPassword
    public class ForgotPasswordRequest
    {
        public string MobileNumber { get; set; }
        public string Password { get; set; }
    }
    public class ForgotPasswordResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
    }

    #endregion

    #region Page
    public class RequestGetAllPage
    {
        public int CustomerId { get; set; }
    }
    public class ResponseGetAllPage
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int CartCount { get; set; }
        public List<PageData> Data { get; set; }
    }
    public class PageData
    {
        public string PageTitle { get; set; }
        public string PageContent { get; set; }
        public int PageId { get; set; }


    }
    public class BasicPageData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int CartCount { get; set; }
        public string PageTitle { get; set; }
        public string PageContent { get; set; }
        public int PageId { get; set; }

    }
    #endregion

    #region AddWishlist
    public class AddWishlistRequest
    {
        public int CustomerID { get; set; }
        public int ItemID { get; set; }


    }
    public class AddWishlistResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }

    }

    #endregion

    #region RemoveWishlist
    public class RemoveWishlistRequest
    {
        public int WishlistId { get; set; }


    }
    public class RemoveWishlistResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }

    }

    #endregion

    #region Get All Wishlist
    public class WishlistRequest
    {
        public int CustomerID { get; set; }


    }
    public class ResponseGetAllWishlist
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }

        public List<WishlistData> Data { get; set; }
    }
    public class WishlistData
    {
        public int ItemID { get; set; }
        public string ItemImage { get; set; }
        public string ItemName { get; set; }
        public decimal MRP { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal Margin { get; set; }
        public decimal ItemRating { get; set; }
        public int WishlistId { get; set; }

    }
    public class BasicWishlistData
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ItemID { get; set; }
        public string ItemImage { get; set; }
        public string ItemName { get; set; }
        public decimal MRP { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal Margin { get; set; }
        public decimal ItemRating { get; set; }
        public int WishlistId { get; set; }

    }
    #endregion

    #region GetSearchItem
    public class RequestSearchItem
    {
        public int ProductTypeID { get; set; }
        public string SearchName { get; set; }
    }
    public class ResponseSearchItem
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public List<SearchItem> Data { get; set; }
    }
    public class SearchItem
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemImage { get; set; }
        public decimal MRP { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal Margin { get; set; }
        public decimal ItemRating { get; set; }
    }
    public class BasicSearchItem
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemImage { get; set; }
        public decimal MRP { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal Margin { get; set; }
        public decimal ItemRating { get; set; }
    }
    #endregion

}
