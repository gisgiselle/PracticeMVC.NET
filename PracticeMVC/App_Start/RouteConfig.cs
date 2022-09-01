using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PracticeMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /* CUSTOM ROUTE NOT THE BEST USE ATTRIBUTE ROUTING
            name, custom route, defaults (name of controller and action)
            to limit to certain values @"a|b"
            routes.MapRoute(
                "MoviedByReleaseDate",
                "movies/released/{year}/{month}",
                new { controller = "Movies", action= "ByReleaseDate"},
                new { year = @"\d{4}", month = @"\d{2}" }
                );
            */

            //ATTRIBUTE ROUTING
            routes.MapMvcAttributeRoutes();

            //DEFAULT
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
