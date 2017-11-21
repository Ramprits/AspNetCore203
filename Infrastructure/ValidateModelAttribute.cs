using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AspNet_core_203.Infrastructure
{
    public class ValidateModelAttribute : ActionFilterAttribute {
        public override void OnActionExecuting (ActionExecutingContext context) {
            base.OnActionExecuting (context);

            if (!context.ModelState.IsValid) {
                context.Result = new BadRequestObjectResult (context.ModelState);
            }
        }
    }
}