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
        public ActionResult Add(Album album)
        {
            if (ModelState.IsValid)
            {
                AlbumRepository.Add(album);
                return RedirectToAction("Index", "Album");
            }
            else
            {
                ModelState.AddModelError("", "Error, please correct");
            }
            return View(album);
        }

        public JsonResult CheckAlbumName(string name)
        {
            var result = AlbumRepository
                        .FindAll()
                            .Where(x => x.Name.ToLower()
                                .Equals(name.ToLower()))
                         .Count() == 0;
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}
