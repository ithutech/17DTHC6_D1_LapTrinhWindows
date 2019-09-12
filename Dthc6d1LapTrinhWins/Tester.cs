using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dthc6d1LapTrinhWins
{
    class Tester
    {
        static void Main(string[] args)
        {
            //nhap tong so sinh vien
            Console.Write("So luong sinh vien = ");
            int soLuong = int.Parse(Console.ReadLine());
            List<SinhVien> danhSachSinhVien = new List<SinhVien>();
            SinhVien sinhVien;

            foreach (var item in danhSachSinhVien)
            {
                sinhVien = new SinhVien();
                sinhVien.Nhap();
                danhSachSinhVien.Add(sinhVien);
            }

            foreach (var item in danhSachSinhVien)
            {
                item.Xuat();
            }
            Console.ReadLine();
        }
    }
}
