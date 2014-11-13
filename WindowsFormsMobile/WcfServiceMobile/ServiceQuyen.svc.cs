using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceQuyen" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceQuyen.svc or ServiceQuyen.svc.cs at the Solution Explorer and start debugging.
    public class ServiceQuyen : IServiceQuyen
    {
        DataClassesMobileDataContext db = new DataClassesMobileDataContext();
        public List<PhanQuyen> findAll()
        {
            return this.db.PhanQuyens.ToList();
        }

    }
}
