using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;

namespace MathEquationsViaWord
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}