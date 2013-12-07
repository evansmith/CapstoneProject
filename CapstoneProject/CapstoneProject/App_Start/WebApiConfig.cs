using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace CapstoneProject
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //sets up the route
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //the line below makes the objects return as json, instead of xml. 
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml"));
        }
    }
}
