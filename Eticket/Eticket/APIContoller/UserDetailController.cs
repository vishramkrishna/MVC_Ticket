using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BAL;
using Shared;

namespace Eticket.APIContoller
{
    public class UserDetailController : ApiController
    {

        [HttpGet]
    public List<tbl_category_entities> GetCategory()
     {
       using(UserDetailService userDetailService = new UserDetailService())
      {

          return userDetailService.GetCategory();
    
      }  
  
     }

        [HttpGet]
        public List<tbl_location_entities> GetLocation()
        {
        
           using(UserDetailService userDetailService = new UserDetailService())
           {

               return userDetailService.GetLocation();
           
           
           }
        
        
        }




    }
}
