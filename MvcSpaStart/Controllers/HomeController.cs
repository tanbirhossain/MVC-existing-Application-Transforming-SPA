using System.Web.Mvc;

namespace MvcSpaStart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string postText)
        {
            return RedirectToAction("About", "Home", new{ postText });
        }

        public ActionResult About(string getText, string postText, string mySubmit)
        {
            ViewBag.Message = "Renders dataTable";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Uses explicit layout with full HTML";

            return View();
        }
    }
}