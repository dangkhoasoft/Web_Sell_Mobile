using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Ban_Dien_Thoai.Models;

namespace Web_Ban_Dien_Thoai.Controllers
{
    public class ShopMobileController : Controller
    {
        // GET: ShopMobile

        Sell_Mobile_1Entities db = new Sell_Mobile_1Entities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _MobilePartial()
        {
            var IsDiDong = db.tb_DienThoai.Take(3).ToList();
            return PartialView(IsDiDong);
        }
        public PartialViewResult Menu()
        {
            var IsLoaiSanPham = db.tb_LoaiSanPham.ToList();
            return PartialView(IsLoaiSanPham);
        }
        public PartialViewResult _Product()
        {
            var IsDienThoai = db.tb_DienThoai.ToList();
            return PartialView(IsDienThoai);
        }
        public ActionResult _GioHang()
        {
            return View();
        }
    }
}
