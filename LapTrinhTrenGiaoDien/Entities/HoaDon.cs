using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhTrenGiaoDien.Entities
{
    class HoaDon
    {
        public int HoaDonID { get; set; }
        public int KhachHangID { get; set; }
        public DateTime ThoiGianDatVe { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}
