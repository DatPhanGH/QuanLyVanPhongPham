//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyVanPhongPham.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            this.DonHangs = new HashSet<DonHang>();
        }
    
        public int MaND { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public string HoTen { get; set; }
        public string MaVaiTro { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
    
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual VaiTro VaiTro { get; set; }
    }
}
