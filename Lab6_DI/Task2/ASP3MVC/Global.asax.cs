using DLLEntity;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;
using Ninject.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP3MVC
{
    public class NIConfig : NinjectModule
    {
        public override void Load()
        {
            //Bind<IPhoneDictionary>().To<PhoneDictionary>().InTransientScope();
            //Bind<IPhoneDictionary>().To<PhoneDictionary>().InThreadScope();
            Bind<IPhoneDictionary>().To<PhoneDictionary>().InRequestScope();
        }
    }
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            var kernel = new StandardKernel(new NIConfig());
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
