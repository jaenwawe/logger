using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace jnFrontEnd
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //App_Start.WebApiConfig.Register(GlobalConfiguration.Configuration);
            // Error CS0103  The name 'GlobalConfiguration' does not exist in the current context jnFrontEnd  C:\Dropbox\2016SU\686\jnLogger\jnFrontEnd\Global.asax.cs    20  Active

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
