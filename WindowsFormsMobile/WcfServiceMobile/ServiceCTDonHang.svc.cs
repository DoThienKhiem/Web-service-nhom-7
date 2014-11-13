using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceCTDonHang" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceCTDonHang.svc or ServiceCTDonHang.svc.cs at the Solution Explorer and start debugging.
    public class ServiceCTDonHang : IServiceCTDonHang
    {
        DataClassesMobileDataContext db = new DataClassesMobileDataContext();

        public List<ChiTietDH> GetById(int id)
        {
            var query = (from p in db.ChiTietDHs
                        join q in db.SanPhams on p.MaSP equals q.MaSP
                        join k in db.DonHangs on p.MaDH equals k.MaDH
                        where p.ID == id

                        select new ChiTietDH
                        {
                            MaSP = p.MaSP,
                            ID = p.ID,
                            MaDH= p.MaDH,
                            SoLuong = p.SoLuong,
                         
                            Gia = p.Gia,
                            TongTien = p.TongTien,
                        }).ToList();

            return query;
        }
    }
}
