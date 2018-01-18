using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using Shared;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using Shared;

namespace Eticket.Common
{
    public static class HttpHelpers
    {
        public static string HostApiUrl = WebConfigurationManager.AppSettings["HostApiUrl"];


         public static async Task<ApiResponseModel> CallGetMethodForApi(string url, string authorizationKey, bool isAuthorizationRequired)
         {

             try
             {
                 ApiResponseModel apiResponseModel = new ApiResponseModel();
                 using (var client = new HttpClient())
                 {
                     HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, new Uri(HostApiUrl + url));
                     //if (HttpContext.Current != null && HttpContext.Current.Session != null && HttpContext.Current.Session["User"] != null)
                     //{
                     //    //ValidateUserResponseEntity user = (ValidateUserResponseEntity)HttpContext.Current.Session["User"];
                     //   //authorizationKey = user.access_token;
                     //    requestMessage.Headers.Add("Authorization", "bearer " + authorizationKey);
                     //}
                     HttpResponseMessage responseMessage = await client.SendAsync(requestMessage);
                     apiResponseModel.ResponseStatusCode = responseMessage.StatusCode;
                     if (responseMessage.IsSuccessStatusCode && responseMessage.StatusCode == HttpStatusCode.OK)
                     {
                         apiResponseModel.ResponseData = responseMessage.Content.ReadAsStringAsync().Result;
                     }
                     else
                     {
                         apiResponseModel.ResponseData = "";
                     }
                     return apiResponseModel;
                 }
             }

             catch(Exception ex)
             {
                 
                 throw ex;
                 
              }

             }

         



         public class ApiResponseModel
         {
             public string ResponseData { get; set; }
             public HttpStatusCode ResponseStatusCode { get; set; }
         }






         public static async Task<ApiResponseModel> CallPostMethodForApi(string url, string authorizationKey, bool isAuthorizationRequired, string dataInJsonFormat)
         {
             ApiResponseModel apiResponseModel = new ApiResponseModel();

             using (var client = new HttpClient())
             {


                 HttpContent contentPost = new StringContent(dataInJsonFormat, Encoding.UTF8, "application/json");
                 HttpResponseMessage responseMessage = await client.PostAsync(new Uri(HostApiUrl + url), contentPost);
                 apiResponseModel.ResponseStatusCode = responseMessage.StatusCode;
                 if (responseMessage.IsSuccessStatusCode && responseMessage.StatusCode == HttpStatusCode.OK)
                 {
                     apiResponseModel.ResponseData = responseMessage.Content.ReadAsStringAsync().Result;
                 }
                 else
                 {
                     apiResponseModel.ResponseData = "";
                 }
                 return apiResponseModel;
             }
             
         }
    }
}