using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Manatee.Trello;
using Manatee.Trello.ManateeJson;
using Manatee.Trello.WebApi;

namespace RaygunTrelloChallenge.Filters
{
    public class AuthenticatedFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext ctx)
        {
            var haveTrelloToken = !string.IsNullOrWhiteSpace(ctx.HttpContext.Session["TrelloToken"] as string);
            if (haveTrelloToken) return;

            ctx.Result = new RedirectToRouteResult(
                new RouteValueDictionary
                {
                    {"controller", "Index"},
                    {"action", "Index"}
                }
            );
        }
    }
}