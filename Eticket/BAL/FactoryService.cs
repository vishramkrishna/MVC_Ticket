using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository;
using DAL.Repository;

namespace BAL
{
    static class FactoryService
    {

        static internal ITicketRequest GetTicketService()
        {

            ITicketRequest iTicketRequest = new TicketRequest();
            return iTicketRequest;
        }


        static internal IUserDetails GetUserDetails()
        {

            IUserDetails iUserDetail = new UserDetails();
            return iUserDetail;
        
        
        }


    }
}
