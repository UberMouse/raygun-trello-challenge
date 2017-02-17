using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RaygunTrelloChallenge.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            var token = Session["TrelloToken"] as string;
            if (!string.IsNullOrWhiteSpace(token))
            {
                return new RedirectToRouteResult(
                    new RouteValueDictionary
                    {
                        {"controller", "Boards"},
                        {"action", "Index"}
                    }
                );
            }

            var uriBuilder = new UriBuilder("https://trello.com/1/authorize");
            var parameters = HttpUtility.ParseQueryString(string.Empty);

            parameters["expiration"] = "never";
            parameters["name"] = "Raygun Trello Challenge";
            parameters["key"] = ConfigurationManager.AppSettings["TrelloAppKey"];
            parameters["scope"] = "read,write";
            parameters["callback_method"] = "fragment";
            parameters["redirect_uri"] = Request.Url + "Authorization/Index";
            uriBuilder.Query = parameters.ToString();

            ViewBag.AuthorizationUrl = uriBuilder.Uri;

            return View();
        }
    }
}