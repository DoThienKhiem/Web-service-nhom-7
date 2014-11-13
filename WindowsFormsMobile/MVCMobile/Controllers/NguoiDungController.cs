using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMobile.Controllers;
using System.Web.Security;
using System.Net.Mail;
using System.Net;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ServiceModel;
using MVCMobile.ServiceReferenceSanPham;
using MVCMobile.ServiceReferenceDanhMuc;
using MVCMobile.ServiceReferenceUser;
using MVCMobile.Models;


namespace MVCMobile.Controllers
{
    public class NguoiDungController : Controller
    {
        //
        // GET: /User/
        //string quyen1 = "";
        private ServiceUserClient svuser = new ServiceUserClient();
        private ServiceSanPhamClient svsanpham = new ServiceSanPhamClient();

        public ActionResult DangNhap()
        {

            return View();


        }
        //chuc nang login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection f, string returnUrl)
        {

            string username = f["user"];
            string password = f["pass"];

            //----------------------------------------
            bool userVaild = svuser.Login(username, password);
            if (userVaild)
            {
                Session["User"] = username;

                FormsAuthentication.SetAuthCookie(username, true);


                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    ViewBag.Err = "<script language=javascript>alert('Sai thông tin đăng nhập!');</script>";
                    return RedirectToAction("Index", "SanPham");
                }
            }
            else
            {
                ViewBag.Error = "<script language=javascript>alert('Tên đăng nhập hoặc mật khẩu không đúng');</script>";
                ViewBag.Err = "<script language=javascript>alert('Sai thông tin đăng nhập!');</script>";
                return RedirectToAction("Index", "SanPham");

            }

            return RedirectToAction("Index", "SanPham");


        }

        // Edit User
        public ActionResult EditUser()
        {
            
            NguoiDung user = svuser.EditUser(HttpContext.User.Identity.Name);
            return View(user);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection f)
        {

            svuser.EditUser(HttpContext.User.Identity.Name, f["User"], f["Pass"], f["Fullname"], f["Email"], f["DiaChi"], f["SoDienThoai"], f["NgaySinh"]);
            return RedirectToAction("Index", "SanPham");
        }

        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKyUser(FormCollection f)
        {

            svuser.AddUser(f["User"], f["Pass"], f["Fullname"], f["Email"], f["DiaChi"], f["DienThoai"], f["NgaySinh"]);
            return RedirectToAction("Index", "SanPham");
        }

         public ActionResult LogOff()
        {
            Session[MVCMobile.Models.MySession.TongSL] = "0";

            MVCMobile.Models.MySession.TongTien = 0;
            List<Products> lst = new List<Products>();

            lst.Clear();

            MySession.GioHang = lst;
            List<Products1> lst1 = new List<Products1>();

            lst1.Clear();

            MySession1.GioHang = lst1;

            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "SanPham");// trang nay co goi lai cai action kia k?action hien cau chao admin ak ko ko, phai goi lai, no moi kiem tra sesion dc ==
        }

    }
}
