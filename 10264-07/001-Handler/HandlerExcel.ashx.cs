using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace _001_Handler
{
    /// <summary>
    /// Summary description for HandlerExcel
    /// </summary>
    public class HandlerExcel : IHttpHandler, IRequiresSessionState
    {
       public void ProcessRequest(HttpContext context)
        {
            context.Response.AddHeader("Content-Disposition", "attachment; filename=Dados.xls");
            context.Response.ContentType = "application/vnd.ms-excel";
            context.Response.Write(context.Session["DADOS"]);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}