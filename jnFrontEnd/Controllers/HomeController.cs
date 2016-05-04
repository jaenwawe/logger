using jnFrontEnd.Models;
using System.Web.Mvc;

namespace jnFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Demo how the data can be passed in different ways

            // Session remains good between requests
            Session["data"] = "Session says suuup";

            // Since ViewBag is only a wrapper around ViewData, this property is actually overwritten
            ViewBag.Data = "ViewBag says Howdy";

            // This one will remain.. for the index view only
            ViewBag.OtherData = "ViewBag says Howdy";

            // View data, like view bag, remains for the index view only
            ViewData["data"] = "ViewData says Hello";

            // Temp data
            TempData["data"] = "Temp data says holla";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BasicDetails(int id)
        {
            User data = new User() { Id = id };
            switch (id)
            {
                case 1:
                    data.Name = "First Student";
                    break;
                case 2:
                    data.Name = "Second Student";
                    break;
            }

            return View(data);
        }

        public ActionResult RedirectAction()
        {
            // This one will remain.. for the index view only
            ViewBag.OtherData = "ViewBag says Howdy (REDIRECT)";

            // View data, like view bag, remains for the index view only
            ViewData["data"] = "ViewData says Hello (REDIRECT)";

            // Temp data
            TempData["data"] = "Temp data says holla (REDIRECT)";

            return RedirectToAction("BasicDetails", new { id = 2 });
        }

    }
}