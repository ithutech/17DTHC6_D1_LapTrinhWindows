using LapTrinhTrenGiaoDien.Entities;
using LapTrinhTrenGiaoDien.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhTrenGiaoDien
{
    public delegate void luuThongTinKhachHang(object sender, EventLuuThongTinKhachHang e);

    public partial class frmKHachHang : Form
    {
        DatVeOnlineContext dbContext;

        public event luuThongTinKhachHang luuThongTinKhachHang;

        public frmKHachHang()
        {
            InitializeComponent();
            dbContext = new DatVeOnlineContext();
        }

        private void BtnChon_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.TenKhachHang = txtKhachHang.Text;
            khachHang.DiaChi = txtDiaChi.Text;
            dbContext.KhachHangs.Add(khachHang);
            dbContext.SaveChanges();
            //Khai bao su kien
            EventLuuThongTinKhachHang arg = new EventLuuThongTinKhachHang();
            luuThongTinKhachHang(this, arg);
            this.Close();

        }

    }
}
