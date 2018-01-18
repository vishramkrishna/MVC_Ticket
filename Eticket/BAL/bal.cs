using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Shared;

namespace BAL
{
    public class bal
    {
        dal dalobj = new dal();

        public List<request_entities> getrequest()
        {

            return dalobj.getrequest();
        }

        public List<type_request_entities> get_request_type(int rid)
        {

            return dalobj.get_request_type(rid);
        }


        public List<type_sh_entities> Post_type_sh(int tid)
        {

            return dalobj.Post_type_sh(tid);

        }


        public void Post_Submit(details_entities d)
        {

            dalobj.Post_Submit(d);

        }

        //public List<details_entities> GetTicketDetails()
        //{

        //    return dalobj.GetTicketDetails();

        //}


        public List<type_request_entities> Gettype_request()
        {

            return dalobj.Gettype_request();

        }


        public TicketModel GetTicketDetails(int currentPage)
        {
            return dalobj.GetTicketDetails(currentPage);
        }


    }
}
