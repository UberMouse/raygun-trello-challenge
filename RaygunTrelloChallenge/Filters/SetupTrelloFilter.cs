using System;
using System.Configuration;
using System.Diagnostics;
using System.Web.Mvc;
using Manatee.Trello;
using Manatee.Trello.ManateeJson;
using Manatee.Trello.WebApi;

namespace RaygunTrelloChallenge.Filters
{
    public class SetupTrelloFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext ctx)
        {
            var trelloToken = ctx.HttpContext.Session["TrelloToken"] as string;
            if (string.IsNullOrWhiteSpace(trelloToken)) return;

            var serializer = new ManateeSerializer();
            TrelloConfiguration.Serializer = serializer;
            TrelloConfiguration.Deserializer = serializer;
            TrelloConfiguration.JsonFactory = new ManateeFactory();
            TrelloConfiguration.RestClientProvider = new WebApiClientProvider();

            TrelloAuthorization.Default.AppKey = ConfigurationManager.AppSettings["TrelloAppKey"];
            TrelloAuthorization.Default.UserToken = trelloToken;
        }   
    }
}