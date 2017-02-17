using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
    }
}