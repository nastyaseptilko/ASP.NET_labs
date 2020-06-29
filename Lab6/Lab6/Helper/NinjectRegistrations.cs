using Ninject.Modules;
using Ninject.Web.Common;
using AbstractPhoneDataProvider;

namespace Lab6.Helper
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IPhoneDictionary>().To<DLLJSON.PersonRepository>().InTransientScope();
            //Bind<IPhoneDictionary>().To<DLLEntity.PersonRepository>().InTransientScope();

            // InThreadScope() - новый экземпляр на каждый поток
            // InRequestScope() - новый экземпляр на каждый запрос
            // InSingletonScope() - паттерн Singleton - один на все вызовы
            // InTransientScope() - по умолчанию - новый на каждый вызов
        }
    }
}
