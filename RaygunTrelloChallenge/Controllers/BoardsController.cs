using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Manatee.Trello;
using Manatee.Trello.ManateeJson;

namespace RaygunTrelloChallenge.Controllers
{
    public class BoardsController : Controller
    {
        // GET: Boards
        public ActionResult Index()
        {
            return View();
        }

        // GET: Boards/:id
        public ActionResult Show()
        {
            return View();
        }
    }
}