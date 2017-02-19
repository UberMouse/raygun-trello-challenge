using System.Linq;
using System.Web.Mvc;
using Manatee.Trello;
using RaygunTrelloChallenge.Filters;

namespace RaygunTrelloChallenge.Controllers
{
    [AuthenticatedFilter]
    public class BoardsController : Controller
    {
        // GET: Boards
        public ActionResult Index()
        {
            var boards = Member.Me.Boards.ToArray();

            return View(boards);
        }

        // GET: Boards/:id
        // Can't get it working, unsure why
        [HandleError(View = "PageNotFoundView")]
        public ActionResult Show(string id)
        {
            var board = new Board(id);

            return View(board);
        }
    }
}