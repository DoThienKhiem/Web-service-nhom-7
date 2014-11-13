using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceSanPham" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceSanPham.svc or ServiceSanPham.svc.cs at the Solution Explorer and start debugging.
    public class ServiceSanPham : IServiceSanPham
    {
        DataClassesMobileDataContext db = new DataClassesMobileDataContext();
        public List<SanPham> findAll()
        {
            return this.db.SanPhams.ToList();
        }


        public bool insert(string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm)
        {
            try
            {
                SanPham sp = new SanPham();
                
                sp.TenSP = tensp;
                sp.MoTa = mota;
                sp.Gia = gia;
                sp.SoLuong = soluong;
                sp.HinhAnh = hinhanh;
                sp.GhiChu = ghichu;
                sp.MaDM = madm;
                db.SanPhams.InsertOnSubmit(sp);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        


        public bool delete(int masp)
        {
            try
            {
                SanPham sp = db.SanPhams.Single(s => s.MaSP == masp);
                db.SanPhams.DeleteOnSubmit(sp);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }



        public bool Update(int masp, string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm)
        {

            try
            {
                SanPham sp = db.SanPhams.Single(s => s.MaSP == masp);
                sp.TenSP = tensp;
                sp.MoTa = mota;
                sp.Gia = gia;
                sp.SoLuong = soluong;
                sp.HinhAnh = hinhanh;
                sp.GhiChu = ghichu;
                sp.MaDM = madm;
                
                db.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        

        public List<SanPham> GetByIdsp(int masp)
        {
            var dssp = db.SanPhams.Single(s => s.MaSP == masp);
            var ds = new List<SanPham>();

            ds.Add(new SanPham
            {
                MaSP = dssp.MaSP,
                TenSP = dssp.TenSP,
                MoTa = dssp.MoTa,
                Gia = dssp.Gia,
                SoLuong = dssp.SoLuong,
                HinhAnh = dssp.HinhAnh,
                GhiChu = dssp.GhiChu,
                MaDM = dssp.MaDM,
            });


            return ds;
        }

        public List<SanPham> GetByNamesp(string tensp)
        {
            var dssp = db.SanPhams.Single(s => s.TenSP == tensp);
            var ds = new List<SanPham>();

            ds.Add(new SanPham
            {
                MaSP = dssp.MaSP,
                TenSP = dssp.TenSP,
                MoTa = dssp.MoTa,
                Gia = dssp.Gia,
                SoLuong = dssp.SoLuong,
                HinhAnh = dssp.HinhAnh,
                GhiChu = dssp.GhiChu,
                MaDM = dssp.MaDM,
            });


            return ds;
        }


        public List<SanPham> GetByDanhMucsp(string madm)
        {
            List<SanPham> dssp = db.SanPhams.Where(s => s.MaDM == madm).ToList();
            

            //var ds = new List<SanPham>();

            //ds.Add(new SanPham
            //{
            //    MaSP = dssp.MaSP,
            //    TenSP = dssp.TenSP,
            //    MoTa = dssp.MoTa,
            //    Gia = dssp.Gia,
            //    SoLuong = dssp.SoLuong,
            //    HinhAnh = dssp.HinhAnh,
            //    GhiChu = dssp.GhiChu,
            //    MaDM = dssp.MaDM,
            //});


            return dssp;
        }
    }
}