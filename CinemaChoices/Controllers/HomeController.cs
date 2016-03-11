using CinemaChoices.Models.Home;
using System.Web.Mvc;

namespace CinemaChoices.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewData = new HomePageViewData { Title = "Cinema Choices" };
            return View(viewData);
        }

        public ActionResult About()
        {
            HomePageViewData viewData = new HomePageViewData { Title = "About Cinema Choices", Details = "<p>We can show you what is on</p>" };
            return View(viewData);
        }
    }
}