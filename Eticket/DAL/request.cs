//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class request
    {
        public request()
        {
            this.type_request = new HashSet<type_request>();
        }
    
        public int rid { get; set; }
        public string rname { get; set; }
    
        public virtual ICollection<type_request> type_request { get; set; }
    }
}
