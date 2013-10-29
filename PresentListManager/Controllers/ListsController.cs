using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PresentListManager.Models;

namespace PresentListManager.Controllers
{
    public class ListsController : Controller
    {
        //
        // GET: /Lists/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var list = new PresentList {Id = 1, Description = "Christmas"};
            return View(list);
        }

    }
}
