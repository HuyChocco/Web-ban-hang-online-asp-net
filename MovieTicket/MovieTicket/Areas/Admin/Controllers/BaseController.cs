using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieTicket.Areas.Admin.Controllers
{
	public class BaseController : Controller
	{
		protected override void OnActionExecuted(ActionExecutedContext filterContext)
		{
			var sess = (UserLogin)Session[Commons.CommonConstants.USER_SESSION];
			if (sess == null)
			{
				filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
				{
					Controller = "Login",
					action = "Index",
					Area = "Admin"
				}));
			}
		}
		protected void SetAlert(string message, string type)
		{
			TempData["AlertMessage"] = message;
			if (type == "success")
			{
				TempData["AlertType"] = "alert-success";
			}
			else if (type == "warning")
			{
				TempData["AlertType"] = "alert-warning";
			}
			else if (type == "error")
			{
				TempData["AlertType"] = "alert-danger";
			}
		}

	}
}