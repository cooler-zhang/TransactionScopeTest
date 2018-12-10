using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace TransactionScopeTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var aaaRepository = IoCManager.Container.Resolve<AAARepository>();
            aaaRepository.Insert();
            //using (var ctx = new TestDbContext())
            //{
            //    var aaas = ctx.AAA.ToArray();
            //}
            return View();
        }
    }
}
