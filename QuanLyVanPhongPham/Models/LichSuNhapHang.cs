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
    
    public partial class LichSuNhapHang
    {
        public string MaNH { get; set; }
        public string MaNCC { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
        public System.DateTime NgNhapHang { get; set; }
    
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
