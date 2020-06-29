using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab2.AppCode
{
    public class PutHandler : IHttpHandler
    {
        //IsReusable всего лишь означает возможность использования одного и того же экземпляра, а не результата.
        //Если у вашего хэндлера есть состояние(т.е.вы сохраняете какие то данные в именно его свойства), только тогда нужно ставить false.
        //Если же(и в большинстве случаев это так) у вас весь код в методе ProcessRequest и ничего не сохраняется в свойства/поля самого хэндлера, то оставляйте true

        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            response.Write(String.Format("PUT-HTTP: ParmA:{0}, ParmB:{1}", request.Form["ParmA"]?.ToString(),
                request.Form["ParmB"]?.ToString()));
        }
    }
}