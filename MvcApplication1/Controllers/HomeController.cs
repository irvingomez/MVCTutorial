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
            return View();
        }

        public ActionResult Search(string Term)
        {
            SearchResult search = new SearchResult();
            search.Term = Term;
            search.Results = AlbumRepository
                                .FindAll()
                                    .Where(x => x.Name.ToLower()
                                        .Contains(Term.ToLower())
                                        || x.Artist.ToLower()
                                            .Contains(Term.ToLower()));
            return View(search);
        }
    }
}
