using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace F23L034_GestContact_Cqs.WebApp.Infrastructure
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class CustomAuthorizeAttribute : TypeFilterAttribute
    {
        public CustomAuthorizeAttribute() : base(typeof(CustomAuthorizeFilter))
        {
        }
    }

    public class CustomAuthorizeFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            ISessionManager? sessionManager = context.HttpContext.RequestServices.GetService<ISessionManager>();
            if (sessionManager is not null)
            {
                if(sessionManager.UserInfo is null)
                    context.Result = new RedirectToActionResult("login", "auth", null);
            }
            else
            {
                context.Result = new ForbidResult();
            }
        }
    }
}
