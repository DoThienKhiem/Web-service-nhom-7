using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMobile.Controllers;
using MVCMobile.ServiceReferenceSanPham;
using MVCMobile.ServiceReferenceDanhMuc;


namespace MVCMobile.Controllers
{
    public class SanPhamController : Controller
    {
        //
        // GET: /SanPham/
        
       private ServiceSanPhamClient svsp = new ServiceSanPhamClient();
       private ServiceDanhMucClient svdm = new ServiceDanhMucClient();
        //Hien thi san pham  trang chu
       int pagesize = 9;
       public ActionResult Index(int page = 1)
       {
           var sanpham = svsp.findAll().ToList();
           ViewBag.TotalPages = Math.Ceiling((double)sanpham.Count / pagesize);
           return View(sanpham.Skip((page - 1) * pagesize).Take(pagesize));
       }
       public ActionResult DanhMucSP()
       {
           var dmsp = svdm.findAll();
           return PartialView(dmsp);

       }
       public ActionResult ChiTietSP()
       {
           var a = Request.QueryString["MaSP"];
           int b = int.Parse(a);
           SanPham ctsp = svsp.ChiTietSP(b);

           return PartialView(ctsp);
       }

       public ActionResult DanhMucTheoLoai(int page = 1)
       {
           var a = Request.QueryString["loai"];
           int b = int.Parse(a);
           var sanpham = svsp.GetByDanhMuc(b).ToList();
           ViewBag.TotalPages = Math.Ceiling((double)sanpham.Count / 9);
            ViewBag.maloai = a;
            return View(sanpham.Skip((page - 1) * 9).Take(9));
       }
       string id = "";
       public ActionResult KQTimKiem(FormCollection f, int page = 1)
       {
           id = f["chuoitk"].ToString();
           var product = svsp.TimKiem(id).ToList();
           ViewBag.Tensp = id;
           ViewBag.KhongTimThay = "Không tìm thấy các sản phẩm thỏa điều kiện!";
           ViewBag.TotalPages = Math.Ceiling((double)product.Count / pagesize);
           return View(product.Skip((page - 1) * pagesize).Take(pagesize));

       }

    }
}
