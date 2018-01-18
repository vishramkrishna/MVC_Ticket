using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Shared
{
    public class TicketModel
    {
        private List<details_entities> _lst = new List<details_entities>();
        public  List<details_entities> details {
            get {
                return _lst;
            }

            set{
                _lst = value;
            } 
        }

        public int CurrentPageIndex { get; set; }

        public int PageCount { get; set; }


    }
}
