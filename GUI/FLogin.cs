using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Li_Luan_Van.DAO;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            this.FormClosed += FLogin_FormClosed;
        }

        private void FLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {            
            if (rdoGiangVien.Checked == true)
            {
                TaiKhoan tk = TaiKhoanDAO.GetTaiKhoanGV(txtTaiKhoan.Text, txtMatKhau.Text);
                FGiangVien fGV = new FGiangVien(tk);
                this.Hide();
                fGV.Show();
                return;
            }
            else 
                if(rdoSinhVien.Checked == true)
            {
                TaiKhoan taiKhoan = TaiKhoanDAO.GetTaiKhoanSV(txtTaiKhoan.Text, txtTaiKhoan.Text);
                FSinhVien fGV = new FSinhVien(taiKhoan);
                this.Hide();
                fGV.Show();
                return;
            }
        }
    }
}
