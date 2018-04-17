using Microsoft.AspNetCore.Mvc;

namespace SimpleTaskSystem.Web.Controllers
{
    public class HomeController : SimpleTaskSystemControllerBase
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Tasks");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}