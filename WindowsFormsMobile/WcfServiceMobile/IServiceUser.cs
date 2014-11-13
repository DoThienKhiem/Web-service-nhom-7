using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceUser" in both code and config file together.
    [ServiceContract]
    public interface IServiceUser
    {
        [OperationContract]
        List<NguoiDung> findAll();

        [OperationContract]
        bool AddUser(string username, string password, int quyen, string diachi, string hotennd, string NgaySinh, string email, string SoDienThoai);

        [OperationContract]
        bool Login(string username, string password);

        [OperationContract]
        bool EditUser(string username, string password, int quyen,string diachi, string hotennd, string NgaySinh, string email, string SoDienThoai);

        [OperationContract]
        bool XoaUser(string username);

        [OperationContract]
        List<NguoiDung> GetById(string username);

        [OperationContract]
        List<NguoiDung> GetByName(string hotennd);
    }
}
