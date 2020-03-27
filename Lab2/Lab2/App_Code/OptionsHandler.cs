using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для OptionsHandler
/// </summary>
public class OptionsHandler : IHttpHandler
{
    
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            context.Response.Write("OptionsHandler");
        } 

    public bool IsReusable
    {
        get { return false; }
    }
}
