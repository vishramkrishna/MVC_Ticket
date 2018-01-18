using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAL;
using Shared;
using Eticket.Common;
using Eticket.Models;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;



namespace Eticket.Controllers
{
    public class TicketController : Controller
    {
        // GET: Ticket
       // bal balobj = new bal();
        TicketService TicketServiceobj = new TicketService();

        public ActionResult Register()
        {

            return View();
        }


        public ActionResult Ticket()
        {


            return View();
        }

        //[HttpGet]
        //public ActionResult GetTicketDetails()
        //{

        //    return Json(balobj.GetTicketDetails(), JsonRequestBehavior.AllowGet);

        //}
         
        public ActionResult MyTicket()
        {


            //return View(balobj.GetTicketDetails(1));
            return View();
            //return Json(balobj.GetTicketDetails(1));
        }


        [HttpGet]
        public ActionResult GetmyTickets(int pageid)
        {

            return Json(TicketServiceobj.GetTicketDetails(pageid), JsonRequestBehavior.AllowGet);

        }



       //[HttpGet]
       //public async Task<JsonResult> GetmyTickets(int pageid)
       //{

       //    JsonResponseModel responseModel = new JsonResponseModel();
       //    Eticket.Common.HttpHelpers.ApiResponseModel apiResponseModel = await HttpHelpers.CallGetMethodForApi("api//Ticket1//GetTicketDetails?pageid=" + pageid, "", false);
     
       //    if (apiResponseModel.ResponseStatusCode == HttpStatusCode.OK)
       //    {
       //        responseModel.ResponseData = apiResponseModel.ResponseData;
       //        responseModel.IsSuccess = true;
       //        responseModel.RedirectUrl = "";
              
       //    }
       //    else
       //    {
       //        responseModel.ResponseData = null;
       //        responseModel.IsSuccess = false;
       //        responseModel.RedirectUrl = "//Error//Unauthorised";
             
       //    }

       //    return Json(responseModel, JsonRequestBehavior.AllowGet);

       //}







        //[HttpGet]
        //public ActionResult Getrequest()
        //{

        //    return Json(TicketServiceobj.getrequest(), JsonRequestBehavior.AllowGet);
        //}



        [HttpGet]
        public async Task<JsonResult> Getrequest()
        {
            JsonResponseModel responseModel = new JsonResponseModel();
            Eticket.Common.HttpHelpers.ApiResponseModel apiResponseModel = await HttpHelpers.CallGetMethodForApi("api//Ticket1//getrequest", "", false);
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


      
        
        
    



        //[HttpPost]
        //public ActionResult Get_request_type(int rid)
        //{
        //    return Json(TicketServiceobj.get_request_type(rid));
          
        //}



        [HttpPost]
        public async Task<JsonResult> Get_request_type(int rid)
        {
            JsonResponseModel jsonResponseModel = new JsonResponseModel();
            Eticket.Common.HttpHelpers.ApiResponseModel responseModel = await HttpHelpers.CallPostMethodForApi("api//Ticket1//get_request_type?rid=" + rid, "", false,"");
            if (responseModel.ResponseStatusCode == HttpStatusCode.OK)
            {
                jsonResponseModel.ErrorMessage = "";
                jsonResponseModel.IsSuccess = true;
                jsonResponseModel.ResponseData = responseModel.ResponseData;
                if (responseModel.ResponseData == "false")
                {
                    jsonResponseModel.IsSuccess = false;
                }
            }
            else
            {
                jsonResponseModel = ResponseHelpers.CreateJsonResponseModel(responseModel.ResponseStatusCode);
            }


            return Json(jsonResponseModel, JsonRequestBehavior.AllowGet);

          }




       // [HttpPost]
       //public ActionResult Post_type_sh(int tid)
       // {

       //     return Json(TicketServiceobj.Post_type_sh(tid));
        
       // }


       [HttpPost]
      public async Task<JsonResult> Post_type_sh(int tid)
        {
            JsonResponseModel jsonResponseModel = new JsonResponseModel();
            Eticket.Common.HttpHelpers.ApiResponseModel responseModel = await HttpHelpers.CallPostMethodForApi("api//Ticket1//Post_type_sh?tid=" +tid,"",false,"");
            if (responseModel.ResponseStatusCode == HttpStatusCode.OK)
            {
                jsonResponseModel.ErrorMessage = "";
                jsonResponseModel.IsSuccess = true;
                jsonResponseModel.ResponseData = responseModel.ResponseData;
                if (responseModel.ResponseData == "false")
                {
                    jsonResponseModel.IsSuccess = false;
                }
            }
            else
            {
                jsonResponseModel = ResponseHelpers.CreateJsonResponseModel(responseModel.ResponseStatusCode);
            }


            return Json(jsonResponseModel, JsonRequestBehavior.AllowGet);
        }



        //[HttpPost]
        //public void Post_Submit(details_entities d)
        //{

        //    TicketServiceobj.Post_Submit(d);
        
        //}



        [HttpPost]
       public async Task<JsonResult> Post_Submit(details_entities d)
        {
              
            JsonResponseModel jsonResponseModel = new JsonResponseModel();
            var dataInJsonFormat = JsonConvert.SerializeObject(d);
            Eticket.Common.HttpHelpers.ApiResponseModel responseModel = await HttpHelpers.CallPostMethodForApi("api//Ticket1//Post_Submit", "", false, dataInJsonFormat);
            if (responseModel.ResponseStatusCode == HttpStatusCode.OK)
            {
                jsonResponseModel.ErrorMessage = "";
                jsonResponseModel.IsSuccess = true;
                jsonResponseModel.ResponseData = responseModel.ResponseData;
                if (responseModel.ResponseData == "false")
                {
                    jsonResponseModel.IsSuccess = false;
                }
            }
            else
            {
                jsonResponseModel = ResponseHelpers.CreateJsonResponseModel(responseModel.ResponseStatusCode);
            }


            return Json(jsonResponseModel, JsonRequestBehavior.AllowGet);
               
        }




       

        [HttpGet]
        public ActionResult Gettype_request()
        {

            return Json(TicketServiceobj.Gettype_request(), JsonRequestBehavior.AllowGet);
        
        }

       


    }
}