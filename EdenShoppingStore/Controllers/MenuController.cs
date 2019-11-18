using EdenShoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace EdenShoppingStore.Controllers
{
    public class MenuController : Controller
    {
        private EdenContext edenDb = new EdenContext();
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult menuChoice(int? id)
        {

            if (id == null){
                id = 1;
            }

            using (edenDb)
            {
                var plist = from p in edenDb.Products where p.大分類ID == id select p;

                return View(plist.ToList());
            }
            
        }

    }
}