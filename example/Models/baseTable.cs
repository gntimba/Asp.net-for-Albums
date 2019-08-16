using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace example.Models
{
    public class baseTable
    {
        [Key]
        public Guid id { get; set; }
        public DateTime date_created { get; set; }
        public Boolean isActive { get; set; }
    }
}