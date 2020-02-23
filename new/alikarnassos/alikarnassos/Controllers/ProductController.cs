using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace alikarnassos.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return Content("Einai h arxikh");
        }

        public ActionResult Mitsos()
        {
            return Content("Keimeno");
        }

        public ActionResult Pablo()
        {
            return Content("Picasso");
        }
    }
}