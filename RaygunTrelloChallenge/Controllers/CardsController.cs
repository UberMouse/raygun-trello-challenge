using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Manatee.Trello;

namespace RaygunTrelloChallenge.Controllers
{
    public class CardsController : Controller
    {
        // GET: Boards/:id/Cards/:id
        public ActionResult Show(string id)
        {
            var card = new Card(id);

            return View(card);
        }

        [HttpPost]
        public ActionResult Comment(string id)
        {
            var card = new Card(id);

            card.Comments.Add(Request.Form["Comment"]);

            return RedirectToAction("Show", "Cards", new { id });
        }
    }
}