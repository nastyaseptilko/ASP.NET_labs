using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для GetHandler
/// </summary>
/// 

public class GetHandler : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        HttpRequest request = context.Request;
        HttpResponse response = context.Response;
        response.Write(String.Format("Get-HTTP: ParmA:{0}, ParmB:{1}", request.QueryString["ParmA"]?.ToString(),
               request.QueryString["ParmB"]?.ToString()));
    }
    public bool IsReusable
    {
        get { return false; }
    }
}
