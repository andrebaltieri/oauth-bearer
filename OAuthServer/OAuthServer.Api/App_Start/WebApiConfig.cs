using Microsoft.Practices.Unity;
using Newtonsoft.Json.Serialization;
using OAuthServer.Data.DataContexts;
using OAuthServer.Data.Repositories;
using OAuthServer.Domain.Contracts;
using OAuthServer.Utils.Helpers;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace OAuthServer.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // DI
            var container = new UnityContainer();
            container.RegisterType<OAuthServerDataContext, OAuthServerDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());            
            config.DependencyResolver = new UnityResolver(container);

            // Formatter
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
