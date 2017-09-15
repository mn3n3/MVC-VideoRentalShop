using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace VideoRentalShopWep.App_Start
{
    public static class WebApiConfig
    {

        public static void Register(HttpConfiguration config)
        {


            var settings = config.Formatters.JsonFormatter.SerializerSettings;
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
             name: "DefaultApi",
             routeTemplate: "api/{controller}/{action}/{id}",
             defaults: new { id = RouteParameter.Optional }
         );
        }

    }
}