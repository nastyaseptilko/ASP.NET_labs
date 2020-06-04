using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ASP7._2.Module;
using DLLEntity;
using Ninject;

namespace ASP7._2.Services
{
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        IPhoneDictionary dictionary;
        public WebService()
        {
            var kernel = new StandardKernel(new NIConfig());
            dictionary = kernel.Get<IPhoneDictionary>();
        }
        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }
        [WebMethod]
        public List<Phone> GetDict()
        {
            return dictionary.GetAll().ToList();
        }
        [WebMethod]
        public void AddDict(Phone phone)
        {
            dictionary.Add(phone);
        }
        [WebMethod]
        public void DelDict(Phone phone)
        {
            dictionary.Delete(phone.Id);
        }
        [WebMethod]
        public void UpdDict(Phone phone)
        {
            dictionary.Update(phone);
        }

    }
}
