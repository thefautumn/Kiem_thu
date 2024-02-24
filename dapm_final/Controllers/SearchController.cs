using dapm_final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace dapm_final.Controllers
{
    public class SearchController : Controller
    {
        private readonly FYProjectContext _context;

        public SearchController(FYProjectContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        [HttpPost]
        public IActionResult FindProduct(string keyword)
        {
            List<Product> ls = new List<Product>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            ls = _context.Products.AsNoTracking()
                                 .Where(x => x.ProductName.Contains(keyword))
                                 .OrderByDescending(x => x.ProductName)
                                 .ToList();
            if (ls == null)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            else
            {
                return PartialView("ListProductsSearchPartial", ls);
            }
        }
    }
}
