using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhTrenGiaoDien.Entities
{
    class KhachHang
    {
        public int KhachHangID { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
