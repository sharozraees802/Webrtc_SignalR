using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Webrtc_SignalR
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection Routes)
        {
            Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            try
            {
                Routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Chat", id = UrlParameter.Optional }
            );
            }
            catch (Exception)
            {

                
            }
        }
    }
}
