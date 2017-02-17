using System.Linq;
using System.Web.Mvc;
using Manatee.Trello;

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
        public ActionResult Show(string id)
        {
            var board = new Board(id);

            return View(board);
        }
    }
}