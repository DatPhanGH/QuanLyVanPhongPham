using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyVanPhongPham.Models;

namespace QuanLyVanPhongPham.Controllers
{
    public class DNController : Controller
    {
        // GET: DN
        public ActionResult Index()
        {
            return View();
        }

        DB_NguoiDung db_nguoidung = new DB_NguoiDung();
        // action DangNhap
        public ActionResult DangNhap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangNhap(NguoiDung pngdung)
        {
            //kiểm tra dữ liệu đầu vào phải nhập đủ
            if (ModelState.IsValid)
            {
                bool kq = db_nguoidung.dangNhap(pngdung);

                if (kq)
                {
                    // Lưu thông tin đăng nhập vào session
                    Session["tentk"] = pngdung.TenTaiKhoan;

                    // Trả về View với thông báo thành công
                    ViewBag.LoginSuccess = true;

                    return View();
                }
                else
                {
                    ModelState.AddModelError("","Tên tài khoản hoặc mật khẩu không đúng");
                }
            }

            return View(pngdung);
        }


        //action DangKy
        public ActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangKy(NguoiDung pnd,string xacnhaMK)
        {
            //kiểm tra dữ liệu đầu vào
            if (ModelState.IsValid) 
            {
                if (pnd.MatKhau != xacnhaMK) 
                {
                    ModelState.AddModelError("", "Mật khẩu và xác nhận mật khẩu không khớp.");
                }
                else
                {
                    if (db_nguoidung.dangKy(pnd))
                    {
                        ViewBag.SignUpSuccess = true;
                        return View();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Tên tài khoản đã tồn tại");
                    }
                }
                return View(pnd);
            }

            return View();
        }
    }
}