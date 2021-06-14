using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AttributeRoutingInWEBAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes This is Attribute Routing
            config.MapHttpAttributeRoutes();
            //Convention Based Routing
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
