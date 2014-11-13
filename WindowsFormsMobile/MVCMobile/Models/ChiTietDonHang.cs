using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMobile.Models
{
    public class ChiTietDonHang
    {
        public int? MaSP { get; set; }
        public int? ID { get; set; }
        public int? MaDonHang { get; set; }
        public int? SoLuong { get; set; }
        public string TenSP { get; set; }
        public int? Gia { get; set; }
        public int? ThanhTien { get; set; }
    }
}