using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ControleEstoque.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas(); // Este método registra todas as áreas no aplicativo. As áreas são usadas para organizar e separar logicamente diferentes partes do aplicativo.
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);//Este método registra os filtros globais que serão aplicados a todas as solicitações do aplicativo. Os filtros globais são usados para adicionar comportamentos comuns a todas as ações dos controladores, como autenticação, autorização ou tratamento de erros.
            RouteConfig.RegisterRoutes(RouteTable.Routes);//Este método registra as rotas para o aplicativo. As rotas definem como as URLs são mapeadas para os controladores e ações correspondentes.
            BundleConfig.RegisterBundles(BundleTable.Bundles);//Este método registra os pacotes de recursos, conhecidos como bundles. Os bundles são grupos de arquivos CSS e JavaScript que são combinados e minificados para otimizar o desempenho do aplicativo.
        }
    }
}
