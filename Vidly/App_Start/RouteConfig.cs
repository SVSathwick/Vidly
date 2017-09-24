using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //custom routes
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new { controller = "Movies", Action = "ByReleaseDate" },
            //    new { year = @"\d{4}", month = @"\d{2}" });
            //   // new { year = @"2015|2016", month = @"\d{2}" }); //constraint to show movies released in 2015/2016
            routes.MapMvcAttributeRoutes(); //AttributeRouting for the above custom route

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
