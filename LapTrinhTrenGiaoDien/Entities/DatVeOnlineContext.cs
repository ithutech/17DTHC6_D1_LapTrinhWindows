using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LapTrinhTrenGiaoDien.Entities
{
    class DatVeOnlineContext : DbContext
    {
        public DatVeOnlineContext() : base("DatVeOnlineConnection")
        {

        }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HangGhe> HangGhes { get; set; }
        public DbSet<Ghe> Ghes { get; set; }
    }
}
