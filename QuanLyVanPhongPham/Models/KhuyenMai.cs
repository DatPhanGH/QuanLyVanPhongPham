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
    
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            this.DonHangs = new HashSet<DonHang>();
        }
    
        public string MaKM { get; set; }
        public string TenKM { get; set; }
        public double PhanTramKM { get; set; }
        public System.DateTime NgBatDau { get; set; }
        public System.DateTime NgKetThuc { get; set; }
        public int SoLuongToiThieu { get; set; }
    
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
