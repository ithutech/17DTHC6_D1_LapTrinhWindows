using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhTrenGiaoDien.Entities
{
    public class Ghe
    {
        public int GheID { get; set; }
        public int HangGheID { get; set; }
        public int SoGhe { get; set; }

        public virtual HangGhe HangGhe { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
