using System.Web.Mvc;
using NCS_TEST.Models;

namespace NCS_TEST.Controllers
{
    public class MainMenuController : Controller
    {
        /// <summary>
        /// メインメニュー初期表示
        /// </summary>
        public ActionResult Index()
        {
            // 仮ログイン情報
            string userName = "admin";
            string roleName = "管理者";

            var model = new MainMenuViewModel
            {
                UserName = userName,
                MaintenanceEnabled = (roleName == "管理者")
            };

            return View(model);
        }

        public ActionResult ConstructionList()
        {
            return RedirectToAction("Index", "Construction");
        }

        public ActionResult CameraList()
        {
            return RedirectToAction("Index", "Camera");
        }

        public ActionResult MaintenanceMenu()
        {
            return RedirectToAction("Index", "Maintenance");
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Default");
        }
    }
}