using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ranta.AceTemplate.Controllers
{
    public class elementsController : Controller
    {
        public ActionResult Index()
        {
            return View("elements");
        }
    }
}