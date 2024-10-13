using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace QuanLyVanPhongPham.Models
{
    public class DB_NguoiDung
    {
        public DB_NguoiDung() { }

        DB_QLVPPEntities dbcontext = new DB_QLVPPEntities();

        //phương thức kiểm tra tài khoản người dùng
        public bool ktTaiKhoanND(string ptentk, string pmatkhau)
        {
            var user = dbcontext.NguoiDungs.FirstOrDefault(m => m.TenTaiKhoan == ptentk && m.MatKhau == pmatkhau);
            if (user == null)
            {
                return false; //không có tài khoản người dùng này
            }
            else
            {
                return true; // có tài khoản của người dùng này
            }
        }

        //phương thức kiểm tra tên tài khoản có trùng với tên tài khoản nào đã tồn tại chưa
        public bool ktTenTaiKhoan(string ptentk)
        {
            var user = dbcontext.NguoiDungs.FirstOrDefault(m => m.TenTaiKhoan == ptentk);
            if (user == null)
            {
                return false; //không có tên tài khoản người dùng này
            }
            else
            {
                return true; // có tên tài khoản của người dùng này
            }

        }

        //phương thức đăng nhập
        public bool dangNhap(NguoiDung pngdung)
        {
            if (ktTaiKhoanND(pngdung.TenTaiKhoan, pngdung.MatKhau))
            {
                return true; //đăng nhập thành công
            }
            else
            {
                return false; //đăng nhập thất bại
            }
        }

        //phương thức đăng ký
        public bool dangKy(NguoiDung pngdung)
        {
            if (ktTenTaiKhoan(pngdung.TenTaiKhoan))
            {
                return false;//đăng ký không thành công do tồn tại tài khoản người dùng này
            }
            else
            {
                //thêm người dùng này vào database
                //gán giá trị mặc định cho cột MaVaiTro là VT003 (mặc định đăng ký luôn là khách hàng)
                pngdung.MaVaiTro = "VT003";
                dbcontext.NguoiDungs.Add(pngdung);
                dbcontext.SaveChanges();

                return true ;//đăng ký thành công
            }
        }
    }
}