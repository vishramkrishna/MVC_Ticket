using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eticket.Common;
using Eticket.Models;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;


namespace Eticket.Controllers
{
    public class UserDetailController : Controller
    {
        // GET: UserDetail
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Register()
        {

            return View();
        }



        [HttpGet]
        public async Task<JsonResult> GetCategory()
         {

            JsonResponseModel responseModel = new JsonResponseModel();
            Eticket.Common.HttpHelpers.ApiResponseModel apiResponseModel = await HttpHelpers.CallGetMethodForApi("api//UserDetail//GetCategory", "", false);
            if (apiResponseModel.ResponseStatusCode == HttpStatusCode.OK)
            {
                responseModel.ResponseData = apiResponseModel.ResponseData;
                responseModel.IsSuccess = true;
                responseModel.RedirectUrl = "";

            }
            else
            {
                responseModel.ResponseData = null;
                responseModel.IsSuccess = false;
                responseModel.RedirectUrl = "/Error/Unauthorised";
            }
            return Json(responseModel, JsonRequestBehavior.AllowGet);

        
        }


        [HttpGet]
        public async Task<JsonResult> GetLocation()
        {

            JsonResponseModel responseModel = new JsonResponseModel();
            Eticket.Common.HttpHelpers.ApiResponseModel apiResponseModel = await HttpHelpers.CallGetMethodForApi("api//UserDetail//GetLocation", "", false);
            if (apiResponseModel.ResponseStatusCode == HttpStatusCode.OK)
            {
                responseModel.ResponseData = apiResponseModel.ResponseData;
                responseModel.IsSuccess = true;
                responseModel.RedirectUrl = "";

            }
            else
            {
                responseModel.ResponseData = null;
                responseModel.IsSuccess = false;
                responseModel.RedirectUrl = "/Error/Unauthorised";
            }
            return Json(responseModel, JsonRequestBehavior.AllowGet);


        }



       




    }
}