using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SistemaOnline_CadastroAluno
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             "usuario",
             "usuario",
            defaults: new { controller = "Usuario", action = "Index", id = UrlParameter.Optional }

         );


            routes.MapRoute(
                 "usuario_editar",
                 "usuario/{Id}/editar",
                defaults: new { controller = "Usuario", action = "Editar", id = 0 }

             );

            routes.MapRoute(
                 "usuario_excluir",
                 "usuario/{Id}/excluir",
                defaults: new { controller = "Usuario", action = "Excluir", id = 0 }

             );
            routes.MapRoute(
                 "usuario_alterar",
                 "usuario/{id}/alterar",
                defaults: new { controller = "Usuario", action = "Alterar", id = 0 }

             );

            routes.MapRoute(
                 "usuario_criar",
                 "usuario/criar",
                defaults: new { controller = "Usuario", action = "Criar", id = UrlParameter.Optional }

             );

            routes.MapRoute(
                "usuario_novo",
                "usuario/novo",
               defaults: new { controller = "Usuario", action = "Novo", id = UrlParameter.Optional }

            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
