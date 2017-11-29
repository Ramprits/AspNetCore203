using System;
using Microsoft.AspNetCore.Mvc.Filters;

<<<<<<< HEAD
namespace AspNetcore203.Infrastructure {
=======
namespace AspNetCore203.Infrastructure {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Method)]
    public sealed class NoCacheAttribute : ActionFilterAttribute {
        public override void OnResultExecuting (ResultExecutingContext context) {
            context.HttpContext.Response.Headers["Cache-Control"] = "no-cache, no-store, max-age=0";
            context.HttpContext.Response.Headers["Pragma"] = "no-cache";
            context.HttpContext.Response.Headers["Expires"] = "-1";
            base.OnResultExecuting (context);
        }
    }
}