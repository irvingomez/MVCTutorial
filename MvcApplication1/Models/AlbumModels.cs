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
        [Required]
        [Remote("CheckAlbumName", "Album", ErrorMessage="Album name already exists")]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Artist { get; set; }

        [Range(10, 50, ErrorMessage="Price should be between 10 and 50")]
        public decimal Price { get; set; }
    }
}