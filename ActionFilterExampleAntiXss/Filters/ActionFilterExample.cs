using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Security.Application;

namespace ActionFilterExampleAntiXss.Filters
{
    public class ActionFilterExample : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // our code before action executes
            var stringArgs = context.ActionArguments.Where(pair => pair.Value is object).ToList();

            foreach (var keyValue in stringArgs)
            {
                foreach (var item in keyValue.Value.GetType().GetProperties())
                {
                    var unsafeValue = item.GetValue(keyValue.Value);
                    if (unsafeValue is string)
                    {
                        var safeValue = Encoder.HtmlEncode((string)unsafeValue);
                        item.SetValue(keyValue.Value, safeValue);   
                    }
                }
            }
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // our code after action executes
        }
    }
}
