
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using WebBanDT.Models;
//using System.Text.RegularExpressions;
//using System.Net.Mail;
//using System.Net;
//namespace WebBanDT.Controllers
//{
//    public class GioHangController : Controller
//    {
//        //
//        // GET: /GioHang/
//        MobileEntities3 db = new MobileEntities3();
//        public ActionResult Index()
//        {

//            try
//            {
//                int num = WebBanDT.Models.MySession.GioHang.Count;
//                if (num > 0)
//                {
//                    return View();
//                }
//                else
//                {
//                    return RedirectToAction("Index", "SanPham");
//                }
//            }
//            catch
//            {
//                return RedirectToAction("Index", "SanPham");
//            }


//        }
//        public ActionResult MenuGiohang()
//        {
//            return View();
//        }
//        // lịch sử giỏ hàng
//        int pagesize = 10;
//        public ActionResult LichSuGioHang(int page = 1)
//        {
//            string iduser = this.HttpContext.User.Identity.Name.ToString();
//            //DonHang hoadon = db.DonHangs.SingleOrDefault(p => p.IDUser == iduser);
//            var hoadon = (from p in db.DonHangs where p.IDUser.StartsWith(iduser)  orderby p.MaDH descending  select p).ToList();
//            ViewBag.TotalPages = Math.Ceiling((double)hoadon.Count / pagesize);
//            return View(hoadon);
//        }

//        public ActionResult ChiTietDonHang()
//        {
//          //  int mahoadon = int.Parse(Request.QueryString["mahoadon"].ToString());
//            string a = Request.QueryString["madonhang"].ToString();
//            int mahoadon = Convert.ToInt32(a);
//            var cthd = (from p in db.ChiTietDHs
//                           join q in db.SanPhams on p.MaSP equals q.MaSP
//                           //   var sanpham =    (from p in db.SanPhams q in db.DanhMucSPs
//                        where p.MaDH == mahoadon
//                           select new ChiTietDonHang
//                           {
//                               MaSP = p.MaSP,
//                               ID = p.ID,
//                               MaDonHang=p.MaDH,
//                               SoLuong = p.SoLuong,
//                               TenSP = q.TenSP,
//                               Gia = q.Gia,
//                               ThanhTien = p.TongTien,

//                           }).ToList();

//            try
//            {
             
//                List<ChiTietDonHang> lstd = new List<ChiTietDonHang>();            
//                {
                    
//                    lstd.Clear();
//                }

//                    MySession.ChiTietDonHang = lstd;
//                    foreach (var s in cthd)
//                    {
//                        MySession.ChiTietDonHang.Add(s);
//                    }
//              //  }

//            }
//            catch
//            {
//                MySession.ChiTietDonHang = cthd;

//            }
            
//            return View(MySession.ChiTietDonHang);

//        }
//        public ActionResult AddToCart()
//        {
//            //Lưu các mã sản phẩm
//            var id = int.Parse(Request.QueryString["masanpham"].ToString());
//            string ma = Session[WebBanDT.Models.MySession.MaSanPham] + id.ToString();
//            Session[WebBanDT.Models.MySession.MaSanPham] = ma;

//            //Số lượng sản phẩm có trong giỏ hàng
//            int sl = 1 + Convert.ToInt32(Session[WebBanDT.Models.MySession.TongSL]);
//            Session[WebBanDT.Models.MySession.TongSL] = sl.ToString();

//            var query = (from p in db.SanPhams
//                         where p.MaSP == id
//                         select new Products
//                         {
//                             MaSanPham = p.MaSP,
//                             TenSanPham = p.TenSP,
//                             Gia = p.Gia,
//                             TongTien = p.Gia + 0,
//                             SoLuong = 1,
//                         }).ToList();

//            try
//            {
//                bool flag = false;
//                for (int i = 0; i < MySession.GioHang.Count; i++)
//                {
//                    if (MySession.GioHang[i].MaSanPham == query[0].MaSanPham)
//                    {
//                        MySession.GioHang[i].SoLuong = MySession.GioHang[i].SoLuong + 1;
//                        flag = true;
//                    }
//                }
//                if (flag == false)
//                {
//                    foreach (var s in query)
//                    {
//                        MySession.GioHang.Add(s);
//                    }
//                }
//                MySession.TongTien = MySession.TongTien + query[0].TongTien;
//            }
//            catch
//            {
//                MySession.GioHang = query;
//                MySession.TongTien = query[0].TongTien;
//            }

//            return RedirectToAction("Index", "GioHang");
//        }

//        //Cập nhật số lượng sản phẩm trong giỏ
//        [HttpPost]
//        public ActionResult UpdateCart(FormCollection formCollection)
//        {
//            int sl = int.Parse(formCollection["USoLuong"]);
//            int masp = int.Parse(formCollection["UMaSanPham"]);
//            Session[WebBanDT.Models.MySession.TongSL] = "0";
//            SanPham sol = db.SanPhams.First(p => p.MaSP == masp);
//            int Sol = int.Parse(sol.SoLuong.ToString());
//            MySession.TongTien = 0;
//            for (int i = 0; i < MySession.GioHang.Count; i++)
//            {
//                if (MySession.GioHang[i].MaSanPham == masp)
//                {
//                    if (sl < 1)
//                    {
//                        MySession.GioHang[i].SoLuong = 1;
//                        Session[WebBanDT.Models.MySession.TongSL] = ((Convert.ToInt32(Session[WebBanDT.Models.MySession.TongSL]) + 1)).ToString();
//                        MySession.GioHang[i].TongTien = MySession.GioHang[i].Gia;
//                    }
//                    else
//                        if (sl < Sol)
//                        {
//                            MySession.GioHang[i].SoLuong = sl;
//                            Session[WebBanDT.Models.MySession.TongSL] = ((Convert.ToInt32(Session[WebBanDT.Models.MySession.TongSL]) + sl)).ToString();
//                            MySession.GioHang[i].TongTien = MySession.GioHang[i].Gia * sl;
//                        }
//                        else
//                        {


//                            return RedirectToAction("Index");

//                        }
//                }
//                else
//                {
//                    Session[WebBanDT.Models.MySession.TongSL] = ((Convert.ToInt32(Session[WebBanDT.Models.MySession.TongSL]) + MySession.GioHang[i].SoLuong)).ToString();

//                }
//                MySession.TongTien = MySession.TongTien + MySession.GioHang[i].TongTien;
//            }
//            return RedirectToAction("Index");
//        }

//        //Xóa sản phẩm trong giỏ
//        public ActionResult DeleteCart(int id)
//        {
//            Session[WebBanDT.Models.MySession.TongSL] = "0";
//            List<Products> lst = new List<Products>();
//            int i = 0;
//            MySession.TongTien = 0;
//            foreach (var s in MySession.GioHang)
//            {
//                if (MySession.GioHang[i].MaSanPham != id)
//                {
//                    lst.Add(s);
//                    MySession.TongTien = MySession.TongTien + (MySession.GioHang[i].Gia * MySession.GioHang[i].SoLuong);
//                    Session[WebBanDT.Models.MySession.TongSL] = (Convert.ToInt32(Session[WebBanDT.Models.MySession.TongSL]) + MySession.GioHang[i].SoLuong).ToString();
//                }
//                i++;
//            }
//            MySession.GioHang = lst;
//            if (MySession.GioHang.Count == 0)
//            {
//                return RedirectToAction("Index");
//            }
//            else
//            {
//                return RedirectToAction("Index");
//            }
//        }

//        // chap nhan thanh toan
//        string tongtien = "";
//        public ActionResult Payment(FormCollection f)
//        {


//            DonHang hd = new DonHang();
//            //var user = (from l in db.nguoidungs where l.tendn==this.HttpContext.User.Identity.Name select l).ToList();
//            //string tp = "";
//            //foreach (var item in user)
//            //    tp = item.city;
//            //ViewBag.diachi = tp;
//            hd.IDUser = this.HttpContext.User.Identity.Name;
//            hd.NgayDatHang = DateTime.Now;
//            // hd.TriGiaDH = f["diadiem"];
//            // hd.hinhthucthanhtoan = f["hinhthucthanhtoan"];
//            //  hd.ghichu = f["customer_note"];
//            hd.TongTien = int.Parse(Request.QueryString["tongtien"]);
//            tongtien = hd.TongTien.ToString();
//            //hd.MaTrangThai = "0";
//            db.DonHangs.Add(hd);
//            db.SaveChanges();
//            List<Products> lst = new List<Products>();
//            int j = 0;
//            foreach (var s in MySession.GioHang)
//            {
//                ChiTietDH cthd = new ChiTietDH();
//                //SanPham sp = new SanPham();
//                cthd.MaSP = MySession.GioHang[j].MaSanPham;

//                cthd.MaDH = hd.MaDH;
//                cthd.SoLuong = MySession.GioHang[j].SoLuong;
//                cthd.Gia = MySession.GioHang[j].Gia;
//                cthd.TongTien = MySession.GioHang[j].Gia * MySession.GioHang[j].SoLuong;


//                int sps = int.Parse(MySession.GioHang[j].MaSanPham.ToString());
//                SanPham sp = db.SanPhams.First(p => p.MaSP == sps);
//                int c = int.Parse(MySession.GioHang[j].SoLuong.ToString());
//                int b = 0;
//                b = int.Parse(sp.SoLuong.ToString()) - c;
//                sp.SoLuong = b;
//                /* db.SanPhams.Add(sp);
//                 db.SaveChanges();*/
//                UpdateModel(sp);
//                db.ChiTietDHs.Add(cthd);
//                db.SaveChanges();
//                j++;

//            }

//            /*   foreach (var item in cart.Cart.Lines)
//               {
//                   CTDonHang cthd = new CTDonHang();
//                   cthd.MaDonHang = hd.mahoadon;
//                   cthd.MaSP = item.masp;
//                   cthd.SoLuong = item.Quantity;
//                   cthd.ThanhTien = item.giasanpham * item.Quantity;
//                   db.chitiethoadons.AddObject(cthd);
//                   db.SaveChanges();

//               }*/

//            // return RedirectToAction("Index");
//            return RedirectToAction("SendMailCart");

//        }
//        public ActionResult SendMailCart()
//        {

//            string name = HttpContext.User.Identity.Name;
//            NguoiDung usr = db.NguoiDungs.SingleOrDefault(p => p.IDUser == name);
//            string Email = usr.Email.Trim();
//            string hoten = usr.HoTen.Trim();
//            string chuoi = "";


//            chuoi += "Đơn đặt hàng của " + hoten + " tại WebBanDT " + "\n";
//            int tongtien1 = 0;
//            foreach (var item in MySession.GioHang)
//            {
//                chuoi += "Mã SP: " + item.MaSanPham + "\tTên SP: " + item.TenSanPham + "\t Giá SP: " + item.Gia + "\t" + "\t Số Lượng SP: " + item.SoLuong + "\t" + "\t Thành tiền: " + item.TongTien + "\n";
//                tongtien1 += int.Parse(item.TongTien.ToString());
//            }
//            chuoi += "Tổng tiền:" + tongtien1 + "\n";
//            chuoi += "Đơn đặt hàng của " + hoten + " tại WebBanDT  đã được xác nhận" + "\n";
//            chuoi += "Chúng tôi sẽ giao hàng trong vòng 2-3 ngày" + "\n";
//            chuoi += "Trước khi giao hàng sẽ có nhân viên gọi điện trước 30p";
//            MailMessage msg = new MailMessage();
//            msg.From = new MailAddress("sguklshop@gmail.com");
//            msg.To.Add(Email);
//            msg.Subject = "GIỎ HÀNG CỦA QUÝ KHÁCH TẠI WebBanDT";
//            msg.Body = chuoi;

//            SmtpClient smtp = new SmtpClient();
//            smtp.Credentials = new NetworkCredential("sguklshop@gmail.com", "sguklshop123");
//            smtp.Port = 587;
//            smtp.Host = "smtp.gmail.com";
//            smtp.EnableSsl = true;

//            // smtp.UseDefaultCredentials = true;
//            smtp.Send(msg);
//            Session[WebBanDT.Models.MySession.TongSL] = "0";

//            WebBanDT.Models.MySession.TongTien = 0;
//            List<Products> lstd = new List<Products>();

//            {

//                lstd.Clear();
//            }

//            MySession.GioHang = lstd;
//            return RedirectToAction("Index", "SanPham");
//        }
       
//    }
//}



