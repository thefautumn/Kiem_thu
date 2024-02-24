using dapm_final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace dapm_final.Areas.Admin.Controllers /*xong*/
{
    [Area("Admin")]
    public class SearchController : Controller
    {
        private readonly FYProjectContext _context;
        public SearchController(FYProjectContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult FindProduct(string keyword)
        {
            List<Product> ls = new List<Product>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            ls = _context.Products.AsNoTracking()
                                  .Include(a => a.Cat)
                                  .Where(x => x.ProductName.Contains(keyword))
                                  .OrderByDescending(x => x.ProductName)
                                  .Take(10)
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
        [HttpPost]
        public IActionResult FindCutomer(string keyword)
        {
            List<Customer> ls = new List<Customer>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListCustomerSearchPartial", null);
            }
            ls = _context.Customers.AsNoTracking()
                                  .Where(x => x.FullName.Contains(keyword))
                                  .OrderByDescending(x => x.FullName)
                                  .Take(10)
                                  .ToList();
            if (ls == null)
            {
                return PartialView("ListCustomerSearchPartial", null);
            }
            else
            {
                return PartialView("ListCustomerSearchPartial", ls);
            }
        }
    }
}
