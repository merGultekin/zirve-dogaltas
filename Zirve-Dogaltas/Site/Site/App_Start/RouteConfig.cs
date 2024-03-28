using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Site
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Mermer Masa",
                url: "mermer-masa",
                defaults: new { controller = "Home", action = "MermerMasa", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Granit Mermer Yakma",
                url: "granit-mermer-yakma",
                defaults: new { controller = "Home", action = "GranitMermerYakma", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default Homesuz",
                url: "{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
