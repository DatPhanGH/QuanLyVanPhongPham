﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_QLVPPEntities : DbContext
    {
        public DB_QLVPPEntities()
            : base("name=DB_QLVPPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public DbSet<DoanhThu> DoanhThus { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<KhuyenMai> KhuyenMais { get; set; }
        public DbSet<LichSuNhapHang> LichSuNhapHangs { get; set; }
        public DbSet<LoaiSP> LoaiSPs { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<ThanhToan> ThanhToans { get; set; }
        public DbSet<VaiTro> VaiTroes { get; set; }
        public DbSet<KhoHang> KhoHangs { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
    }
}
