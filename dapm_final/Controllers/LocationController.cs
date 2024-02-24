using dapm_final.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace dapm_final.Controllers
{
    public class LocationController : Controller
    {
        private readonly FYProjectContext _context;
        public LocationController(FYProjectContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region================= GET Location ===========================
        public ActionResult QuanHuyenList(int LocationId)
        {
            var QuanHuyens = _context.Locations.OrderBy(x => x.LocationId)
                .Where(x => x.Levels == 2)
                .OrderBy(x => x.Name)
                .ToList();
            return Json(QuanHuyens);
        }
        public ActionResult PhuongXaList(int LocationId)
        {
            var PhuongXas = _context.Locations.OrderBy(x => x.LocationId)
                .Where(x => x.Levels == 3)
                .OrderBy(x => x.Name)
                .ToList();
            return Json(PhuongXas);
        }
        #endregion=======================================================
    }
}
