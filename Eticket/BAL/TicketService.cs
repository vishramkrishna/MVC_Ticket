using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using DAL.IRepository;

namespace BAL
{
    public class TicketService:IDisposable
    {
        private readonly ITicketRequest _ticketRepository;

        public TicketService()
        {

            _ticketRepository = FactoryService.GetTicketService();
        }


        public List<request_entities> getrequest()
        {

            return _ticketRepository.getrequest();
        }


        public List<type_request_entities> get_request_type(int rid)
        {

            return _ticketRepository.get_request_type(rid);
        }


        public List<type_sh_entities> Post_type_sh(int tid)
        {

            return _ticketRepository.Post_type_sh(tid);

        }


        public void Post_Submit(details_entities d)
        {

            _ticketRepository.Post_Submit(d);

        }

        //public List<details_entities> GetTicketDetails()
        //{

        //    return dalobj.GetTicketDetails();

        //}


        public List<type_request_entities> Gettype_request()
        {

            return _ticketRepository.Gettype_request();

        }


        public TicketModel GetTicketDetails(int currentPage)
        {
            return _ticketRepository.GetTicketDetails(currentPage);
        }




        public void Dispose()
        {
            
        }
    }
}
