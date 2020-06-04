using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace WcfServiceLibrary
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class WCFService : IService1
    {
        PhoneDictionary context = new PhoneDictionary();
        public List<Phone> GetDict()
        {
            return context.PhoneObjects.OrderBy(i => i.FIO).ToList();
        }
        public void AddDict(Phone phone)
        {
            context.PhoneObjects.Add(phone);
            context.SaveChanges();
        }
        public void UpdDict(Phone phone)
        {
            Phone s = context.PhoneObjects.Find(phone.Id);
            s.FIO = phone.FIO;
            s.Telephone = phone.Telephone;
            context.SaveChanges();
        }
        public void DelDict(Phone phone)
        {
            context.PhoneObjects.Remove(context.PhoneObjects.Find(phone.Id));
            context.SaveChanges();
        }
    }
}
