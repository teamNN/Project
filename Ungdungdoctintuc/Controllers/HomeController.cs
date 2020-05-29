using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ungdungdoctintuc.Models;

namespace Ungdungdoctintuc.Controllers
{

    
    public class HomeController : Controller
    {

        DataClasses1DataContext data = new DataClasses1DataContext();
        public ActionResult Index()
        {
            var tinmoi = LayTinNew(1);

            return View(tinmoi);
        }

        private List<Tin> LayTinNew(int count)
        {
            // sắp xếp dữ liệu tin giảm dần theo ngày đăng ahihi
            return data.Tins.OrderByDescending(a => a.NgayDang).Take(count).ToList();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NavHeader()
        {
            var All_Theloai = from tt in data.TheLoais select tt;
            return PartialView(All_Theloai);
        }

        public ActionResult ChuyenMuc(int id)
        {
            var chuyenmuc = data.ChuyenMucs.Where(m => m.IdTheLoai==id).ToList();
            return View(chuyenmuc);
        }

        public ActionResult LayUrl(int id)
        {
            var urlHinh = data.Urls.Where(m => m.IdTin == id).SingleOrDefault();
            return PartialView(urlHinh);
        }
          

    

    }
}