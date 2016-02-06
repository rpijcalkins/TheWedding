using System.Collections.Generic;
using System.Web.Mvc;

namespace TheWedding.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Pictures()
        {
            var model = new Dictionary<string, List<string>>();
            model.Add("Engagement Photos", new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            model.Add("Wedding Photos", new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            return View(model);
        }

        public ActionResult RSVP()
        {
            return View();
        }
    }
}