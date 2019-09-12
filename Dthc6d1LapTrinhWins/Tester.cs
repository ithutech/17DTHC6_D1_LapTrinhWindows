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

            for (int i = 0; i < soLuong; i++)
            {
                sinhVien = new SinhVien();
                sinhVien.Nhap();
                danhSachSinhVien.Add(sinhVien);
            }

            Console.WriteLine("Danh sach sinh vien");
            foreach (var item in danhSachSinhVien)
            {
                item.Xuat();
            }
            //Xuất ra danh sách các sinh viên theo thứ tự có điểm trung bình tăng dần.
            danhSachSinhVien.Sort();
            Console.WriteLine("Danh sach sinh vien co diem tang dan");
            foreach (var item in danhSachSinhVien)
            {
                item.Xuat();
            }
            //Lay diem sinh vien cao nhat
            float diemCaoNhat = danhSachSinhVien.Max(p => p.Diem);
            List<SinhVien> danhSachSinhVienDiemCaoNhat = danhSachSinhVien.Where(p => p.Diem == diemCaoNhat).ToList();
            //Xuat danh sach
            foreach (var item in danhSachSinhVienDiemCaoNhat)
            {
                item.Xuat();
            }
            Console.ReadLine();
        }
    }
}
