using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBT2
{
    class Nguoi
    {
        protected string hoTen;
        protected string HoTen { get => hoTen; set => hoTen = value; }
        internal virtual void Nhap()
        {
            Console.Write("Ho Ten = ");
            this.hoTen = Console.ReadLine();
        }

        internal virtual void Xuat()
        {
            Console.WriteLine("Ho ten = {0}", this.hoTen);
        }
    }
}
