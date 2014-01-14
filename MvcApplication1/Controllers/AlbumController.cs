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
        // GET: /Default1/

        public ActionResult Index()
        {
            return View(AlbumRepository.FindAll());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(Album model)
        {       
            try
            {
                if (ModelState.IsValid)
                {
                    AlbumRepository.Add(model);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Error, Please correct");
                }
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }

        public JsonResult CheckAlbumName(string name)
        {
            var result = AlbumRepository.FindAll()
                .Where(x => x.Name.ToLower().Equals(name.ToLower())).Count() == 0;
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
                return View("Index", AlbumRepository.FindAll()
                    .Where(x=>x.Artist.ToLower().Equals(artist.ToLower())));
            }
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
