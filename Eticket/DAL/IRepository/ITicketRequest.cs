using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace DAL.IRepository
{
    public interface ITicketRequest
    {

        List<request_entities> getrequest();
        List<type_request_entities> get_request_type(int rid);
        List<type_sh_entities> Post_type_sh(int tid);
        void Post_Submit(details_entities d);
         TicketModel GetTicketDetails(int currentPage);
        List<type_request_entities>   Gettype_request();


        
    }
}
