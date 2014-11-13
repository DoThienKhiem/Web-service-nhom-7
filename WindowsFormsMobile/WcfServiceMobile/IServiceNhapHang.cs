using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceNhapHang" in both code and config file together.
    [ServiceContract]
    public interface IServiceNhapHang
    {
        [OperationContract]
        void DoWork();
    }
}
