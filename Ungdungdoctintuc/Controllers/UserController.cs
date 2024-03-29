﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ungdungdoctintuc.CustomViewModel;
using Ungdungdoctintuc.Models;

namespace Ungdungdoctintuc.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private readonly DbTinTucDataContext data = new DbTinTucDataContext();



        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

                var user = data.DocGias.SingleOrDefault(x => x.Username == model.UserName);


                Session["userId"] = user.IdDocGia;
                Session["userName"] = user.Username;
                if (Session["idDetails"] == null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                    return RedirectToAction("Details", "Home", new { id = Session["idDetails"] });
            }
            return View(model);
        }

        public ActionResult Regist()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Regist(Regist model)
        {
            if (ModelState.IsValid)
            {
                if (data.DocGias.Count(x => x.Username == model.UserName) > 0)
                {
                    ModelState.AddModelError("", "Tài khoản đã tồn tại");
                }
                else if (model.rePassword != model.Password)
                {
                    ModelState.AddModelError("", "Mật khẩu nhập lại không đúng");
                }
                else
                {
                    var dg = new DocGia
                    {
                        Displayname = model.DisplayName,
                        Username = model.UserName,
                        Password = model.Password
                    };
                    data.DocGias.InsertOnSubmit(dg);
                    data.SubmitChanges();
                    return RedirectToAction("Login");
                }
            }
            return View(model);
        }
    }
}