using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyVanPhongPham.Models
{
    public class DB_SanPham
    {
        DB_QLVPPEntities db = new DB_QLVPPEntities();
        public DB_SanPham() { }
        public List<SanPham> getData()
        {
            List<SanPham> lst = new List<SanPham>();
            lst = db.SanPhams.ToList();
            return lst;
        }
    }
}