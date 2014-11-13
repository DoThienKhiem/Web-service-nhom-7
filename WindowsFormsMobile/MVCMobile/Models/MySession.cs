using MVCMobile.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMobile.Models
{
    public class MySession
    {
        public static string MaSanPham
        {
            get { return "0"; }
        }
        public static string TongSL
        {
            get { return "1"; }
        }
        public static string Email
        {
            get { return "2"; }
        }
        public static string Quyen
        {
            get { return "3"; }
        }
        public static int? TongTien { get; set; }

        public static List<Products> GioHang { get; set; }

       // public static List<Products> GioHang { get; set; }

        public static List<ChiTietDonHang> ChiTietDonHang { get; set; }
       
       // public static List<ChiTietDonHang> ChiTietDonHang { get; set; }
      
      //  public static List<ChiTietSanPham> ChiTietSanPham { get; set; }
    }
}