using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SecurityLab1_Starter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(                name: "Default",                url: "{controller}/{action}/{id}",                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }            );


            routes.MapRoute("BlankURL",
                url: "",
                defaults: new { controller = "Home", action = "Index" });

			routes.MapRoute(
            "HomeRoute",
                    url:"Home/{action}",
                    new { controller="Home", action = "Index" },
                    new {action= @"^Index$|^About$|^Contact$"}
            );


            routes.MapRoute(
            "InventoryRoute",
                    url: "Inventory/{action}",
                    new { controller = "Inventory", action = "Index" },
                    new { action = @"^Index$" }
            );

            routes.MapRoute(
            "ErrorRoute",
                    url: "Error/{action}"
            );

            /*
            routes.MapRoute(
            "CatchAll",
                    url: "{*url}",
                    defaults: new { controller = "Error", action = "NotFound" }
                  
            );*/
           
        }
    }
}
