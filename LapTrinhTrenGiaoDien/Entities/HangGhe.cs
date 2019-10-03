using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhTrenGiaoDien.Entities
{
    class HangGhe
    {
        public int HangGheID { get; set; }
        public string TenHangGhe { get; set; }
        public float GiaVe { get; set; }

        public virtual ICollection<Ghe> Ghes { get; set; }
    }
}
