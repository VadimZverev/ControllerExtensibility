using System.Web.Mvc;

namespace ControllerExtensibility.Infrastructure
{
    public class CustomActionInvoker : IActionInvoker
    {
        public bool InvokeAction(ControllerContext controllerContext, string actionName)
        {
            if (actionName == "Index")
            {
                controllerContext.HttpContext.
                    Response.Write("Это выводится из действия Index");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}