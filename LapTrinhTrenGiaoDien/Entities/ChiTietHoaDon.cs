using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhTrenGiaoDien.Entities
{
    public class ChiTietHoaDon
    {
        public int ChiTietHoaDonID { get; set; }
        public int HoaDonID { get; set; }
        public int GheID { get; set; }

        public virtual HoaDon HoaDon { get; set; }
        public virtual Ghe Ghe { get; set; }
    }
}
