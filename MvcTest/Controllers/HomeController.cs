using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRouting;

namespace MvcTest.Controllers
{
    [RoutePrefix("App/{pageid}/Home")]
    public partial class HomeController : BaseController
    {
        //
        // GET: /Home/

        public virtual ActionResult Index()
        {
            return View();
        }

    }
}
