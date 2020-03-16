using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab2.AppCode
{
    public class GetHandler : IHttpHandler
    {
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