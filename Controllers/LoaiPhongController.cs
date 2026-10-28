using HotelBookingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelBookingWebsite.Controllers
{
    public class LoaiPhongController : Controller
    {
        QLDatPhongKhachSanEntities database = new QLDatPhongKhachSanEntities();
        // GET: LoaiPhong
        public ActionResult Index()
        {
            var loaiPhong = database.LoaiPhongs.ToList();
            return View(loaiPhong);
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lưu loại phòng vào database
        [HttpPost]
        public ActionResult Create(LoaiPhong loaiPhong)
        {
            database.LoaiPhongs.Add(loaiPhong);
            database.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}