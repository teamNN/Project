using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ungdungdoctintuc.Models;

namespace Ungdungdoctintuc.Controllers
{
    public class HomeController : Controller
    {

       readonly DbTinTucDataContext data = new DbTinTucDataContext();

        public object Chuyenmucs { get; private set; }
        public object Tins { get; private set; }

        public ActionResult Index()
        {
            var tinmoi = LayTinNew(1);

            return View(tinmoi);
        }

        //3 tin sau tin dautien
        public ActionResult ShowTinMoi2()
        {
            var tinmoi = LayTinNew(4);
            //bỏ 1 tin đầu
            // var tinmoi2 = tinmoi.Skip(1);
            var tinmoi2 = tinmoi.Skip(1);
            return PartialView(tinmoi2);
        }

        //Show tin theo chuyen muc GO
        public ActionResult ShowTinTheoTheLoai1()
        {
            List<Tin> tins  = LayTinTheLoai(1);
            return PartialView(tins);
        }
        //Show tin theo chuyen muc Game OFFline
        public ActionResult ShowTinTheoTheLoai2()
        {
            List<Tin> tins = LayTinTheLoai(2);
            return PartialView(tins);
        }
        //Show tin theo chuyen muc PC
        public ActionResult ShowTinTheoTheLoai3()
        {
            List<Tin> tins  = LayTinTheLoai(3);
            return PartialView(tins);
        }
        //Show tin theo chuyen muc Esport
        public ActionResult ShowTinTheoTheLoai4()
        {
            List<Tin> tins  = LayTinTheLoai(4);
            return PartialView(tins);
        }
        //============================ laasy tin theo chuyen muc================

       
        //Hàm lấy tin theo chuyen muc

        private List<Tin> LayTinTheLoai(int id)
        {
            var tins = (
                        from a in data.TheLoais
                        join b in data.ChuyenMucs on a.IdTheLoai equals b.IdTheLoai
                        join c in data.Tins on b.IdChuyenMuc equals c.IdChuyenMuc
                        where a.IdTheLoai == id
                        select c).ToList();

            var tinOrderBy = tins.OrderByDescending(a => a.NgayDang).Take(2).ToList();
            return tinOrderBy;
        }

    

        private List<Tin> LayTinNew(int count)
        {
            // sắp xếp dữ liệu tin giảm dần theo ngày đăng ahihi
            return data.Tins.OrderByDescending(a => a.NgayDang).Take(count).ToList();
        }

        public ActionResult NavHeader()
        {
            var All_Theloai = from tt in data.TheLoais select tt;
            return PartialView(All_Theloai);
        }



        //hàm click vào xem nội dung chi tiết tin tức theo id của tin đó
        public ActionResult Details(int id)
        {
            var tin = from t in data.Tins where t.IdTin == id select t;
            return View(tin.Single());
        }

        //CODE CATEGORY

        public List<Tin> LayTinTheoTheLoai(int id)
        {
            var category = (from a in data.ChuyenMucs
                            join b in data.Tins on a.IdChuyenMuc equals b.IdChuyenMuc
                            join c in data.TheLoais on a.IdTheLoai equals c.IdTheLoai
                            where a.IdTheLoai == id
                            select b).ToList();
            return category;
        }

        // lay tin theo chuyen muc (moba/fps/.....)
      

        public ActionResult ChuyenMuc(int id)
        {
            var chuyenmuc = data.ChuyenMucs.Where(m => m.IdTheLoai == id).ToList();

            return View(chuyenmuc);
        }

     

        public ActionResult ShowPart1Category1(int id)
        {

            var category = LayTinTheoTheLoai(id);              
            var category2 = category.OrderByDescending(m => m.NgayDang).Take(2).ToList();
            return PartialView(category2);
        }

        public ActionResult ShowPart2Category2(int id)
        {
            var category = LayTinTheoTheLoai(id);
            var category2= category.OrderByDescending(m => m.NgayDang).Take(50).ToList();
            var category3 = category2.Skip(2);
            return PartialView(category3);
        }


    }
}