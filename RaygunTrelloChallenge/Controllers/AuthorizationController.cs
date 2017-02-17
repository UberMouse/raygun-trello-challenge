using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RaygunTrelloChallenge.Controllers
{
    public class AuthorizationController : Controller
    {
        // GET: Authorization
        public ActionResult Index()
        {
            ViewBag.BoardsUrl = Url.Action("Index", "Boards");

            return View();
        }

        public ActionResult Token()
        {
            var token = Request.Form.Get("token");
            Session["TrelloToken"] = Request.Form.Get("token");

            return new HttpStatusCodeResult(HttpStatusCode.NoContent);
        }
    }
}