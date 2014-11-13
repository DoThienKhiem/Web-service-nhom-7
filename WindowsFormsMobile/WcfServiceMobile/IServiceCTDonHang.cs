using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceCTDonHang" in both code and config file together.
    [ServiceContract]
    public interface IServiceCTDonHang
    {
        [OperationContract]
        List<ChiTietDH> GetById(int id); 
    }
}
