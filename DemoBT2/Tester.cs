using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBT2
{
    class Tester
    {
        static void Main(string[] args)
        {
            //nhap tong so sinh vien
            //Console.Write("So Luong Nguoi = ");
            //int soLuong = int.Parse(Console.ReadLine());
            List<Nguoi> danhSach = new List<Nguoi>();
            Nguoi nguoi;
            int chon;
            do
            {
                Console.WriteLine("1: Nhap Sinh Vien\n2: Nhap Giang Vien\n3: Xuat Thong tin \n0: Thoat");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        break;
                    case 1:
                        nguoi = new SinhVien();
                        nguoi.Nhap();
                        danhSach.Add(nguoi);

                        break;
                    case 2:
                        nguoi = new GiangVien();
                        nguoi.Nhap();
                        danhSach.Add(nguoi);
                        break;
                    case 3:
                        Console.WriteLine("Danh sach");
                        foreach (var item in danhSach)
                        {
                            item.Xuat();
                        }
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (chon != 0) ;
        }
    }
}
