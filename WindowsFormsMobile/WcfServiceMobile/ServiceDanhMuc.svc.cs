using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceDanhMuc" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceDanhMuc.svc or ServiceDanhMuc.svc.cs at the Solution Explorer and start debugging.
    public class ServiceDanhMuc : IServiceDanhMuc
    {

        DataClassesMobileDataContext db = new DataClassesMobileDataContext();
        public List<DanhMucSP> findAll()
        {
            return this.db.DanhMucSPs.ToList();
        }


        public bool insert(string madm, string tendm)
        {
            try
            {
                DanhMucSP dm = new DanhMucSP();
                dm.MaDM = madm;
                dm.TenDM = tendm;
                db.DanhMucSPs.InsertOnSubmit(dm);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete(string madm)
        {
            try
            {
                DanhMucSP dm = db.DanhMucSPs.Single(d => d.MaDM == madm);
                db.DanhMucSPs.DeleteOnSubmit(dm);
                db.SubmitChanges();
                return true;


            }
            catch
            {
                return false;
            }
        }

        public bool update(string madm, string tendm)
        {
            try
            {
                DanhMucSP dm = db.DanhMucSPs.Single(d => d.MaDM == madm);
                dm.TenDM = tendm;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<DanhMucSP> GetById(string madm)
        {
            var dsdm = db.DanhMucSPs.Single(m => m.MaDM == madm);
            var ds = new List<DanhMucSP>();

            ds.Add(new DanhMucSP
            {
                MaDM = dsdm.MaDM,
                TenDM = dsdm.TenDM,
               
            });


            return ds;
        }

        public List<DanhMucSP> GetByName(string tendm)

        {
            var dsdm = db.DanhMucSPs.Single(m => m.TenDM == tendm);
            var ds = new List<DanhMucSP>();

            ds.Add(new DanhMucSP
            {
                MaDM = dsdm.MaDM,
                TenDM = dsdm.TenDM,

            });


            return ds;
        }
    }
}

