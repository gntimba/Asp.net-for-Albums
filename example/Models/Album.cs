using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace example.Models
{
    public class Album:baseTable
    {
     
        public String albumName { get; set; }
        public String albumPicture { get; set; }
        public String albumArtist { get; set; }
        public DateTime albumYear { get; set; }

    }
}