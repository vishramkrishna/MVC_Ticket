using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace DAL.Repository
{
    public class UserDetails : IUserDetails
    {
        public List<tbl_category_entities> GetCategory()
        {

            using (TicketEntities TicketEntities_obj = new TicketEntities())
            {
                List<tbl_category_entities> tbl_category_entities = new List<tbl_category_entities>();
                tbl_category_entities = TicketEntities_obj.tbl_category.Select(p => new tbl_category_entities
                {
                    category_id = p.category_id,
                    category_name = p.category_name

                }



                ).ToList();

                return tbl_category_entities;
            }


        }

        public List<tbl_location_entities> GetLocation()
        {

            using (TicketEntities TicketEntities_obj = new TicketEntities())
            {

                List<tbl_location_entities> tbl_location_entites_obj = new List<tbl_location_entities>();
                tbl_location_entites_obj = TicketEntities_obj.tbl_location.Select(p => new tbl_location_entities

                 {
                     location_id = p.location_id,
                     location_name = p.location_name

                 }).ToList();


                return tbl_location_entites_obj;

            }
        }


            public void PostUserDetail(tbl_user_entities userentity )
            {
            
               using( TicketEntities TicketEntities = new TicketEntities ())
               {

                   tbl_user tbl_user_obj = new tbl_user()
                   {
                       username = userentity.username,
                       id_user = userentity.id_user,
                       category = userentity.category,
                       location = userentity.location,
                       password = userentity.password

                   };

                   TicketEntities.tbl_user.Add(tbl_user_obj);
                   TicketEntities.SaveChanges();


               }

            
            }


        }
    }

