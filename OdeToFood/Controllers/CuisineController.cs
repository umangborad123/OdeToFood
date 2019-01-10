using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        //[Authorize]
        public ActionResult Search(string name = "Italian")
        {
            var message = Server.HtmlEncode(name);
            //return Json(new { Message = message, Name = "Jon" }, JsonRequestBehavior.AllowGet);
            //return File(Server.MapPath("~/Content/Site.css"), "text/css");
            //return RedirectToAction("Index", "Home", new { name = name });
            return Content(message);
        }
    }
}