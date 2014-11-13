using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMobile.Controllers
{
    public class MenuController : Controller
    {
        //
        // GET: /Menu/

        public ActionResult LienHe()
        {
            return View();
        }
        public ActionResult GioiThieu()
        {
            return View();
        }
        public ActionResult KhuyenMai()
        {
            return View();
        }
        public ActionResult LinhKien()
        {
            return View();
        }
    }
}
