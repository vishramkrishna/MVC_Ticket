using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using System.Data.Entity;
using System.Data.Entity.Validation;


namespace DAL
{
    public class dal
    {

        public List<request_entities> getrequest()
        {


            using (TicketEntities TicketEntities_obj = new TicketEntities())
            {

                List<request_entities> request_entities_obj = new List<request_entities>();
                request_entities_obj = TicketEntities_obj.requests.Select(p => new request_entities

                {
                   rid = p.rid,
                   rname = p.rname
                   
                 }).ToList();

                return request_entities_obj;
                               
            }
        
        }



        public List<type_request_entities> get_request_type(int rid)
        {

            using (TicketEntities TicketEntities_obj = new TicketEntities())
            {
                List<type_request_entities> type_request_obj = new List<type_request_entities>();
                type_request_obj = TicketEntities_obj.type_request.Where(p => p.rid == rid).Select(

                    p => new type_request_entities
                    {
                        rid = p.rid,
                        tid = p.tid,
                        tname = p.tname

                    }).ToList();


                return type_request_obj;
            
            }
        
        
        
        }


        public List<type_sh_entities> Post_type_sh(int tid)
        {
            try
            {
                using (TicketEntities TicketEntities_obj = new TicketEntities())
                {

                    List<type_sh_entities> type_sh_entities_obj = new List<type_sh_entities>();
                    type_sh_entities_obj = TicketEntities_obj.type_sh.Where(p => p.tid == tid).Select(
                        p => new type_sh_entities
                      {
                          tid = p.tid,
                          shid = p.shid,
                          shname = p.shname

                      }).ToList();

                    return type_sh_entities_obj;
                }

            }



            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void Post_Submit( details_entities d)
        {
            try
            {

                using (TicketEntities TicketEntities_obj = new TicketEntities())
                {

                    detail detail_obj = new detail()
                    {


                        email = d.email,
                        name = d.name,
                        password = d.password,
                        Request = d.Request,
                        type_request = d.type_request,
                        type_sh = d.type_sh,

                        extno = d.extno

                    };



                    TicketEntities_obj.details.Add(detail_obj);
                    TicketEntities_obj.SaveChanges();

                }


            }

            catch (Exception ex)
            {

                throw ex;
            }
        
        }


        //public List<details_entities> GetTicketDetails()
        //{ 
        
        //using(TicketEntities TicketEntities = new TicketEntities())
        //{
        
        //    List<details_entities> detailEntity = new List<details_entities>();
        //    detailEntity = TicketEntities.details.Select(p => new details_entities
        //    {

        //       name = p.name,
        //       password = p.password,
        //       email = p.email,
        //       extno = p.extno,
        //       Request = p.Request,
        //       type_request = p.type_request,
        //       type_sh = p.type_sh

            
            
        //    }).ToList();


        //    return detailEntity;
        //}
        
        //}



        public TicketModel GetTicketDetails(int currentPage)
        {
            try
            {

                int maxRows =10;
                using (TicketEntities TicketEnitity = new TicketEntities())
                {
                    TicketModel ticketmodel = new TicketModel();

                    ticketmodel.details = (from detail in
                                               TicketEnitity.details
                                           select new details_entities
                                               {
                                                   id = detail.id,
                                                   name = detail.name,
                                                   email = detail.email,
                                                   extno = detail.extno,
                                                   password = detail.password,
                                                   Request = detail.Request,
                                                   type_request = detail.type_request,
                                                   type_sh = detail.type_sh
                                               }).OrderBy(detail => detail.id).ToList();


                    double pageCount = (double)((decimal)TicketEnitity.details.Count()) ;
                    ticketmodel.details = ticketmodel.details.Skip(
                    (currentPage - 1) * maxRows).Take(maxRows).ToList();
                    ticketmodel.PageCount = (int)Math.Ceiling(pageCount);
                    ticketmodel.CurrentPageIndex = currentPage;
                    return ticketmodel;


                }

            }

            catch (Exception ex)
            {

                throw ex;
            }
        
        }


        public List<type_request_entities>   Gettype_request()
        {
        
            using(TicketEntities TicketEntities = new TicketEntities())
            {

                List<type_request_entities> type_request_entity = new List<type_request_entities>();
                type_request_entity = TicketEntities.type_request.Select(p => new type_request_entities
                {
                    rid = p.rid,
                    tid = p.tid,
                    tname = p.tname

                }).ToList();



                return type_request_entity;
            
            
            }


        
        }




       



    }
}
