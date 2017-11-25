using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BinhDuongVirtualTour.Models;
namespace BinhDuongVirtualTour.Controllers
{
    public class HomeController : Controller
    {
        BinhDuongVirtualTourEntities db = new BinhDuongVirtualTourEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _VisitImagePartial()
        {
            var ha = db.VISIT_IMAGE.ToList();
            return PartialView("~/Views/Home/_VisitImagePartial.cshtml", ha);
        }
    }
}