using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MySql.Data.MySqlClient;
using System.Net.Http.Headers;
using System.Web.Http.Cors;

namespace WebApi
{
    public static class WebApiConfig
    {

        public static MySqlConnection conn()
        {
            string conn_string = "server=localhost;port=3306;database=cloudtecnologias;username=root;";
            MySqlConnection conn = new MySqlConnection(conn_string); 
            return conn;
        }
        public static void Register(HttpConfiguration config)
        {


            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
            //var appXmltype= config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            //config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmltype);
        }
    }
}
