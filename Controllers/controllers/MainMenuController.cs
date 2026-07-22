using System.Web.Mvc;
using NCS_TEST.Models;

namespace NCS_TEST.Controllers
{
    public class MainMenuController : Controller
    {
        public ActionResult Index()
        {
            var model = new MainMenuModel();

            model.Form = new MainMenuForm()
            {
                UserName = "テストユーザ",
                MaintenanceEnabled = true
            };

            return View(model);
        }
    }
}