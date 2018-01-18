using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;

namespace Eticket.Models
{
    public class JsonResponseModel
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public string ResponseData { get; set; }
        public string RedirectUrl { get; set; }
    }

    public static class ResponseHelpers
    {
        public static JsonResponseModel CreateJsonResponseModel(HttpStatusCode apiResponseHttpStatusCode)
        {
            JsonResponseModel jsonResponseModel = new JsonResponseModel { IsSuccess = false };
            if (HttpStatusCode.Unauthorized == apiResponseHttpStatusCode)
            {
                jsonResponseModel.RedirectUrl = "/Error/Unauthorised";
            }
            else if (HttpStatusCode.GatewayTimeout == apiResponseHttpStatusCode ||
                     HttpStatusCode.ServiceUnavailable == apiResponseHttpStatusCode ||
                     HttpStatusCode.RequestTimeout == apiResponseHttpStatusCode)
            {
                // ToDo:redirect to the other timeout view
                jsonResponseModel.RedirectUrl = "";
            }
            else
            {
                // ToDo:redirect to something went wrong view
            }
            return jsonResponseModel;
        }
    }
}