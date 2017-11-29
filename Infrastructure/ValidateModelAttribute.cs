using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

<<<<<<< HEAD
namespace AspNetcore203.Infrastructure
=======
namespace AspNetCore203.Infrastructure
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
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