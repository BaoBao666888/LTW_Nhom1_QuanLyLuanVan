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
        SinhVienDAO svDAO = new SinhVienDAO();
        GiaoVienDAO gvDAO = new GiaoVienDAO();
        public Login()
        {
            InitializeComponent();
            //this.FormClosing += Login_FormClosing;
            //this.txtTaiKhoan.KeyDown += TxtTaiKhoan_KeyDown;
            //this.txtMatKhau.KeyDown += TxtMatKhau_KeyDown;
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dtSV = new DataTable();
            dtSV = svDAO.Load();

            DataTable dtGV = new DataTable();
            dtGV = gvDAO.Load();
            if (rdoGiangVien.Checked == true)
            {
                for (int i = 0; i < dtGV.Rows.Count; i++)
                    if (dtGV.Rows[i]["TenDangNhap"].ToString().Trim() == txtTaiKhoan.Text
                            && dtGV.Rows[i]["MatKhau"].ToString().Trim() == txtMatKhau.Text)
                    { 
                        GiaoVien giaoVien = new GiaoVien(dtGV.Rows[i]["MaGV"].ToString(), dtGV.Rows[i]["TenDangNhap"].ToString(), dtGV.Rows[i]["MatKhau"].ToString(), dtGV.Rows[i]["TenGV"].ToString());
                        FGiaoVien FDS = new FGiaoVien(giaoVien);
                        FDS.Show();
                        this.Hide();
                        break;
                    }
            }
            else
            if (rdoSinhVien.Checked == true)
            {
                for (int i = 0; i < dtSV.Rows.Count; i++)
                    if (txtTaiKhoan.Text == dtSV.Rows[i]["TenDangNhap"].ToString().Trim() && txtMatKhau.Text == dtSV.Rows[i]["MatKhau"].ToString().Trim())
                    {
                        FSinhVien fDashBoadSV = new FSinhVien();
                        fDashBoadSV.Show();
                        this.Hide();
                        break;
                    }
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
