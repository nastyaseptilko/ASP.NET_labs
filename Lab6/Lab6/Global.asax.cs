using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Lab6.Helper;
using Ninject.Web.Mvc;

namespace Lab6
{

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            DependencyResolver.SetResolver(new NinjectDependencyResolver(new StandardKernel(new NinjectRegistrations())));
        }
    }
}

