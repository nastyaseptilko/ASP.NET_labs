using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DLLEntity;
using Ninject.Modules;
using Ninject.Web.Common;

namespace ASP7._2.Module
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
}