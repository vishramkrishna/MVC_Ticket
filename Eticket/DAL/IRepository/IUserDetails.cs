using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
   public interface IUserDetails
    {

       List<tbl_category_entities> GetCategory();
       List<tbl_location_entities> GetLocation();
       void PostUserDetail(tbl_user_entities userentity);

    }
}
