﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LapTrinhTrenGiaoDien.Entities;

namespace LapTrinhTrenGiaoDien
{
    public partial class frmMuaVeXemPhimOnline : Form
    {
        DatVeOnlineContext dbContext;
        List<Button> dsChon;
        List<KhachHang> dsKhachHang;
        public frmMuaVeXemPhimOnline()
        {
            InitializeComponent();

            dsChon = new List<Button>();
            lblThoiGianDatVe.Text = DateTime.Now.ToShortTimeString();
            dbContext = new DatVeOnlineContext();
            CaiDatManHinh();
        }


        private void btnChonVe_Click(object sender, EventArgs e)
        {
            //Chuyen sender thanh button
            Button btnChonVe = (Button)sender;
            //Neu nut dang chon la mau trang thi --> mau xanh
            //va nguoc lai
            if (btnChonVe.BackColor == Color.White)
            {
                btnChonVe.BackColor = Color.Blue;
                dsChon.Add(btnChonVe);
            }
            else if (btnChonVe.BackColor == Color.Blue)
            {
                btnChonVe.BackColor = Color.White;
                dsChon.Remove(btnChonVe);
            }
            else
            {
                MessageBox.Show("Thong bao", "Ve nay da duoc mua!");
            }
            //truy van tinh tien
            double thanhTien = TinhTien();
            this.txtTien.Text = thanhTien.ToString();

        }

        private double TinhTien()
        {
            double tongTien = 0;
            int soGhe;
            foreach (var ghe in dsChon)
            {
                soGhe = int.Parse(ghe.Text);
                tongTien += dbContext.Ghes.Include("HangGhe").Where(x => x.SoGhe == soGhe).FirstOrDefault().HangGhe.GiaVe;
            }
            return tongTien;
        }

        private void BtnChon_Click(object sender, EventArgs e)
        {
            //B1. Them Khach hang
            KhachHang khachHang = new KhachHang();
            khachHang.TenKhachHang = cbxKhachHang.Text;
            dbContext.KhachHangs.Add(khachHang);
            dbContext.SaveChanges();
            //B2. Luu Hoa Don
            HoaDon hoaDon = new HoaDon();
            hoaDon.KhachHangID = khachHang.KhachHangID;
            hoaDon.ThoiGianDatVe = DateTime.Now;
            dbContext.HoaDons.Add(hoaDon);
            dbContext.SaveChanges();
            //B3. Luu chi tiet danh sach ve da chon
            ChiTietHoaDon chiTiet;
            int soGhe;
            foreach (var ve in dsChon)
            {
                soGhe = int.Parse(ve.Text);
                chiTiet = new ChiTietHoaDon();
                chiTiet.HoaDonID = hoaDon.HoaDonID;
                chiTiet.GheID = dbContext.Ghes.Where(x => x.SoGhe == soGhe).FirstOrDefault().GheID;
                dbContext.ChiTietHoaDons.Add(chiTiet);
                ve.BackColor = Color.Yellow;
            }
            dbContext.SaveChanges();
            cbxKhachHang.Text = "";
            txtTien.Text = "";

        }

        private void CaiDatManHinh()
        {
            //B1. Lay danh sach tat ca hoa don tu DB
            List<string> dsSoGheChiTietHoaDon = dbContext.ChiTietHoaDons.Include("Ghe").Select(x => x.Ghe.SoGhe.ToString()).ToList();
            //B2. Kiem tra Ghe trong ung dung co ton tai chi tiet hay khong?
            //Neu ton tai thi ve da duoc ban
            foreach (Button ghe in this.Controls.OfType<Button>())
            {
                if (dsSoGheChiTietHoaDon.Contains(ghe.Text))
                {
                    ghe.BackColor = Color.Yellow;
                }
            }
            //lay danh sach khach hang
            RefreshKhachHang();

            //Button old = new Button() { Width = 0, Location = new Point(30, 50) };
            //int rong = 50, dai = 50;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Button btn = new Button()
            //        {
            //            Width = rong,
            //            Height = dai,
            //            Location = new Point(old.Location.X + rong, old.Location.Y)
            //        };
            //        this.Controls.Add(btn);
            //        old = btn;
            //    }
            //    old.Location = new Point(0, old.Location.Y + dai);
            //    old.Width = 0;
            //    old.Height = 0;
            //}
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            //form khach hang nhap thong tin
            frmKHachHang frm = new frmKHachHang();
            frm.luuThongTinKhachHang += Frm_luuThongTinKhachHang;
            frm.ShowDialog();
        }

        private void Frm_luuThongTinKhachHang(object sender, Utils.EventLuuThongTinKhachHang e)
        {
            RefreshKhachHang();
        }

        public void RefreshKhachHang()
        {
            dsKhachHang = dbContext.KhachHangs.ToList();

            cbxKhachHang.DataSource = dsKhachHang;
            cbxKhachHang.DisplayMember = "TenKhachHang";
            cbxKhachHang.ValueMember = "KhachHangID";
        }

        //Khai bao 1 nut mau
        /*Button btnMau = new Button();
        btnMau.Width = btnMau.Height = 90;
        btnMau.BackColor = Color.White;
        btnMau.Size = new System.Drawing.Size(85, 78);
        //Lay danh sach ghe trong database va thiet lap so ghe
        int y1 = 86;
        int y2 = y1 + 30 + btnMau.Height;
        int y3 = y2 + 30 + btnMau.Height;
        List<Ghe> danhSachGhe = dbContext.Ghes.ToList();

        Button btnGhe;
        Point point;
        int x = 86;
        List<Button> danhSachGheManHinh = new List<Button>();

        foreach (var ghe in danhSachGhe)
        {
            btnGhe = btnMau;
            if (ghe.SoGhe <= 5)
            {
                point = new Point(0, 0);
                btnGhe.Location = point;
            }
            else if(ghe.SoGhe <=11)
            {
                point = new Point(x, y2);
                btnGhe.Location = point;
            }
            else
            {
                point = new Point(x, y3);
                btnGhe.Location = point;
            }
            danhSachGheManHinh.Add(btnGhe);
            this.Controls.Add(btnGhe);
        }*/

    }
}
