using example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace example.ViewModel
{
    public class viewReviewsModel
    {
        public Album album { get; set; }
        public reviews Reviews { get; set; }
    }
}