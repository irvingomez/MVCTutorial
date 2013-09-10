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

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Album model)
        {
            if (ModelState.IsValid)
            {
                AlbumRepository.Add(model);
                return RedirectToAction("Index", "Album");
            }
            else
            {
                ModelState.AddModelError("", "Error, Please correct");
            }
            return View(model);
        }

        public JsonResult CheckAlbumName(string name)
        {
            var result = AlbumRepository.FindAll().FindAll(x => x.Name.ToLower().Equals(name.ToLower())).Count == 0;
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Artist(string artist)
        {
            if (string.IsNullOrEmpty(artist))
            {
                return View("Index", AlbumRepository.FindAll());
            }
            else
            {
                return View("Index", AlbumRepository.FindAll().Where(x => x.Artist.ToLower().Equals(artist.ToLower())));
            }
        }
    }
}
