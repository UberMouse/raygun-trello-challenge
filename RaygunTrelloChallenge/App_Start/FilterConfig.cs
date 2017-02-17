using System.Web;
using System.Web.Mvc;
using RaygunTrelloChallenge.Filters;

namespace RaygunTrelloChallenge
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new SetupTrelloFilter());
        }
    }
}
