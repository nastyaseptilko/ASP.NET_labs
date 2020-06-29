using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab2.AppCode
{
    public class GetHandler : IHttpHandler
    {
        //IsReusable всего лишь означает возможность использования одного и того же экземпляра, а не результата.
        //Если у вашего хэндлера есть состояние(т.е.вы сохраняете какие то данные в именно его свойства), только тогда нужно ставить false. 
        //Если false - Нельзя испол. повторно на каждый запрос будет сохдаваться новый экземпляр
        //Если же(и в большинстве случаев это так) у вас весь код в методе ProcessRequest и ничего не сохраняется в свойства/поля самого хэндлера, то оставляйте true. 
        //если true - можно повторно использовать 

        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;                                                                                                            
            response.Write(String.Format("Get-HTTP: ParmA:{0}, ParmB:{1}",request.QueryString["ParmA"]?.ToString(),
                request.QueryString["ParmB"]?.ToString()));
        }

    }
}