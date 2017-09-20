using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using ManagerTelegramBot.Models;

namespace ManagerTelegramBot
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected async void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();     
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            await Bot.Get();
        }
    }
}
