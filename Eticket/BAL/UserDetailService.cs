using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository;
using Shared;


namespace BAL
{
   public class UserDetailService: IDisposable
    {

       private readonly IUserDetails _UserDetailRepository;

       public UserDetailService()
       {

           _UserDetailRepository = FactoryService.GetUserDetails();
       
       }

       public List<tbl_category_entities> GetCategory()
       {

           return _UserDetailRepository.GetCategory();
       }

       public List<tbl_location_entities> GetLocation()
       {
           return _UserDetailRepository.GetLocation();
       
       }


     



       public  void Dispose()
        {
            
        }
    }
}
