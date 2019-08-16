using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace example.Models
{
    public class reviews:baseTable
    {
        
        public Guid albumID { get; set; }
        public String review { get; set; }
        public String name { get; set; }

    }
}