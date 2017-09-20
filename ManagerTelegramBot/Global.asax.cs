﻿using System.Web.Http;
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
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            await Bot.Get();
        }
    }
}
