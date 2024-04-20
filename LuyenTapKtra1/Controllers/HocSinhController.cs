using LuyenTapKtra1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuyenTapKtra1.Controllers
{
    public class HocSinhController : Controller
    {
        public List<HocSinh> _hocSinh;
        public HocSinhController() {
            _hocSinh = new List<HocSinh>()
            {
                new HocSinh("001", "Dinh Duy", "L001", 7, 8),
                new HocSinh("002", "Dinh gg", "L002", 1, 2),
                new HocSinh("003", "Dinh dd", "L001", 5, 8),
                new HocSinh("004", "Dinh cc", "L003", 10, 9),
            };
        }
        // GET: HocSinh
        public ActionResult Index()
        {
            var List1 = _hocSinh.Where(x => x.diemTk < 13).ToList();
            var List2 = _hocSinh.Where(x => x.Lop == "L001").ToList();
            ViewBag.List1 = List1;
            ViewBag.List2 = List2;
            return View();
        }
        [HttpGet]
        public ActionResult Add() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(HocSinh hocSinh)
        {
            return RedirectToAction("HienThiAdd", hocSinh);

        }
        public ActionResult HienThiAdd(HocSinh hocSinh)
        {
            return View(hocSinh);

        }
    }
}