using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyVanPhongPham.Models;

namespace QuanLyVanPhongPham.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult Index()
        {
            return View();
        }
        DB_QLVPPEntities dbcontext = new DB_QLVPPEntities();
        List<SanPham> lst_sp = new List<SanPham>();
        DB_SanPham db_sanpham = new DB_SanPham();
        // GET: SanPham
        //Hien thi danh sach san pham
         public ActionResult ShowSanPham()
        {
            lst_sp = db_sanpham.getData();
            return View(lst_sp);
        }
        //Chi tiet 1 san pham
        [HttpPost]
        public ActionResult ChiTietSanPham(string MaSP)
        { 
            if(MaSP.Length != 0)
            {
                SanPham tmp = dbcontext.SanPhams.FirstOrDefault(t => t.MaSP == MaSP);
                if (tmp == null) { return  RedirectToAction("ShowSanPham"); }
                else { return View(tmp); }
                
            }
            return View();
        }
    }
}