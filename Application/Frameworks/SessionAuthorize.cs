using System.Web.Mvc;

namespace Application.Frameworks
{
    public class SessionAuthorize : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext context)
        {
            if (context.HttpContext.Session["Login"] == null)
            {
                context.Result = new RedirectResult("/Account/Login");
            }
        }
    }
}