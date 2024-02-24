using AspNetCoreHero.ToastNotification.Abstractions;
using dapm_final.Helpper;
using dapm_final.Models;
using dapm_final.ModelViews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using dapm_final.Extension;

namespace dapm_final.Controllers /*xong*/
{
    public class CheckoutController : Controller
    {
        private readonly FYProjectContext _context;
        public INotyfService _notyfService { get; }

        public CheckoutController(FYProjectContext context, INotyfService notyfService) // xong
        {
            _context = context;
            _notyfService = notyfService;
        }
        public List<CartItem> GioHang // xong
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (gh == default(List<CartItem>))
                {
                    gh = new List<CartItem>();
                }
                return gh;
            }
        }
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(string returnUrl = null) //Xong
        {
            //Lay gio hang ra de xu ly
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            MuaHangVM model = new MuaHangVM();
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                model.CustomerId = khachhang.CustomerId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;
            }
            //ViewData["lsTinhThanh"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "Location", "Name");
            ViewBag.GioHang = cart;
            return View(model);
        }

        [HttpPost]
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(MuaHangVM muaHang) //xong
        {
            //Lay ra gio hang de xu ly
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            MuaHangVM model = new MuaHangVM();
            //if (taikhoanID == null)
            //{
            //    return RedirectToAction("Login", "Accounts", new { returnUrl = "/checkout.html" });
            //}
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                model.CustomerId = khachhang.CustomerId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;

                //khachhang.LocationId = muaHang.TinhThanh;
                //khachhang.District = muaHang.QuanHuyen;
                //khachhang.Ward = muaHang.PhuongXa;
                //khachhang.Address = muaHang.Address;

                _context.Update(khachhang);
                _context.SaveChanges();
            }
            try
            {
                if (ModelState.IsValid)
                {
                    //Khoi tao don hang
                    Order donhang = new Order();
                    //var donhang = new Models.Order();
                    donhang.CustomerId = model.CustomerId;
                    donhang.Address = model.Address;
                    donhang.LocationId = model.TinhThanh;
                    donhang.District = model.QuanHuyen;
                    donhang.Ward = model.PhuongXa;

                    donhang.OrderDate = DateTime.Now;
                    donhang.TransactStatusId = 1;//Don hang moi
                    donhang.Deleted = false;
                    donhang.Paid = false;
                    donhang.Note = Utilities.StripHTML(model.Note);
                    donhang.Totalmoney = Convert.ToInt32(cart.Sum(x => x.TotalMoney));
                    _context.Add(donhang);
                    _context.SaveChanges();

                    //tao danh sach don hang

                    foreach (var item in cart)
                    {
                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.OrderId = donhang.OrderId;
                        orderDetail.ProductId = item.product.ProductId;
                        orderDetail.Quantity = item.amount;
                        orderDetail.Total = donhang.Totalmoney;
                        orderDetail.Price = item.product.Price;
                        orderDetail.CreateDate = DateTime.Now;
                        _context.Add(orderDetail);
                    }
                    //var idDonHang = _context.Orders.Include(x => x.Customer).AsNoTracking().SingleOrDefault(x => x.OrderId == donhang.OrderId);
                    //var emailCustomer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                    _context.SaveChanges();
                    //clear gio hang
                    HttpContext.Session.Remove("GioHang");
                    //Xuat thong bao
                    _notyfService.Success("Đơn hàng đặt thành công");
                    //_emailSender.SendEmailAsync(emailCustomer.Email, "Notification!", $"<main class=\"main-content\">\r\n           <div class=\"container h-100\">\r\n            <div class=\"row h-100\">\r\n                <div class=\"col-lg-12\">\r\n                    <div class=\"breadcrumb-item\">\r\n                        <h2 class=\"breadcrumb-heading\">THÔNG TIN MUA HÀNG</h2>\r\n                                                             </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"checkout-area section-space-y-axis-100\">\r\n        <div class=\"container\">\r\n            <form>\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-6 col-12\">\r\n\r\n                        <div class=\"checkbox-form\">\r\n                            <h3>Đặt hàng thành công</h3>\r\n                            <p>Mã đơn hàng: #{idDonHang.OrderId}</p>\r\n                            <p>Cảm ơn bạn đã đặt hàng</p>\r\n                            <br />\r\n                            <h3>THÔNG TIN ĐƠN HÀNG</h3>\r\n                            <p>Thông tin giao hàng</p>\r\n                            <p>Người nhận hàng: {idDonHang.Customer.FullName}</p>\r\n                            <p>Số điện thoại: {idDonHang.Phone}</p>\r\n                            <p>Địa chỉ: {donhang.Address}</p>\r\n                            <br />\r\n                            Để xem chi tiết đơn hàng vui lòng truy cập vào <a asp-controller=\"Accounts\" asp-action=\"Dashboard\"><strong>Tài khoản cá nhân.</strong></a> Cần hỗ trợ? Liên hệ với chúng tôi qua số điện thoại 0123456789\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-6 col-12\">\r\n                                          </div>\r\n                </div>\r\n            </form>\r\n\r\n        </div>\r\n    </div>\r\n</main>");
                    //_emailSender.SendEmailAsync("namlgcd191254@fpt.edu.vn", "Notification!", $"You have a new order!");
                    foreach (var item in cart)
                    {
                        var found = _context.Products.AsNoTracking().SingleOrDefault(x => x.ProductId == item.product.ProductId);
                        if (found != null)
                        {
                            found.UnitslnStock = found.UnitslnStock - item.amount;
                            _context.Update(found);
                            _context.SaveChanges();
                        }
                    }
                    //cap nhat thong tin khach hang
                    return RedirectToAction("Success");
                }
            }
            catch
            {
                //ViewData["lsTinhThanh"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "Location", "Name");
                ViewBag.GioHang = cart;
                return View(model);
            }
            //ViewData["lsTinhThanh"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "Location", "Name");
            ViewBag.GioHang = cart;
            return View(model);
        }

        //[Route("paypal-checkout.html", Name = "Paypal")]
        //[Authorize]
        //public async System.Threading.Tasks.Task<IActionResult> PaypalCheckout()
        //{
        //    var taikhoanID = HttpContext.Session.GetString("CustomerId");
        //    if (string.IsNullOrEmpty(taikhoanID))
        //    {
        //        return RedirectToAction("Login", "Accounts", new { returnUrl = "/paypal-checkout.html" });
        //    }
        //    var environment = new SandboxEnvironment(_clientId, _secretKey);
        //    var client = new PayPalHttpClient(environment);
        //    #region Create Paypal Order
        //    var itemList = new ItemList()
        //    {
        //        Items = new List<Item>()
        //    };
        //    var total = Math.Round(GioHang.Sum(p => p.TotalMoney) / TyGiaUSD, 2);
        //    foreach (var item in GioHang)
        //    {
        //        itemList.Items.Add(new Item()
        //        {
        //            Name = item.product.ProductName,
        //            Currency = "USD",
        //            Price = Math.Round(Convert.ToDouble(item.product.Price) / TyGiaUSD, 2).ToString(),
        //            Quantity = item.amount.ToString(),
        //            Sku = "sku",
        //            Tax = "0"
        //        });
        //    }
        //    #endregion
        //    var paypalOrderId = DateTime.Now.Ticks;
        //    var hostname = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";
        //    var payment = new Payment()
        //    {
        //        Intent = "sale",
        //        Transactions = new List<Transaction>()
        //        {
        //            new Transaction()
        //            {
        //                Amount = new Amount()
        //                {
        //                    Total = total.ToString(),
        //                    Currency = "USD",
        //                    Details = new AmountDetails
        //                    {
        //                        Tax = "0",
        //                        Shipping = "0",
        //                        Subtotal = total.ToString()
        //                    }
        //                },
        //                Payee = new Payee()
        //                {
        //                    Email = "lenam-seller@gmail.com",
        //                    MerchantId = "75RNCVGXGHAFE",
        //                },
        //                ItemList = itemList,
        //                Description = $"Invoice #{paypalOrderId}",
        //                InvoiceNumber = paypalOrderId.ToString()
        //            }
        //        },
        //        RedirectUrls = new RedirectUrls()
        //        {
        //            CancelUrl = $"{hostname}/Checkout/CheckoutFail",
        //            ReturnUrl = $"{hostname}/Checkout/CheckoutSuccess"
        //        },
        //        Payer = new Payer()
        //        {
        //            PaymentMethod = "paypal"
        //        }
        //    };
        //    PaymentCreateRequest request = new PaymentCreateRequest();
        //    request.RequestBody(payment);

        //    try
        //    {
        //        var response = await client.Execute(request);
        //        var statusCode = response.StatusCode;
        //        Payment result = response.Result<Payment>();

        //        var links = result.Links.GetEnumerator();
        //        string paypalRedirectUrl = null;
        //        while (links.MoveNext())
        //        {
        //            LinkDescriptionObject lnk = links.Current;
        //            if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
        //            {
        //                //saving the payapalredirect URL to which user will be redirected for payment  
        //                paypalRedirectUrl = lnk.Href;

        //            }
        //        }

        //        return Redirect(paypalRedirectUrl);
        //    }
        //    catch (HttpException httpException)
        //    {
        //        var statusCode = httpException.StatusCode;
        //        var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();
        //        //Process when Checkout with Paypal fails
        //        return Redirect("/Checkout/CheckoutFail");
        //    }
        //}
        //public IActionResult CheckoutFail()
        //{
        //    _notyfService.Success("Đặt hàng thất bại");
        //    return RedirectToAction("Index");
        //}

        public IActionResult CheckoutSuccess()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            MuaHangVM model = new MuaHangVM();
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                model.CustomerId = khachhang.CustomerId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;
            }
            try
            {
                if (ModelState.IsValid)
                {
                    //Khoi tao don hang
                    var donhang = new Models.Order();
                    donhang.CustomerId = model.CustomerId;
                    donhang.Address = model.Address;
                    //donhang.Phone = model.Phone;
                    donhang.OrderDate = DateTime.Now;
                    donhang.TransactStatusId = 2;
                    donhang.Deleted = false;
                    donhang.Paid = false;
                    donhang.Note = Utilities.StripHTML(model.Note);
                    donhang.Totalmoney = Convert.ToInt32(cart.Sum(x => x.TotalMoney));
                    _context.Add(donhang);
                    _context.SaveChanges();
                    //tao danh sach don hang

                    foreach (var item in cart)
                    {
                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.OrderId = donhang.OrderId;
                        orderDetail.ProductId = item.product.ProductId;
                        orderDetail.Quantity = item.amount;
                        orderDetail.Total = donhang.Totalmoney;
                        orderDetail.Price = item.product.Price;
                        orderDetail.CreateDate = DateTime.Now;
                        _context.Add(orderDetail);
                    }
                    var emailCustomer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                    var idDonHang = _context.Orders.Include(x => x.Customer).AsNoTracking().SingleOrDefault(x => x.OrderId == donhang.OrderId);

                    _context.SaveChanges();
                    //clear gio hang
                    HttpContext.Session.Remove("GioHang");
                    //Xuat thong bao
                    _notyfService.Success("Đơn hàng đặt thành công");
                    //_emailSender.SendEmailAsync(emailCustomer.Email, "Notification!", $"<main class=\"main-content\">\r\n           <div class=\"container h-100\">\r\n            <div class=\"row h-100\">\r\n                <div class=\"col-lg-12\">\r\n                    <div class=\"breadcrumb-item\">\r\n                        <h2 class=\"breadcrumb-heading\">THÔNG TIN MUA HÀNG</h2>\r\n                                                             </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"checkout-area section-space-y-axis-100\">\r\n        <div class=\"container\">\r\n            <form>\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-6 col-12\">\r\n\r\n                        <div class=\"checkbox-form\">\r\n                            <h3>Đặt hàng thành công</h3>\r\n                            <p>Mã đơn hàng: #{donhang.OrderId}</p>\r\n                            <p>Cảm ơn bạn đã đặt hàng</p>\r\n                            <br />\r\n                            <h3>THÔNG TIN ĐƠN HÀNG</h3>\r\n                            <p>Thông tin giao hàng</p>\r\n                            <p>Người nhận hàng: {idDonHang.Customer.FullName}</p>\r\n                            <p>Số điện thoại: {idDonHang.Phone}</p>\r\n                            <p>Địa chỉ: {idDonHang.Address}</p>\r\n                            <br />\r\n                            Để xem chi tiết đơn hàng vui lòng truy cập vào <a asp-controller=\"Accounts\" asp-action=\"Dashboard\"><strong>Tài khoản cá nhân.</strong></a> Cần hỗ trợ? Liên hệ với chúng tôi qua số điện thoại 0123456789\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-6 col-12\">\r\n                                          </div>\r\n                </div>\r\n            </form>\r\n\r\n        </div>\r\n    </div>\r\n</main>");
                    //_emailSender.SendEmailAsync("namlgcd191254@fpt.edu.vn", "Notification!", $"You have a new order!");
                    //cap nhat thong tin khach hang
                }
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                var dataOrder = _context.Orders
                    .Where(x => x.CustomerId == Convert.ToInt32(taikhoanID))
                    .OrderByDescending(x => x.OrderDate)
                    .FirstOrDefault();
                MuaHangSuccessVM successVM = new MuaHangSuccessVM();
                successVM.FullName = khachhang.FullName;
                successVM.DonHangID = dataOrder.OrderId;
                //successVM.Phone = dataOrder.Phone;
                successVM.Address = dataOrder.Address;
                return View(successVM);
            }
            catch
            {
                //ViewData["lsTinhThanh"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "Location", "Name");
                ViewBag.GioHang = cart;
                return RedirectToAction("Index");
            }
        }
        [Route("dat-hang-thanh-cong.html", Name = "Success")]
        public IActionResult Success() //xong
        {
            try
            {
                var taikhoanID = HttpContext.Session.GetString("CustomerId");
                if (string.IsNullOrEmpty(taikhoanID))
                {
                    return RedirectToAction("Login", "Accounts", new { returnUrl = "/dat-hang-thanh-cong.html" });
                }
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                var donhang = _context.Orders
                    .Where(x => x.CustomerId == Convert.ToInt32(taikhoanID))
                    .OrderByDescending(x => x.OrderDate)
                    .FirstOrDefault();
                MuaHangSuccessVM successVM = new MuaHangSuccessVM();
                successVM.FullName = khachhang.FullName;
                successVM.DonHangID = donhang.OrderId;
                successVM.Phone = khachhang.Phone;
                successVM.Address = donhang.Address;
                successVM.PhuongXa = GetNameLocation(donhang.Ward.Value);
                successVM.TinhThanh = GetNameLocation(donhang.District.Value);
                return View(successVM);
            }
            catch
            {
                return View();
            }
        }

        public string GetNameLocation(int idlocation)
        {
            try
            {
                var location = _context.Locations.AsNoTracking().SingleOrDefault(x => x.LocationId == idlocation);
                if (location != null)
                {
                    return location.NameWithType;
                }
            }
            catch
            {
                return string.Empty;
            }
            return string.Empty;
        }
    }
}
