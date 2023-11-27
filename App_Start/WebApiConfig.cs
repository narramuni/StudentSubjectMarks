using System.Web.Http;

namespace StudentSubjectMarks
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Enable attribute routing
            config.MapHttpAttributeRoutes();
        }
    }
}
