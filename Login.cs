using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //this.FormClosing += Login_FormClosing;
            //this.txtTaiKhoan.KeyDown += TxtTaiKhoan_KeyDown;
            //this.txtMatKhau.KeyDown += TxtMatKhau_KeyDown;
        }

        //private void TxtMatKhau_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //        btnDangNhap.PerformClick();
        //}

        //private void TxtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //        txtMatKhau.Focus();
        //}

        //private void Login_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        Application.Exit();
        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //    }

        //}

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (rdoGiangVien.Checked == true && txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "123")
            {
                FGiaoVien FDS = new FGiaoVien();
                FDS.Show();
                
                this.Hide();
            }
            else
            if (rdoSinhVien.Checked == true && txtTaiKhoan.Text == "user" && txtMatKhau.Text == "321")
            {
                FSinhVien fDashBoadSV = new FSinhVien();
                fDashBoadSV.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Lỗi!","Thông báo");
        }

        private void linklblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPasswd resetpw = new ResetPasswd();
            resetpw.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbDangNhap_Enter(object sender, EventArgs e)
        {

        }
    }
}
