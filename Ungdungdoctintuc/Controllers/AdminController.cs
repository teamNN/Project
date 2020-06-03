using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ungdungdoctintuc.Models;

namespace Ungdungdoctintuc.Controllers
{
    public class AdminController : Controller
    {
        DbTinTucDataContext data = new DbTinTucDataContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tintuc(int ?page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 7;
            //return View(data.Tins.ToList());
            return View(data.Tins.ToList().OrderBy(n => n.IdTin).ToPagedList(pageNumber, pageSize));
        }

        [HttpGet]
        public ActionResult ThemMoiTin()
        {
            ViewBag.IdChuyenMuc = new SelectList(data.ChuyenMucs.ToList().OrderBy(n => n.TenChuyenMuc), "IdChuyenMuc", "TenChuyenMuc");
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoiTin(Tin tin)
        {
            tin.NgayDang = DateTime.Now;
            data.Tins.InsertOnSubmit(tin);
            data.SubmitChanges();
            return RedirectToAction("Tintuc");

        }


    }
}