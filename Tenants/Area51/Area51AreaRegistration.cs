using System.Web.Mvc;

namespace Area51
{
    public class Area51AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Area51";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Area51_default",
                "Area51/{controller}/{action}/{id}",
                new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}