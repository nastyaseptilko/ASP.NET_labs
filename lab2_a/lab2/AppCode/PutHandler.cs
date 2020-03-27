using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab2.AppCode
{
    public class PutHandler : IHttpHandler
    {
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