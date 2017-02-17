using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Manatee.Trello;
using Manatee.Trello.ManateeJson;
using RaygunTrelloChallenge.ViewModels;

namespace RaygunTrelloChallenge.Controllers
{
    public class BoardsController : Controller
    {
        // GET: Boards
        public ActionResult Index()
        {
            var boards = Member.Me.Boards.ToArray();

            return View(boards);
        }

        // GET: Boards/:id
        public ActionResult Show()
        {
            return View();
        }
    }
}