using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;
using System.Text;

namespace WcfServiceMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceUser" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceUser.svc or ServiceUser.svc.cs at the Solution Explorer and start debugging.
    public class ServiceUser : IServiceUser
    {
        DataClassesMobileDataContext db = new DataClassesMobileDataContext();
        public bool Login(string username, string password)
        {
            try
            {
                bool usercheck = db.NguoiDungs.Any(user => user.IDUser == username && user.Pass == password);
                return true;
            }
            catch
            {
                return false;
            }
        }

       

        public bool XoaUser(string username)
        {
            try
            {
                
                //NguoiDung us = db.NguoiDungs.SingleOrDefault(p => p.IDUser.Contains(username));
                var us = from a in db.NguoiDungs
                              where a.IDUser.Contains(username)
                              select a;
                db.NguoiDungs.DeleteAllOnSubmit(us);
                db.SubmitChanges();
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<NguoiDung> findAll()
        {
            return this.db.NguoiDungs.ToList();
        }


       


        public bool AddUser(string username, string password, int quyen, string diachi, string hotennd, string NgaySinh, string email, string SoDienThoai)
        {
            try
            {
                NguoiDung usr = new NguoiDung();
                usr.IDUser = username;
                usr.Pass = password;
                usr.HoTen = hotennd;
                usr.Email = email;
                usr.DiaChi = diachi;
                usr.SDT = SoDienThoai;
                usr.NgaySinh = NgaySinh;
                usr.Quyen = quyen;
                db.NguoiDungs.InsertOnSubmit(usr);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditUser(string username, string password, int quyen, string diachi, string hotennd, string NgaySinh, string email, string SoDienThoai)
        {
            try
            {

                NguoiDung us = db.NguoiDungs.Single(u => u.IDUser == username);
                us.HoTen = hotennd;
                us.IDUser = username;
                us.Pass = password;
                us.Email = email;
                us.DiaChi = diachi;
                us.SDT = SoDienThoai;
                us.NgaySinh = NgaySinh;
                us.Quyen = quyen;
                db.SubmitChanges();
                
                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<NguoiDung> GetById(string username)
        {
            var dsnd = db.NguoiDungs.Single(m => m.IDUser == username);
            var ds = new List<NguoiDung>();

            ds.Add(new NguoiDung
            {
                IDUser = dsnd.IDUser,
                Pass = dsnd.Pass,
                HoTen = dsnd.HoTen,
                DiaChi = dsnd.DiaChi,
                SDT = dsnd.SDT,
                NgaySinh = dsnd.NgaySinh,
                Email = dsnd.Email,
                Quyen = dsnd.Quyen,
            });


            return ds;
        }

        public List<NguoiDung> GetByName(string hotennd)
        {
            var dsnd = db.NguoiDungs.Single(m => m.HoTen == hotennd);
            var ds = new List<NguoiDung>();

            ds.Add(new NguoiDung
            {
                IDUser = dsnd.IDUser,
                Pass = dsnd.Pass,
                HoTen = dsnd.HoTen,
                DiaChi = dsnd.DiaChi,
                SDT = dsnd.SDT,
                NgaySinh = dsnd.NgaySinh,
                Email = dsnd.Email,
                Quyen = dsnd.Quyen,
            });


            return ds;
        }
    }
}
