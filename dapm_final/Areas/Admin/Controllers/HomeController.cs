using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dapm_final.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin", Name = "AdminIndex")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var taikhoanID = HttpContext.Session.GetString("AccountId");
            //if (taikhoanID == null) return RedirectToAction("AdminLogin", "Account");
            return View();
        }
    }
}
