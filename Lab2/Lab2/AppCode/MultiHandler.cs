using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.AppCode
{
    public class MultiHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            response.Write(String.Format("MULTI-HTTP: Multiply: {0}",( Int32.TryParse(request.Form["ParmA"], out int a) ? a : 0) * (Int32.TryParse(request.Form["ParmB"], out int b) ? b : 0)));
        }
    }
}