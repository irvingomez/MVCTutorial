using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class SearchResult
    {
        [Required]
        public string term { get; set; }
        public IEnumerable<Album> Results { get; set;}
    }
}