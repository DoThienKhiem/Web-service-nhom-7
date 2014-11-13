using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceDanhMuc" in both code and config file together.
    [ServiceContract]
    public interface IServiceDanhMuc
    {
        [OperationContract]
        List<DanhMucSP> findAll();

        [OperationContract]
        bool insert(string madm, string tendm);

        [OperationContract]
        bool delete(string madm);

        [OperationContract]
        bool update(string madm, string tendm);
        
        [OperationContract]
        List<DanhMucSP> GetById(string madm);

        [OperationContract]
        List<DanhMucSP> GetByName(string tendm);

        
    }
}
