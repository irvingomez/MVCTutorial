using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class Album
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public string Artist { get; set; }
    }
}