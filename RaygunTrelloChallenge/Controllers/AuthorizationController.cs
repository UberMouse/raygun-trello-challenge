using System;
using System.Collections.Generic;
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
            var authorizationCookie = new HttpCookie("TrelloToken")
            {
                Value = Request.Form.Get("token"),
                Expires = DateTime.Now.AddDays(7)
            };
            Response.Cookies.Add(authorizationCookie);

            return new HttpStatusCodeResult(HttpStatusCode.NoContent);
        }
    }
}