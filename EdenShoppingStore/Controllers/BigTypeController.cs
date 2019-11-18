using EdenShoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EdenShoppingStore.Controllers
{
    public class BigTypeController : Controller
    {
        private EdenContext db = new EdenContext();
        public ActionResult Index()
        {
            return View(db.BigTypes.ToList());
        }
    }
}