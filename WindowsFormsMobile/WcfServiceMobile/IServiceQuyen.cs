using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceQuyen" in both code and config file together.
    [ServiceContract]
    public interface IServiceQuyen
    {
        [OperationContract]
        List<PhanQuyen> findAll();
    }
}
