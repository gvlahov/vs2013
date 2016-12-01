using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasic.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Start()
        {
            return View();
        }
    }
}
