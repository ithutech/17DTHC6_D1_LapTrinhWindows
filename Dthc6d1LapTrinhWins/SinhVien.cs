using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dthc6d1LapTrinhWins
{
    class SinhVien
    {
        private int ma;
        private float diem;
        private string khoa;

        public int Ma { get => ma; set => ma = value; }
        public float Diem { get => diem; set => diem = value; }
        public string Khoa { get => khoa; set => khoa = value; }

        public SinhVien()
        {
            
        }

        public SinhVien(int ma, string khoa, float diem)
        {
            this.ma = ma;
            this.khoa = khoa;
            this.diem = diem;
        }

        internal void Nhap()
        {
            //Nhap thong tin sinh vien
            Console.Write("Ma = ");
            this.ma = int.Parse(Console.ReadLine());
            Console.Write("Khoa = ");
            this.khoa = Console.ReadLine();
            Console.Write("Diem = ");
            this.diem = float.Parse(Console.ReadLine());
        }

        internal void Xuat()
        {
            Console.WriteLine("Ma = {0}", this.ma);
            Console.WriteLine("Khoa = {0}", this.khoa);
            Console.WriteLine("Diem = {0}", this.diem);
        }
    }
}
