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
    
    public partial class DonHang
    {
        public DonHang()
        {
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            this.ThanhToans = new HashSet<ThanhToan>();
        }
    
        public string MaDH { get; set; }
        public int MaND { get; set; }
        public System.DateTime NgayDatHang { get; set; }
        public double TongTien { get; set; }
        public string MaKM { get; set; }
        public Nullable<double> GiamGia { get; set; }
        public double PhaiTra { get; set; }
    
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; }
        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
    }
}
