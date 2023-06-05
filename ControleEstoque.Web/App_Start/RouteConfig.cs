using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControleEstoque.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); //é usada para manipular solicitações de arquivos especiais, como arquivos de script WebResource.axd e ScriptResource.axd. Ignorar essa rota significa que o ASP.NET MVC não tentará rotear as solicitações para esse tipo de recurso

            routes.MapRoute( // é usado para mapear uma URL para um determinado controlador e ação correspondente.
               
                name: "Default", //Isso define um nome para a rota. O nome "Default" é frequentemente usado para a rota padrão que é usada quando nenhuma outra rota é correspondente.
               
                url: "{controller}/{action}/{id}",//indica que a rota deve conter três segmentos: o nome do controlador, o nome da ação e um parâmetro opcional chamado "id". Esses segmentos são separados por barras ("/").
               
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }//Essa parte define os valores padrão para o controlador, ação e parâmetro "id" caso eles não sejam fornecidos na URL.Neste caso, o controlador padrão é "Home",
            //a ação padrão é "Index" e o parâmetro "id" é opcional.


                );
        }
    }
}
