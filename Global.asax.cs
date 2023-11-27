using StudentSubjectMarks.App_Start;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using StudentSubjectMarks;


namespace StudentSubjectMarks
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register); // Add this line for Web API
            RouteConfig.RegisterRoutes(RouteTable.Routes); // You can keep this line for MVC routes
        }
    }
}
