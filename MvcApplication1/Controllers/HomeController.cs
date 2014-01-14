using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using MvcApplication1.Repositories;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Help()
        {
            ViewBag.Message = "Search Page.";
            return View();
        }

        public ActionResult Search(string term)
        {
            ViewBag.Message = string.Format("Searched for {0}", term);
            SearchResult result = new SearchResult();
            result.term = term;
            result.Results = AlbumRepository.FindAll()
                .Where(x => x.Name.ToLower().Contains(term.ToLower()));
            return View(result);
        }

        public PartialViewResult SearchAsync(string term)
        {
            ViewBag.Message = string.Format("Searched for {0}", term);
            SearchResult result = new SearchResult();
            result.term = term;
            result.Results = AlbumRepository.FindAll()
                .Where(x => x.Name.ToLower().Contains(term.ToLower()));
            return PartialView(result);
        }

    }
}
