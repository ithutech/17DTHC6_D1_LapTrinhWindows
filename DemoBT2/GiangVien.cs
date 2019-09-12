using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBT2
{
    class GiangVien : Nguoi
    {
        private int ma;
        private string diaChi;

        public int Ma { get => ma; set => ma = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        internal override void Nhap()
        {

            //Nhap thong tin sinh vien
            Console.Write("Ma = ");
            this.ma = int.Parse(Console.ReadLine());
            base.Nhap();
            Console.Write("Dia chi = ");
            this.diaChi = Console.ReadLine();
        }

        internal override void Xuat()
        {
            Console.WriteLine("Ma = {0}", this.ma);
            base.Xuat();
            Console.WriteLine("Dia chi = {0}", this.diaChi);
        }
    }
}
