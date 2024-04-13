using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Li_Luan_Van.DTO;
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
            DataTable dt = new DataTable();
            

            if (rdoGiangVien.Checked == true)
            {
                dt = TaiKhoanDAO.GetDataGV();

                for (int i = 0; i < dt.Rows.Count; i++)
                    if (dt.Rows[i]["TenDangNhap"].ToString().Trim() == txtTaiKhoan.Text
                            && dt.Rows[i]["MatKhau"].ToString().Trim() == txtMatKhau.Text)
                    {
                        TaiKhoan taiKhoan = new TaiKhoan(dt.Rows[i]["MaTK"].ToString().Trim(), dt.Rows[i]["TenDangNhap"].ToString().Trim(), dt.Rows[i]["MatKhau"].ToString().Trim(), dt.Rows[i]["VaiTro"].ToString().Trim(), dt.Rows[i]["TrangThai"].ToString().Trim());
                        FGiangVien fGV = new FGiangVien(taiKhoan);
                        this.Hide();
                        fGV.Show();
                        return;
                    }
            }
            else 
                if(rdoSinhVien.Checked == true)
            {
                dt = TaiKhoanDAO.GetDataSV();

                for (int i = 0; i < dt.Rows.Count; i++)
                    if (dt.Rows[i]["TenDangNhap"].ToString().Trim() == txtTaiKhoan.Text
                            && dt.Rows[i]["MatKhau"].ToString().Trim() == txtMatKhau.Text)
                    {
                        TaiKhoan taiKhoan = new TaiKhoan(dt.Rows[i]["MaTK"].ToString().Trim(), dt.Rows[i]["TenDangNhap"].ToString().Trim(), dt.Rows[i]["MatKhau"].ToString().Trim(), dt.Rows[i]["VaiTro"].ToString().Trim(), dt.Rows[i]["TrangThai"].ToString().Trim());
                        FSinhVien fGV = new FSinhVien(taiKhoan);
                        this.Hide();
                        fGV.Show();
                        return;
                    }
            }
        }
    }
}
