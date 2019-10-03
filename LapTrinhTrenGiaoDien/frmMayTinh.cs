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
    public partial class frmMayTinh : Form
    {
        string msgError;
        public frmMayTinh()
        {
            InitializeComponent();
        }

        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            float soA = 0;
            float soB = 0;
            //xac dinh tinh hop le cua du lieu
            if (ValidateInput(out soA, out soB))
            {
                //Xac dinh sender tra ve la mot nut
                Button btnPhepTinh = (Button)sender;
                //thong tin cac gia tri
                
                float ketQua = 0;
                //Xac dinh phep toan
                switch (btnPhepTinh.Name)
                {
                    case "btnCong":
                        ketQua = soA + soB;
                        break;
                    case "btnNhan":
                        ketQua = soA * soB;
                        break;
                    case "btnChia":
                        ketQua = soA / soB;
                        break;
                    case "btnTru":
                        ketQua = soA - soB;
                        break;
                    default:
                        break;
                }
                txtKetQua.Text = ketQua.ToString();
            }
            else
            {
                MessageBox.Show(msgError);
            }
        }

        private bool ValidateInput(out float soA, out float soB)
        {
            msgError = "";
            if(float.TryParse(txtSoA.Text, out soA) == false)
            {
                msgError = "Số A Không Hợp Lệ!";
            }
            if (float.TryParse(txtSoB.Text, out soB) == false)
            {
                msgError += "\nSố B Không Hợp Lệ!";
            }
            if (msgError == "")
                return true;
            return false;
        }
    }
}
