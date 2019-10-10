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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void MenuDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            if (!ShowActive(frm))
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        /// <summary>
        /// Kiem tra va chuyen trang thai cua Form con sang Active
        /// </summary>
        /// <param name="frm">Form</param>
        /// <returns>true: Da active</returns>
        /// <returns>false: Khong duoc active</returns>
        private bool ShowActive(Form frm)
        {
            foreach (Form frmChild in this.MdiChildren)
            {
                if(frmChild.Name == frm.Name)
                {
                    frmChild.Activate();
                    return true;
                }
            }
            return false;
        }

        private void MenuBanVe_Click(object sender, EventArgs e)
        {
            frmMuaVeXemPhimOnline frm = new frmMuaVeXemPhimOnline();
            if (!ShowActive(frm))
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
