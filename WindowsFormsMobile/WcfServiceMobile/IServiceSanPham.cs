using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceSanPham" in both code and config file together.
    [ServiceContract]
    public interface IServiceSanPham
    {
        [OperationContract]
        List<SanPham> findAll();


        [OperationContract]
        bool insert(string tensp,string mota, int gia , int soluong, string hinhanh, string ghichu ,string madm);

        [OperationContract]
        bool delete(int masp);


        [OperationContract]
        bool Update(int masp, string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm);

        [OperationContract]
        List<SanPham> GetByIdsp(int masp);

        [OperationContract]
        List<SanPham> GetByNamesp(string tensp);

        [OperationContract]
        List<SanPham> GetByDanhMucsp(string madm );


    }
}
