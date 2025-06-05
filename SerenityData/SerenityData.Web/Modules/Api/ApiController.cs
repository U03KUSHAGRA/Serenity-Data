using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serenity.Abstractions;
using Serenity;
using Serenity.Data;
using System;
using System.Collections.Generic;
using Org.BouncyCastle.Asn1.Ocsp;
using SerenityData.Membership;
using System.Linq;
using SerenityData.Administration.Repositories;
using SerenityData.Administration;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using System.Drawing.Drawing2D;
using MailKit.Search;

namespace SerenityData.Web.Modules.Api
{
    [AllowAnonymous]
    [ApiController]
    public class ApiController:ControllerBase
    {
        public Boolean sendSmsFlag = false;
        public ITwoLevelCache Cache { get; }
        public ApiController(ITwoLevelCache cache, ITextLocalizer localizer)
        {
            Cache = cache ?? throw new ArgumentNullException(nameof(cache));
        }

        #region GetAllBanner
        //================ API to Get All Banner List ==============================
        [HttpPost, Route("Api/GetAllBanner")]
        public JsonResult GetAllBanner([FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseGetAllBanner();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicBannerData>("API_GetAllBanner"
                            , null, null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<BannerData>();

                    foreach (var item in responseAllData)
                    {
                        var data = new BannerData();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;


                        data.BannerID = item.BannerID;
                        data.BannerImage = item.BannerImage;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion 

        #region GetAllProductType
        //================ API to Get All Banner List ==============================
        [HttpPost, Route("Api/GetAllProductType")]
        public JsonResult GetAllProductType([FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseGetAllProductType();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicProductTypeData>("API_GetAllProductType"
                            , null, null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<ProductTypeData>();

                    foreach (var item in responseAllData)
                    {
                        var data = new ProductTypeData();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;

                        data.ProductTypeID = item.ProductTypeID;
                        data.AppImage = item.AppImage;
                        data.ProductTypeName=item.ProductTypeName;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region GetAllItemCategory
        //================ API to Get All Banner List ==============================
        [HttpPost, Route("Api/GetAllItemCategory")]
        public JsonResult GetAllItemCategory([FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseGetAllItemCategory();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicItemCategoryData>("API_GetAllItemCategory"
                            , null, null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<ItemCategoryData>();

                    foreach (var item in responseAllData)
                    {
                        var data = new ItemCategoryData();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;


                        data.ItemCategoryID = item.ItemCategoryID;
                        data.AppImage = item.AppImage;
                        data.ItemCategoryName = item.ItemCategoryName;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region GetAllItemType
        //================ API to Get All Banner List ==============================
        [HttpPost, Route("Api/GetAllItemType")]
        public JsonResult GetAllItemType([FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseGetAllItemType();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicItemTypeData>("API_GetAllItemType"
                            , null, null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<ItemTypeData>();

                    foreach (var item in responseAllData)
                    {
                        var data = new ItemTypeData();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;


                        data.ItemTypeID = item.ItemTypeID;
                        data.AppImage = item.AppImage;
                        data.ItemTypeName = item.ItemTypeName;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region GetAllItem
        //================ API to Get All Banner List ==============================
        [HttpPost, Route("Api/GetAllItem")]
        public JsonResult GetAllItem([FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseGetAllItem();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicItemData>("API_GetAllItem"
                            , null, null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<ItemData>();

                    foreach (var item in responseAllData)
                    {
                        var data = new ItemData();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;


                        data.ItemID = item.ItemID;
                        data.AppImage = item.AppImage;
                        data.ItemName = item.ItemName;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region CreateCustomer
        [HttpPost, Route("Api/CreateCustomer")]
        public JsonResult CreateCustomer([FromServices] ISqlConnections sqlConnections, CustomerRequest request)
        {
            var response = new CustomerResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<CustomerResponse>("API_CreateCustomer",
                         param: new
                         {
                             CustomerName = request.CustomerName,
                             MobileNumber = request.MobileNumber,
                             Email = request.Email,
                             Password = request.Password,
                             MobileDeviceId=request.MobileDeviceId

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); 
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }

        #endregion

        #region LoginApi


        //================ API to Login Data ==============================
        [HttpPost, Route("Api/Login")]
        public JsonResult Login(LoginRequest request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new LoginResponse();
            var basicData = new LoginBesicData();
           
            
            try
            {
                

                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    basicData = connection.Query<LoginBesicData>("API_CustomerLogin",
                        param: new
                        {
                            MobileNumber = request.MobileNumber,
                            Password = request.Password

                        }, null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault();
                }
                response.Code = basicData.Code;
                response.Success = basicData.Success;
                response.Message = basicData.Message;
                response.Data = new LoginData
                {
                    CustomerId = basicData.CustomerId,
                    CustomerName = basicData.CustomerName,
                    MobileNumber = basicData.MobileNumber,
                    Email = basicData.Email,
                    Password = basicData.Password,
                    BillingAddressId = basicData.BillingAddressId,
                    ShippingAddressId = basicData.ShippingAddressId,
                    RequireReLogin = basicData.RequireReLogin,
                    IsInactive= basicData.IsInactive,
                    LastDeviceAddress = basicData.LastDeviceAddress

                };
               

                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }


        [HttpPost, Route("Api/CheckMobileDevice")]
        public JsonResult CheckMobileDevice(MobileDeviceRequest request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new MobileDeviceResponse();
            var basicData = new MobileDeviceBesicData();


            try
            {


                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    basicData = connection.Query<MobileDeviceBesicData>("API_CheckCustomerDevice",
                        param: new
                        {
                            CustomerId = request.CustomerId,
                            MobileDeviceId = request.MobileDeviceId,
                            FriendlyName=request.FriendlyName,

                        }, null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault();
                }
                response.Code = basicData.Code;
                response.Success = basicData.Success;
                response.Message = basicData.Message;
                response.Data = new MobileDeviceData
                {
                    DeviceId= basicData.DeviceId,  
                    CustomerId = basicData.CustomerId,
                    FriendlyName = basicData.FriendlyName,
                    AddedOn = basicData.AddedOn,
                    IsActive = basicData.IsActive,
                    MobileDeviceId = basicData.MobileDeviceId
                };


                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region CRUD

        #region State
        [HttpPost, Route("Api/CreateState")]
        public JsonResult CreateState([FromServices] ISqlConnections sqlConnections, StateRequest request)
        {
            var response = new StateResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<StateResponse>("API_CreateState",
                         param: new
                         {
                             StateCode = request.StateCode,
                             StateName = request.StateName

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;

                  

                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/UpdateState")]
        public JsonResult UpdateState([FromServices] ISqlConnections sqlConnections, StateRequest request)
        {
            var response = new StateResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<StateResponse>("API_UpdateState",
                         param: new
                         {
                             StateId=request.StateId,
                             StateCode = request.StateCode,
                             StateName = request.StateName

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/DeleteState")]
        public JsonResult DeleteState([FromServices] ISqlConnections sqlConnections, StateRequest request)
        {
            var response = new StateResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<StateResponse>("API_DeleteState",
                         param: new
                         {
                             StateId = request.StateId
                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region City  
        [HttpPost, Route("Api/CreateCity")]
        public JsonResult CreateCity([FromServices] ISqlConnections sqlConnections, CityRequest request)
        {
            var response = new CityResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<CityResponse>("API_CreateCity",
                         param: new
                         {
                             StateId=request.StateId,
                             CityCode = request.CityCode,
                             CityName = request.CityName

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/UpdateCity")]
        public JsonResult UpdateCity([FromServices] ISqlConnections sqlConnections, CityRequest request)
        {
            var response = new CityResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<CityResponse>("API_UpdateCity",
                         param: new
                         {
                             CityId=request.CityId,
                             StateId = request.StateId,
                             CityCode = request.CityCode,
                             CityName = request.CityName

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/DeleteCity")]
        public JsonResult DeleteCity([FromServices] ISqlConnections sqlConnections, CityRequest request)
        {
            var response = new CityResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<CityResponse>("API_DeleteCity",
                         param: new
                         {
                             CityId = request.CityId
                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion
        #region CityArea
        [HttpPost, Route("Api/CreateCityArea")]
        public JsonResult CreateCityArea([FromServices] ISqlConnections sqlConnections, CityAreaRequest request)
        {
            var response = new CityAreaResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<CityAreaResponse>("API_CreateCityArea",
                         param: new
                         {
                             CityId = request.CityId,
                             AreaName = request.AreaName,
                             ReckonCode = request.ReckonCode,
                             PostalCodeStart=request.PostalCodeStart,
                             PostalCodeEnd = request.PostalCodeEnd

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/UpdateCityArea")]
        public JsonResult UpdateCityArea([FromServices] ISqlConnections sqlConnections, CityAreaRequest request)
        {
            var response = new CityAreaResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<CityAreaResponse>("API_UpdateCityArea",
                         param: new
                         {
                             CityAreaId=request.CityAreaId,
                             CityId = request.CityId,
                             AreaName = request.AreaName,
                             ReckonCode = request.ReckonCode,
                             PostalCodeStart = request.PostalCodeStart,
                             PostalCodeEnd = request.PostalCodeEnd

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/DeleteCityArea")]
        public JsonResult DeleteCityArea([FromServices] ISqlConnections sqlConnections, CityAreaRequest request)
        {
            var response = new CityAreaResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<CityAreaResponse>("API_DeleteCityArea",
                         param: new
                         {
                             CityAreaId = request.CityAreaId
                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion


        #region Branch
        [HttpPost, Route("Api/CreateBranch")]
        public JsonResult CreateBranch([FromServices] ISqlConnections sqlConnections, BranchRequest request)
        {
            var response = new BranchResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<BranchResponse>("API_CreateBranch",
                         param: new
                         {
                             
                             BranchName = request.BranchName,
                             ReckonCode = request.ReckonCode,
                             BranchAddress = request.BranchAddress,
                             PostalCode = request.PostalCode,
                             LandlineNumber = request.LandlineNumber

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/UpdateBranch")]
        public JsonResult UpdateBranch([FromServices] ISqlConnections sqlConnections, BranchRequest request)
        {
            var response = new BranchResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<BranchResponse>("API_UpdateBranch",
                         param: new
                         {
                             BranchId = request.BranchId,
                             BranchName = request.BranchName,
                             ReckonCode = request.ReckonCode,
                             BranchAddress = request.BranchAddress,
                             PostalCode = request.PostalCode,
                             LandlineNumber = request.LandlineNumber

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/DeleteBranch")]
        public JsonResult DeleteBranch([FromServices] ISqlConnections sqlConnections, BranchRequest request)
        {
            var response = new BranchResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<BranchResponse>("API_DeleteBranch",
                         param: new
                         {
                             BranchId = request.BranchId
                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region BranchArea
        [HttpPost, Route("Api/CreateBranchArea")]
        public JsonResult CreateBranchArea([FromServices] ISqlConnections sqlConnections, BranchAreaRequest request)
        {
            var response = new BranchAreaResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<BranchAreaResponse>("API_CreateBranchArea",
                         param: new
                         {

                             BranchId = request.BranchId,
                             AreaId = request.AreaId,
                             ResponsiblePerson = request.ResponsiblePerson,
                             MobileNumber = request.MobileNumber,
                             

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/UpdateBranchArea")]
        public JsonResult UpdateBranchArea([FromServices] ISqlConnections sqlConnections, BranchAreaRequest request)
        {
            var response = new BranchAreaResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<BranchAreaResponse>("API_UpdateBranchArea",
                         param: new
                         {
                             BranchAreaId=request.BranchAreaId,
                             BranchId = request.BranchId,
                             AreaId = request.AreaId,
                             ResponsiblePerson = request.ResponsiblePerson,
                             MobileNumber = request.MobileNumber,

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/DeleteBranchArea")]
        public JsonResult DeleteBranchArea([FromServices] ISqlConnections sqlConnections, BranchAreaRequest request)
        {
            var response = new BranchAreaResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<BranchAreaResponse>("API_DeleteBranchArea",
                         param: new
                         {
                             BranchAreaId = request.BranchAreaId
                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region ChemicalComposition
        [HttpPost, Route("Api/CreateChemicalComposition")]
        public JsonResult CreateChemicalComposition([FromServices] ISqlConnections sqlConnections, ChemicalCompositionRequest request)
        {
            var response = new ChemicalCompositionResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ChemicalCompositionResponse>("API_CreateChemicalComposition",
                         param: new
                         {

                             ChemicalCompositionName = request.ChemicalCompositionName,
                             ReckonCode = request.ReckonCode,
                             


                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/UpdateChemicalComposition")]
        public JsonResult UpdateChemicalComposition([FromServices] ISqlConnections sqlConnections, ChemicalCompositionRequest request)
        {
            var response = new ChemicalCompositionResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ChemicalCompositionResponse>("API_UpdateChemicalComposition",
                         param: new
                         {
                             ChemicalCompositionId = request.ChemicalCompositionId,
                             ChemicalCompositionName = request.ChemicalCompositionName,
                             ReckonCode = request.ReckonCode,
                           

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/DeleteChemicalComposition")]
        public JsonResult DeleteChemicalComposition([FromServices] ISqlConnections sqlConnections, ChemicalCompositionRequest request)
        {
            var response = new ChemicalCompositionResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ChemicalCompositionResponse>("API_DeleteChemicalComposition",
                         param: new
                         {
                             ChemicalCompositionId = request.ChemicalCompositionId
                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region ManufacturingCompany
        [HttpPost, Route("Api/CreateManufacturingCompany")]
        public JsonResult CreateManufacturingCompany([FromServices] ISqlConnections sqlConnections, ManufacturingCompanyRequest request)
        {
            var response = new ManufacturingCompanyResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ManufacturingCompanyResponse>("API_CreateManufacturingCompany",
                         param: new
                         {

                             
                             ManufacturingCompanyName = request.ManufacturingCompanyName,
                             ReckonCode = request.ReckonCode,



                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/UpdateManufacturingCompany")]
        public JsonResult UpdateManufacturingCompany([FromServices] ISqlConnections sqlConnections, ManufacturingCompanyRequest request)
        {
            var response = new ManufacturingCompanyResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ManufacturingCompanyResponse>("API_UpdateManufacturingCompany",
                         param: new
                         {
                             ManufacturingCompanyId = request.ManufacturingCompanyId,
                             ManufacturingCompanyName = request.ManufacturingCompanyName,
                             ReckonCode = request.ReckonCode,


                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/DeleteManufacturingCompany")]
        public JsonResult DeleteManufacturingCompany([FromServices] ISqlConnections sqlConnections, ManufacturingCompanyRequest request)
        {
            var response = new ManufacturingCompanyResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ManufacturingCompanyResponse>("API_DeleteManufacturingCompany",
                         param: new
                         {
                             ManufacturingCompanyId = request.ManufacturingCompanyId
                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region ItemType
        [HttpPost, Route("Api/CreateItemType")]
        public JsonResult CreateItemType([FromServices] ISqlConnections sqlConnections, ItemTypeRequest request)
        {
            var response = new ItemTypeResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ItemTypeResponse>("API_CreateItemType",
                         param: new
                         {


                             ItemTypeName = request.ItemTypeName,
                             ReckonCode = request.ReckonCode,
                             ProductTypeId=request.ProductTypeId,
                             AppImage=request.AppImage,
                             Discontinued=request.Discontinued,
                             NotApplicableForMobileSale=request.NotApplicableForMobileSale, 


                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/UpdateItemType")]
        public JsonResult UpdateItemType([FromServices] ISqlConnections sqlConnections, ItemTypeRequest request)
        {
            var response = new ItemTypeResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ItemTypeResponse>("API_UpdateItemType",
                         param: new
                         {
                             ItemTypeId=request.ItemTypeId,
                             ItemTypeName = request.ItemTypeName,
                             ReckonCode = request.ReckonCode,
                             ProductTypeId = request.ProductTypeId,
                             AppImage = request.AppImage,
                             Discontinued = request.Discontinued,
                             NotApplicableForMobileSale = request.NotApplicableForMobileSale,


                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/DeleteItemType")]
        public JsonResult DeleteItemType([FromServices] ISqlConnections sqlConnections, ItemTypeRequest request)
        {
            var response = new ItemTypeResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ItemTypeResponse>("API_DeleteItemType",
                         param: new
                         {
                             ItemTypeId = request.ItemTypeId
                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region ItemCategory
        [HttpPost, Route("Api/CreateItemCategory")]
        public JsonResult CreateItemCategory([FromServices] ISqlConnections sqlConnections, ItemCategoryRequest request)
        {
            var response = new ItemCategoryResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ItemCategoryResponse>("API_CreateItemCategory",
                         param: new
                         {


                             ItemCategoryName = request.ItemCategoryName,
                             ReckonCode = request.ReckonCode,
                             ProductTypeId = request.ProductTypeId,
                             AppImage = request.AppImage,
                             Discontinued = request.Discontinued,
                             NotApplicableForMobileSale = request.NotApplicableForMobileSale,


                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/UpdateItemCategory")]
        public JsonResult UpdateItemCategory([FromServices] ISqlConnections sqlConnections, ItemCategoryRequest request)
        {
            var response = new ItemCategoryResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ItemCategoryResponse>("API_UpdateItemCategory",
                         param: new
                         {
                             ItemCategoryId = request.ItemCategoryId,
                             ItemCategoryName = request.ItemCategoryName,
                             ReckonCode = request.ReckonCode,
                             ProductTypeId = request.ProductTypeId,
                             AppImage = request.AppImage,
                             Discontinued = request.Discontinued,
                             NotApplicableForMobileSale = request.NotApplicableForMobileSale,


                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/DeleteItemCategory")]
        public JsonResult DeleteItemCategory([FromServices] ISqlConnections sqlConnections, ItemCategoryRequest request)
        {
            var response = new ItemCategoryResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ItemCategoryResponse>("API_DeleteItemCategory",
                         param: new
                         {
                             ItemCategoryId = request.ItemCategoryId
                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region ProductType
        [HttpPost, Route("Api/CreateProductType")]
        public JsonResult CreateProductType([FromServices] ISqlConnections sqlConnections, ProductTypeRequest request)
        {
            var response = new ProductTypeResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ProductTypeResponse>("API_CreateProductType",
                         param: new
                         {


                             ProductTypeName = request.ProductTypeName,
                             AppImage = request.AppImage,
                             Discontinued = request.Discontinued,
                             NotApplicableForMobileSale = request.NotApplicableForMobileSale,


                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/UpdateProductType")]
        public JsonResult UpdateProductType([FromServices] ISqlConnections sqlConnections, ProductTypeRequest request)
        {
            var response = new ProductTypeResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ProductTypeResponse>("API_UpdateProductType",
                         param: new
                         {
                             PoductTypeId= request.ProductTypeId,
                             ProductTypeName = request.ProductTypeName,
                             AppImage = request.AppImage,
                             Discontinued = request.Discontinued,
                             NotApplicableForMobileSale = request.NotApplicableForMobileSale,

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/DeleteProductType")]
        public JsonResult DeletePoductType([FromServices] ISqlConnections sqlConnections, ProductTypeRequest request)
        {
            var response = new ProductTypeResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ProductTypeResponse>("API_DeleteProductType",
                         param: new
                         {
                             ProductTypeId = request.ProductTypeId
                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion


        #region Item
        [HttpPost, Route("Api/CreateItem")]
        public JsonResult CreateItem([FromServices] ISqlConnections sqlConnections, ItemRequest request)
        {
            var response = new ItemResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ItemResponse>("API_CreateItem",
                         param: new
                         {
                             ReckonCode = request.ReckonCode,
                             ItemName =request.ItemName,
                             PrintName = request.PrintName,
                             MRP = request.Mrp,
                             OfferPrice = request.OfferPrice,
                             GstRate = request.GstRate,
                             ManufacturingCompanyId = request.ManufacturingCompanyId,   
                             PackingName = request.PackingName,
                             ChemicalCompositionId = request.ChemicalCompositionId,
                             ProductTYpeId = request.ProductTYpeId,
                             ItemTypeId = request.ItemTypeId,
                             ItemCategoryId= request.ItemCategoryId,
                             IMarked= request.IMarked,
                             Discontinued= request.Discontinued,
                             NegativeStockBilling=request.NegativeStockBilling,
                             Remark = request.Remark,
                             AppImage = request.AppImage,
                             NotApplicableForMobileSale = request.NotApplicableForMobileSale,
                             TopProduct = request.TopProduct,
                             OfferProduct = request.OfferProduct,
                             RecommendedProduct = request.RecommendedProduct,




                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/UpdateItem")]
        public JsonResult UpdateItem([FromServices] ISqlConnections sqlConnections, ItemRequest request)
        {
            var response = new ItemResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ItemResponse>("API_UpdateItem",
                         param: new
                         {
                             ItemId=request.ItemId,
                             ItemName = request.ItemName,
                             PrintName = request.PrintName,
                             MRP = request.Mrp,
                             OfferPrice = request.OfferPrice,
                             GstRate = request.GstRate,
                             ManufacturingCompanyId = request.ManufacturingCompanyId,
                             PackingName = request.PackingName,
                             ChemicalCompositionID = request.ChemicalCompositionId,
                             ProductTYpeId = request.ProductTYpeId,
                             ItemTypeId = request.ItemTypeId,
                             ItemCategoryId = request.ItemCategoryId,
                             IMarked = request.IMarked,
                             Discontinued = request.Discontinued,
                             NegativeStockBilling = request.NegativeStockBilling,
                             Remark = request.Remark,
                             AppImage = request.AppImage,
                             NotApplicableForMobileSale = request.NotApplicableForMobileSale,
                             TopProduct = request.TopProduct,
                             OfferProduct = request.OfferProduct,
                             RecommendedProduct = request.RecommendedProduct,

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        [HttpPost, Route("Api/DeleteItem")]
        public JsonResult DeleteItem([FromServices] ISqlConnections sqlConnections, ItemRequest request)
        {
            var response = new ItemResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ItemResponse>("API_DeleteItem",
                         param: new
                         {
                             ItemId = request.ItemId
                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;



                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion



        #region ItemStock
        [HttpPost, Route("Api/ItemStock")]
        public JsonResult ItemStock([FromServices] ISqlConnections sqlConnections, ItemStockRequest request)
        {
            var response = new ItemStockResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ItemStockResponse>("API_UpdateItemStock",
                         param: new
                         {
                             ItemId=request.ItemId,
                             SaleableStock=request.SaleableStock,
                             NonSaleableStock=request.NonSaleableStock

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;

                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion


        #region BranchStock
        [HttpPost, Route("Api/BranchStock")]
        public JsonResult BranchStock([FromServices] ISqlConnections sqlConnections, BranchStockRequest request)
        {
            var response = new BranchStockResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<BranchStockResponse>("API_UpdateBranchStock",
                         param: new
                         {
                             BranchId = request.BranchId,
                             ItemId = request.ItemId,
                             SaleableStock = request.SaleableStock,
                             NonSaleableStock = request.NonSaleableStock

                         }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault(); ;

                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;

            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #endregion

        //===================================Shivani (29/10/2022) Api Start=========================================
        #region GetAllItemCategoryByProductType
        //================ API to Get All Category List By ProductType==============================
        [HttpPost, Route("Api/GetAllItemCategoryByProductType")]
        public JsonResult GetAllItemCategoryByProductType(CategoryDataByProductType request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseGetAllCategoryDataByProductType();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicCategoryDataByProductType>("API_GetAllCategoryByProductType"
                        , param: new
                        {
                            ProductTypeID = request.ProductTypeID,

                        }
                            , null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<ItemCategoryDataByProductType>();

                    foreach (var item in responseAllData)
                    {
                        var data = new ItemCategoryDataByProductType();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;


                        data.ItemCategoryID = item.ItemCategoryID;
                        data.AppImage = item.AppImage;
                        data.ItemCategoryName = item.ItemCategoryName;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region GetAllItemByProductTypeAndCategory
        //================ API to Get All Item List By ProductType and Category==============================
        [HttpPost, Route("Api/GetAllItemByProductTypeAndCategory")]
        public JsonResult GetAllItemByProductTypeAndCategory(ItemByProductTypeAndCategory request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseGetAllItemByProductTypeAndCategory();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicItemDataByProductTypeAndCategory>("API_GetAllItemByProductType"
                        , param: new
                        {
                            ProductTypeID = request.ProductTypeID,
                            ItemCategoryID = request.ItemCategoryID,

                        }
                            , null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<ItemDataByProductTypeAndCategory>();

                    foreach (var item in responseAllData)
                    {
                        var data = new ItemDataByProductTypeAndCategory();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;


                        data.ItemID = item.ItemID;
                        data.AppImage = item.AppImage;
                        data.ItemName = item.ItemName;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion
        //===================================Shivani (29/10/2022) Api End=========================================

        //================ API to Get All Category List By ProductType(05/11/2022)Start=========================================================
        #region GetProductTypeWiseBrand
        [HttpPost, Route("Api/GetProductTypeWiseBrand")]
        public JsonResult GetProductTypeWiseBrand(RequestProductTypeWiseBrand request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseProductTypeWiseBrand();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicProductTypeWiseBrand>("API_ProductTypeWiseBrand"
                        , param: new
                        {
                            ProductTypeID = request.ProductTypeID,

                        }
                            , null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<ProductTypeWiseBrand>();

                    foreach (var item in responseAllData)
                    {
                        var data = new ProductTypeWiseBrand();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;


                        data.ManufacturingCompanyID= item.ManufacturingCompanyID;
                        data.AppImage = item.AppImage;
                        data.ManufacturingCompanyName = item.ManufacturingCompanyName;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region GetProductTypeWiseCategory
        [HttpPost, Route("Api/GetProductTypeWiseCategory")]
        public JsonResult GetProductTypeWiseCategory(RequestProductTypeWiseCategory request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseProductTypeWiseCategory();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicProductTypeWiseCategory>("API_ProductTypeWiseCategory"
                        , param: new
                        {
                            ProductTypeID = request.ProductTypeID,

                        }
                            , null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<ProductTypeWiseCategory>();

                    foreach (var item in responseAllData)
                    {
                        var data = new ProductTypeWiseCategory();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;


                        data.ItemCategoryID = item.ItemCategoryID;
                        data.AppImage = item.AppImage;
                        data.ItemCategoryName = item.ItemCategoryName;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region GetBrandWiseItem
        [HttpPost, Route("Api/GetBrandWiseItem")]
        public JsonResult GetBrandWiseItem(RequestBrandWiseItem request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseAllItem();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicAllItem>("API_GetAllItemList"
                        , param: new
                        {
                            ProductTypeID = request.ProductTypeID,
                            ManufacturingCompanyID = request.ManufacturingCompanyID,
                        }
                            , null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<AllItem>();

                    foreach (var item in responseAllData)
                    {
                        var data = new AllItem();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;

                        data.ItemID = item.ItemID;
                        data.AppImage = item.AppImage;
                        data.ItemName = item.ItemName;
                        data.OfferPrice = item.OfferPrice;
                        data.MRP = item.MRP;
                        data.Margin = item.Margin;
                        data.ItemRating = item.ItemRating;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region GetCategoryWiseItem
        [HttpPost, Route("Api/GetCategoryWiseItem")]
        public JsonResult GetCategoryWiseItem(RequestItemCategoryWiseItem request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseAllItem();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicAllItem>("API_GetAllItemList"
                        , param: new
                        {
                            ProductTypeID = request.ProductTypeID,
                            ItemCategoryID = request.ItemCategoryID,

                        }
                            , null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<AllItem>();

                    foreach (var item in responseAllData)
                    {
                        var data = new AllItem();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;


                        data.ItemID = item.ItemID;
                        data.AppImage = item.AppImage;
                        data.ItemName = item.ItemName;
                        data.OfferPrice = item.OfferPrice;
                        data.MRP = item.MRP;
                        data.Margin = item.Margin;
                        data.ItemRating = item.ItemRating;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region GetItemDetail
        [HttpPost, Route("Api/GetItemDetail")]
        public JsonResult GetItemDetail(RequestItemDetail request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseItemDetail();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicItemDetail>("API_GetItemDetail"
                        , param: new
                        {
                            ItemID = request.ItemID,

                        }
                            , null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<ItemDetail>();

                    foreach (var item in responseAllData)
                    {
                        var data = new ItemDetail();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;


                        data.ItemID = item.ItemID;
                        data.AppImage = item.AppImage;
                        data.ItemName = item.ItemName;
                        data.OfferPrice = item.OfferPrice;
                        data.Description = item.Description;
                        data.MRP = item.MRP;
                        data.Margin = item.Margin;
                        data.ItemRating = item.ItemRating;
                        

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion
        //===================================API to Get All Category List By ProductType(05/11/2022) End=========================================

        //===================================Shivani (09/11/2022) Api Start=========================================
        #region GetAllBestSeller

        [HttpPost, Route("Api/GetAllBestSeller")]
        public JsonResult GetAllBestSeller([FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseAllBestSeller();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicAllBestSeller>("API_GetAllBestSellers"
                            , null, null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<AllBestSeller>();

                    foreach (var item in responseAllData)
                    {
                        var data = new AllBestSeller();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;


                        data.ItemID = item.ItemID;
                        data.AppImage = item.AppImage;
                        data.ItemName = item.ItemName;
                        data.OfferPrice = item.OfferPrice;
                        data.Description = item.Description;
                        data.MRP = item.MRP;
                        data.Margin = item.Margin;
                        data.ItemRating = item.ItemRating;
                       
                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region AddToCart
        [HttpPost, Route("Api/AddToCart")]
        public JsonResult AddToCart(RequestAddToCart request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseAddToCart();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ResponseAddToCart>("API_AddToCart"
                        , param: new
                        {
                            ItemID = request.ItemID,
                            CustomerID = request.CustomerID,
                            Quantity = request.Quantity,
                            Amount = request.Amount,
                        }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault();

                   
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion
        //===================================Shivani (09/11/2022) Api End=========================================


        //===================================Shivani (10/11/2022) Api Start=========================================
        #region GetCartList
        [HttpPost, Route("Api/GetCartList")]
        public JsonResult GetCartList(RequestGetCartList request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseGetCartList();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicGetCartList>("API_GetCartList"
                        , param: new
                        {
                            CustomerID = request.CustomerID,

                        }
                        , null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<GetCartList>();

                    foreach (var item in responseAllData)
                    {
                        var data = new GetCartList();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;
                        response.CartCount = responseAllData.Count();
                        response.TotalMRP = item.TotalMRP;
                        response.TotalBillValue = item.TotalBillValue;
                        response.TotalSavings = item.TotalSavings;
                        response.IsMadicine = item.IsMadicine;
                        //response.TotalMRP = responseAllData.Sum<BasicGetCartList>(m => m.MRP);
                        //response.TotalBillValue = responseAllData.Sum<BasicGetCartList>(m => m.Amount);
                        //response.TotalSavings = responseAllData.Sum<BasicGetCartList>(m => m.Margin); 

                       
                        data.ItemID = item.ItemID;
                        data.AppImage = item.AppImage;
                        data.ItemName = item.ItemName;
                        data.OfferPrice = item.OfferPrice;
                        data.MRP = item.MRP;
                        data.Margin = item.Margin;
                        data.ItemRating = item.ItemRating;
                        data.Quantity = item.Quantity;
                        data.Amount = item.Amount;
                        data.CartDetailID = item.CartDetailID;
                        //data.TotalBill = item.TotalBill;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region RemoveCart
        [HttpPost, Route("Api/RemoveCart")]
        public JsonResult RemoveCart(RequestRemoveCart request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseRemoveCart();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ResponseRemoveCart>("API_RemoveCart"
                        , param: new
                        {
                            CustomerID = request.CustomerID,
                            CartDetailID = request.CartDetailID,

                        }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault();
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region UpdateCart
        [HttpPost, Route("Api/UpdateCart")]
        public JsonResult UpdateCart(RequestUpdateCart request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseUpdateCart();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ResponseUpdateCart>("API_UpdateCart"
                        , param: new
                        {
                            Quantity = request.Quantity,
                            CustomerID = request.CustomerID,
                            CartDetailID= request.CartDetailID

                        }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault();
                    
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region OrderPlaced
        [HttpPost, Route("Api/OrderPlaced")]
        public JsonResult OrderPlaced(RequestOrderPlaced request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseOrderPlaced();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ResponseOrderPlaced>("API_OrderPlaced"
                        , param: new
                        {
                            CustomerID = request.CustomerID,
                            AddressID=request.AddressID ,
                            Prescription= request.Prescription

                        }
                            , null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault();
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        //===================================Shivani (10/11/2022) Api End============================================

        //===================================Shivani (11/11/2022) Api Start============================================
        #region GetOrderDetail
        [HttpPost, Route("Api/GetOrderDetail")]
        public JsonResult GetOrderDetail(RequestGetOrderDetail request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseGetOrderDetail();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicGetOrderDetail>("API_GetOrderDetail"
                        , param: new
                        {
                            CustomerOrderID = request.CustomerOrderID,

                        }
                            , null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<GetOrderDetail>();

                    foreach (var item in responseAllData)
                    {
                        var data = new GetOrderDetail();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;
                        response.PaymentStatusValue = item.PaymentStatusValue;
                        response.PaymentStatus = item.PaymentStatus;
                        response.OrderStatusValue = item.OrderStatusValue;
                        response.OrderStatus = item.OrderStatus;
                        response.PaymentMethodValue = item.PaymentMethodValue;
                        response.PaymentMethod = item.PaymentMethod;
                        response.BillingStatusValue = item.BillingStatusValue;
                        response.BillingStatus = item.BillingStatus;
                        response.OrderNo = item.OrderNo;
                        response.OrderDate = item.OrderDate;
                        response.OrderItem = item.OrderItem;
                        response.TotalValue = item.TotalValue;
                        response.TotalQuantity = item.TotalQuantity;
                        response.BillNumber = item.BillNumber;
                        response.BillFile = item.BillFile;
                        response.ShippingAddress = item.ShippingAddress;
                        response.BillingAddress = item.BillingAddress;
                        data.ItemID = item.ItemID;
                        data.ItemName = item.ItemName;
                        data.AppImage = item.AppImage;
                        data.MRP = item.MRP;
                        data.Quantity = item.Quantity;
                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion
        //===================================Shivani (11/11/2022) Api End============================================

        #region GetOrder
        [HttpPost, Route("Api/GetOrder")]
        public JsonResult GetOrder(RequestGetOrder request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseGetOrder();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicGetOrderDetail>("API_GetAllOrder"
                        , param: new
                        {
                            CustomerID = request.CustomerID,

                        }
                            , null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<GetOrder>();

                    foreach (var item in responseAllData)
                    {
                        var data = new GetOrder();

                        
                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;
                        data.CustomerOrderID = item.CustomerOrderID;
                        data.PaymentStatusValue = item.PaymentStatusValue;
                        data.PaymentStatus = item.PaymentStatus;
                        data.OrderStatusValue = item.OrderStatusValue;
                        data.OrderStatus = item.OrderStatus;
                        data.PaymentMethodValue = item.PaymentMethodValue;
                        data.PaymentMethod = item.PaymentMethod;
                        data.BillingStatusValue = item.BillingStatusValue;
                        data.BillingStatus = item.BillingStatus;
                        data.OrderNo = item.OrderNo;
                        data.OrderDate = item.OrderDate;
                        data.OrderItem = item.OrderItem;
                        data.TotalValue = item.TotalValue;
                        data.TotalQuantity = item.TotalQuantity;
                        data.BillNumber = item.BillNumber;
                        data.BillFile = item.BillFile;
                        //data.TotalQuantity = item.TotalQuantity;
                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region AddCustomerAddress
        [HttpPost, Route("Api/AddCustomerAddress")]
        public JsonResult AddCustomerAddress([FromServices] ISqlConnections sqlConnections, CustomerAddressRequest request)
        {
            var response = new CustomerAddressResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<CustomerAddressResponse>("API_AddCustomerAddress"
                           , param: new
                           {
                               CustomerID = request.CustomerID,
                               FriendlyName = request.FriendlyName,
                               Address1 = request.Address1,
                               Address2 = request.Address2,
                               PostalCode = request.PostalCode,
                               AreaID = request.AreaID,
                               CityID = request.CityID,
                               StateID = request.StateID,
                               Latitude = request.Latitude,
                               Longitude = request.Longitude,

                           }, null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault();




                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region Update Customer Address
        [HttpPost, Route("Api/UpdateCustomerAddress")]
        public JsonResult UpdateCustomerAddress([FromServices] ISqlConnections sqlConnections, CustomerAddressUpdateRequest request)
        {
            var response = new CustomerAddressResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<CustomerAddressResponse>("API_UpdateCustomerAddress"
                           , param: new
                           {
                               AddressID = request.AddressID,
                               FriendlyName = request.FriendlyName,
                               Address1 = request.Address1,
                               Address2 = request.Address2,
                               PostalCode = request.PostalCode,
                               AreaID = request.AreaID,
                           }, null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault();
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region Remove Customer Address
        [HttpPost, Route("Api/RemoveCustomerAddress")]
        public JsonResult RemoveCustomerAddress([FromServices] ISqlConnections sqlConnections, CustomerAddressUpdateRequest request)
        {
            var response = new CustomerAddressResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<CustomerAddressResponse>("API_RemoveCustomerAddress"
                           , param: new
                           {
                               AddressID = request.AddressID,

                           }, null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault();

                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region GetAllState
        //================ API to Get All State List ==============================
        [HttpPost, Route("Api/GetAllState")]
        public JsonResult GetAllState([FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseGetAllState();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicStateData>("API_GetAllState"
                            , null, null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<StateData>();

                    foreach (var item in responseAllData)
                    {
                        var data = new StateData();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;

                        data.StateID = item.StateID;
                        data.StateCode = item.StateCode;
                        data.StateName = item.StateName;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region GetAllCity
        //================ API to Get All City List ==============================
        [HttpPost, Route("Api/GetAllCity")]
        public JsonResult GetAllCity(RequestGetAllCity request,[FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseGetAllCity();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicCityData>("API_GetAllCity"
                           , param: new
                            {
                                StateID = request.StateID,

                            }, null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<CityData>();

                    foreach (var item in responseAllData)
                    {
                        var data = new CityData();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;

                        data.CityID = item.CityID;
                        data.CityCode = item.CityCode;
                        data.CityName = item.CityName;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region GetAllArea
        //================ API to Get All Area List ==============================
        [HttpPost, Route("Api/GetAllArea")]
        public JsonResult GetAllArea(RequestGetAllArea request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseGetAllArea();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicAreaData>("API_GetAllArea"
                           , param: new
                           {
                               CityID = request.CityID,

                           }, null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<AreaData>();

                    foreach (var item in responseAllData)
                    {
                        var data = new AreaData();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;

                        data.AreaID = item.AreaID;
                        data.AreaName = item.AreaName;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region Get All Customer Addresses
        //================ API to Get All Addresses List For a Customer ==============================
        [HttpPost, Route("Api/GetAllCustomerAddresses")]
        public JsonResult GetAllCustomerAddresses(GetAllCustomerAddressesRequest request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new GetAllCustomerAddressesResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicCustomerAddressData>("API_GetAllCustomerAddresses"
                           , param: new
                           {
                               CustomerID = request.CustomerID,

                           }, null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<CustomerAddressData>();

                    foreach (var item in responseAllData)
                    {
                        var data = new CustomerAddressData();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;

                        data.AddressID = item.AddressID;
                        data.FriendlyName = item.FriendlyName;
                        data.Address1 = item.Address1;
                        data.Address2 = item.Address2;
                        data.PostalCode = item.PostalCode;
                        data.AreaID = item.AreaID;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region Change Password
        [HttpPost, Route("Api/ChangePassword")]
        public JsonResult ChangePassword([FromServices] ISqlConnections sqlConnections, PasswordChangeRequest request)
        {
            var response = new PasswordChangeResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<PasswordChangeResponse>("API_ChangePassword"
                           , param: new
                           {
                               CustomerID = request.CustomerID,
                               OldPassword = request.OldPassword,
                               NewPassword = request.NewPassword

                           }, null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault();

                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region Forgot Password
        [HttpPost, Route("Api/ForgotPassword")]
        public JsonResult ForgotPassword([FromServices] ISqlConnections sqlConnections, ForgotPasswordRequest request)
        {
            var response = new ForgotPasswordResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<ForgotPasswordResponse>("API_ForgotPassword"
                           , param: new
                           {
                               MobileNumber = request.MobileNumber,
                               Password = request.Password

                           }, null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault();

                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region GetAllPages
        //================ API to Get All Page List ==============================
        [HttpPost, Route("Api/GetAllPages")]
        public JsonResult GetAllPages([FromServices] ISqlConnections sqlConnections, RequestGetAllPage request)
        {
            var response = new ResponseGetAllPage();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicPageData>("API_GetAllPage", param: new
                    {
                        CustomerId = request.CustomerId
                    }, null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<PageData>();

                    foreach (var item in responseAllData)
                    {
                        var data = new PageData();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;
                        response.CartCount = item.CartCount;

                        data.PageTitle = item.PageTitle;
                        data.PageContent = item.PageContent;
                        data.PageId = item.PageId;
                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region AddWishlist
        [HttpPost, Route("Api/AddWishlist")]
        public JsonResult AddWishlist([FromServices] ISqlConnections sqlConnections, AddWishlistRequest request)
        {
            var response = new AddWishlistResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<AddWishlistResponse>("API_AddWishlist"
                           , param: new
                           {
                               CustomerID = request.CustomerID,
                               ItemID=request.ItemID

                           }, 
                           null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault();
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region RemoveWishlist
        [HttpPost, Route("Api/RemoveWishlist")]
        public JsonResult RemoveWishlist([FromServices] ISqlConnections sqlConnections, RemoveWishlistRequest request)
        {
            var response = new RemoveWishlistResponse();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    response = connection.Query<RemoveWishlistResponse>("API_RemoveWishlist"
                           , param: new
                           {
                               WishlistId = request.WishlistId
                           }, 
                           null, true, null, System.Data.CommandType.StoredProcedure).FirstOrDefault();
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region GetAllWishlist
        [HttpPost, Route("Api/GetAllWishlist")]
        public JsonResult GetAllWishlist([FromServices] ISqlConnections sqlConnections, WishlistRequest request)
        {
            var response = new ResponseGetAllWishlist();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicWishlistData>("API_GetAllWishlist"
                            , param: new
                            {
                                CustomerID = request.CustomerID

                            }, null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<WishlistData>();

                    foreach (var item in responseAllData)
                    {
                        var data = new WishlistData();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;
                        
                        data.ItemID = item.ItemID;
                        data.ItemImage = item.ItemImage;
                        data.ItemName = item.ItemName;
                        data.MRP = item.MRP;
                        data.OfferPrice = item.OfferPrice;
                        data.Margin = item.Margin;
                        data.ItemRating = item.ItemRating;
                        data.WishlistId = item.WishlistId;
                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

        #region GetSearchItem
        [HttpPost, Route("Api/GetSearchItem")]
        public JsonResult GetSearchItem(RequestSearchItem request, [FromServices] ISqlConnections sqlConnections)
        {
            var response = new ResponseSearchItem();
            try
            {
                using (var connection = sqlConnections.NewByKey("SerenityData"))
                {
                    var responseAllData = connection.Query<BasicSearchItem>("API_GetSearchItem"
                        , param: new
                        {
                            ProductTypeID = request.ProductTypeID,
                            SearchName     = request.SearchName    

                        }
                            , null, true, null, System.Data.CommandType.StoredProcedure);

                    response.Data = new List<SearchItem>();

                    foreach (var item in responseAllData)
                    {
                        var data = new SearchItem();

                        response.Code = item.Code;
                        response.Success = item.Success;
                        response.Message = item.Message;


                        data.ItemID = item.ItemID;
                        data.ItemImage = item.ItemImage;
                        data.ItemName = item.ItemName;
                        data.OfferPrice = item.OfferPrice;
                        data.MRP = item.MRP;
                        data.Margin = item.Margin;
                        data.ItemRating = item.ItemRating;

                        response.Data.Add(data);
                    }
                }
                JsonResult jsonResult = new JsonResult(response);
                return jsonResult;
            }
            catch (Exception e)
            {
                string s = e.Message;
                JsonResult jsonResult = new JsonResult(s);
                return jsonResult;
            }
        }
        #endregion

    }
}
