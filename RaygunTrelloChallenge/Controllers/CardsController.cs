using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RaygunTrelloChallenge.Controllers
{
    public class CardsController : Controller
    {
        // GET: Boards/:id/Cards/:id
        public ActionResult Show()
        {
            return View();
        }
    }
}