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
    public class Ticket1Controller : ApiController
    {
        
        [HttpGet]
        public List<request_entities> getrequest()
        {

          using (TicketService ticketService = new TicketService())
          {
              return ticketService.getrequest();
          
           }

        }

        [HttpPost]
        public List<type_request_entities> get_request_type(int rid)
        {
            using (TicketService ticketService = new TicketService())
            {

                return ticketService.get_request_type(rid);
            }

        }


        [HttpPost]
        public List<type_sh_entities> Post_type_sh(int tid)
        {

            using (TicketService ticketService = new TicketService())
            {
                return ticketService.Post_type_sh(tid);
            }
        }


        [HttpPost]
        public void Post_Submit(details_entities d)
        {

            using (TicketService ticketService = new TicketService())
            {

            ticketService.Post_Submit(d);
            }
        }


        [HttpGet]
        public List<type_request_entities> Gettype_request()
        {
            using (TicketService ticketService = new TicketService())
            {
                return ticketService.Gettype_request();
            }
        }


        [HttpGet]
        public TicketModel GetTicketDetails(int currentPage)
        {
            using (TicketService ticketService = new TicketService())
            {
                return ticketService.GetTicketDetails(currentPage);
            }
        }

    }
}
