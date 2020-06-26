using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ungdungdoctintuc.Models;

namespace Ungdungdoctintuc.Controllers
{
    public class AdminController : Controller
    {
         readonly DbTinTucDataContext data = new DbTinTucDataContext();

       

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
        // hiển thị sản phẩm trong admin
        public ActionResult ChitietTin(int id)
        {
            // laasy ra doi tuong tin theo ma
            Tin tin = data.Tins.SingleOrDefault(n => n.IdTin == id);
            ViewBag.IdTin = tin.IdTin;
            if(tin==null){
                Response.StatusCode = 404;
                return null;

            }
            return View(tin);
        }

        [HttpGet]
        public ActionResult Xoatin(int id)
        {
            Tin tins = data.Tins.SingleOrDefault(n => n.IdTin == id);
             ViewBag.IdTin = tins.IdTin;
            if(tins==null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(tins);

        }

        [HttpPost,ActionName("Xoatin")]
        public ActionResult XacnhanXoa(int id)
        {
            // lay id tin can xoa theo Idtin
            Tin tin = data.Tins.SingleOrDefault(n => n.IdTin == id);
            ViewBag.IdTin = tin.IdTin;
            if(tin==null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.Tins.DeleteOnSubmit(tin);
            data.SubmitChanges();
            return RedirectToAction("Tintuc");

        }

        [HttpGet]
        public ActionResult Suatin(int id)
        {
            // lay ra tin theo id tin
            Tin tin = data.Tins.SingleOrDefault(n => n.IdTin == id);
            ViewBag.IdChuyenMuc = new SelectList(data.ChuyenMucs.ToList().OrderBy(n => n.TenChuyenMuc), "IdChuyenMuc", "TenChuyenMuc");
          
            if (tin==null)
            {
                Response.StatusCode = 404;
                return null;
            }

            
            return View(tin);
        }

        [HttpPost, ActionName("Suatin")]
        [ValidateInput(false)]
        public ActionResult Xacnhansuatin(Tin tin,int id)
        {

           
             tin = data.Tins.SingleOrDefault(n => n.IdTin == id);
            if (tin == null)
            {
                Response.StatusCode = 404;
                return null;
            }

                UpdateModel(tin);
                data.SubmitChanges();
                return RedirectToAction("Tintuc");
            
        }



    }
}