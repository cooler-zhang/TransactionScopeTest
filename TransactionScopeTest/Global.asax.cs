using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.Lifetime;

namespace TransactionScopeTest
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisterIoC();
        }

        private void RegisterIoC()
        {
            var container = new UnityContainer();
            container.RegisterType<TestDbContext>(new PerThreadLifetimeManager());
            container.RegisterType<AAARepository>();
            IoCManager.Container = container;
        }
    }
}
