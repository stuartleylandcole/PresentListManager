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
        private readonly Dictionary<int, PresentList> _presents = new Dictionary<int, PresentList>
                {
                    {1, new PresentList {Description = "Philippa - Christmas", Id = 1}},
                    {2, new PresentList {Description = "Mum - Christmas", Id = 2}},
                    {3, new PresentList {Description = "Dad - Christmas", Id = 3}}
                };

        //
        // GET: /Lists/

        public ActionResult Index()
        {
            var lists = _presents.Values.ToList();
            return View(lists);
        }

        public ActionResult Details(int id)
        {
            var list = _presents[id];
            return View(list);
        }

    }
}
