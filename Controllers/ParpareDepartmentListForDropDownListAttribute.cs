using MVC5.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class ParpareDepartmentListForDropDownListAttribute : ActionFilterAttribute
    {
        DepartmentRepository repo = RepositoryHelper.GetDepartmentRepository();

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.DepartmentList = repo.All().Select(p => new { p.DepartmentID, p.Name }).ToList();

            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }
    }
}