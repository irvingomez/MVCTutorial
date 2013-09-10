using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using MvcApplication1.Repositories;

namespace MvcApplication1.Controllers
{
    public class AlbumController : Controller
    {
        //
        // GET: /Album/

        public ActionResult Index()
        {
            return View(AlbumRepository.FindAll());
        }


        public ActionResult Artist(string artist)
        {
            var model = new List<Album>();
            if (string.IsNullOrEmpty(artist))
            {
                model = AlbumRepository.FindAll();
            }
            else
            {
                model = AlbumRepository.FindAll().FindAll(x => x.Artist.ToLower().Equals(artist.ToLower()));

            }
            return View("Index", model);
        }
    }
}
