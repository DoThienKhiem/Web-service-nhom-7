using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceDonHang" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceDonHang.svc or ServiceDonHang.svc.cs at the Solution Explorer and start debugging.
    public class ServiceDonHang : IServiceDonHang
    {
        DataClassesMobileDataContext db = new DataClassesMobileDataContext();

        public List<DonHang> GetAll()
        {
            return this.db.DonHangs.ToList();
        }

        public List<DonHang> GetByID(int madh)
        {
            var dsdh = db.DonHangs.Single(dh => dh.MaDH  == madh);
            var ds = new List<DonHang>();

            ds.Add(new DonHang
            {
                MaDH = dsdh.MaDH,
                IDUser = dsdh.IDUser,
                NgayDatHang = dsdh.NgayDatHang,
                TongTien = dsdh.TongTien,
                TrangThai = dsdh.TrangThai,
              
            });


            return ds;
        }

        public List<DonHang> GetByName(string iduser)
        {
            List<DonHang> dsdh = db.DonHangs.Where(dh => dh.IDUser == iduser).ToList();
            //var dsdh = db.DonHangs.Single(dh => dh.IDUser == iduser);
            //var ds = new List<DonHang>();

            //ds.Add(new DonHang
            //{
            //    MaDH = dsdh.MaDH,
            //    IDUser = dsdh.IDUser,
            //    NgayDatHang = dsdh.NgayDatHang,
            //    TongTien = dsdh.TongTien,

            //});


            return dsdh;
        }



        //public bool Delete(int madh)
        //{
        //    try
        //    {
        //        DonHang dh = db.DonHangs.Single(d => d.MaDH == madh);
        //        db.DonHangs.DeleteOnSubmit(dh);
        //        db.SubmitChanges();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}



        public bool Update(int madh)
        {
            try
            {
                DonHang dh = db.DonHangs.Single(d => d.MaDH == madh);
                dh.TrangThai = "2";
                db.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
