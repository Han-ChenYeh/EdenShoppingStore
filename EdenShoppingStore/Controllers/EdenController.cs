using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EdenShoppingStore.Controllers
{
    public class EdenController : Controller
    {
        // GET: Eden
        public ActionResult Index()
        {
            return View();
        }
    }
}