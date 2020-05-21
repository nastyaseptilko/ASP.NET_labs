using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DLLJSON;
using Ninject.Web.Mvc;
using Ninject.Web.Common;

namespace Lab6
{
    public class NIConfig : NinjectModule
    {
        public override void Load()
        {
            //Bind<IPhoneDictionary>().To<PhoneDictionary>().InTransientScope();
            //Bind<IPhoneDictionary>().To<PhoneDictionary>().InThreadScope(); //для каждого потока выполнения
            Bind<IPhoneDictionary>().To<PersonRepository>().InRequestScope(); //репозитория создается для каждого http-запроса. 
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

