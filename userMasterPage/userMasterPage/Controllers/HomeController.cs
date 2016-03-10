using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace userMasterPage.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult nike()
        {
            return View("userMasterPage");
        }
        public ActionResult Subscription()
        {
            return View("Subscription");
        }
        public ActionResult Metrics()
        {
            return View("Metrics");
        }
        public ActionResult statusUserView()
        {
            return View("statusUserView");
        }
        public ActionResult historyUserView()
        {
            return View("historyUserView");
        }
    }
}
