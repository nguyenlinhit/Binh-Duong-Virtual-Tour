using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BinhDuongVirtualTour.Models;
namespace BinhDuongVirtualTour.Controllers
{
    public class VisitController : Controller
    {
       BinhDuongVirtualTourEntities db = new BinhDuongVirtualTourEntities();
        // GET: Visit
        public ActionResult _MenuPartial()
        {

            var da = db.VISIT_IMAGE.ToList();
            return PartialView("_MenuPartial", da);
        }
        public ActionResult Visit(int imgId)
        {

            var da = db.VISIT_IMAGE.SingleOrDefault(n => n.Img_Id == imgId);
                Session["idType"] = db.VISIT_IMAGE.SingleOrDefault(n => n.Img_Id == imgId).idType.ToString();
            Session["lat"] = db.VISIT_IMAGE.SingleOrDefault(n => n.Img_Id == imgId).lat.ToString();
            Session["lng"] = db.VISIT_IMAGE.SingleOrDefault(n => n.Img_Id == imgId).lng.ToString();
            return View(da);
        }
        public JsonResult LoadMap()
        {
            var da = db.VISIT_IMAGE.ToList();
            return Json(da, JsonRequestBehavior.AllowGet);
        }
        public ActionResult VR()
        {
            return View();
        }
    }
}