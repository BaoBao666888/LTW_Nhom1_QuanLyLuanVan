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
    public partial class FSinhVien : Form
    {
        private bool dangXuatTrue = true;
        DAO svDAO = new DAO();

        DataTable dt = new DataTable();
        private string maTK;
        public FSinhVien(string maTK)
        {
            InitializeComponent();
            this.maTK = maTK;
            this.GetData();
            this.FormClosing += FSinhVien_FormClosing;
        }

        private void FSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dangXuatTrue == true)
                if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.FormClosed += FSinhVien_FormClosed;
                }
                else
                {
                    e.Cancel = true;
                }
        }

        private void FSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FSinhVien_Load(object sender, EventArgs e)
        {
        }

        private void btnLuanVan_Click(object sender, EventArgs e)
        {
            pnl_childForm.Controls.Clear();
            FLuanVan fLuanVan = new FLuanVan(dt);
            fLuanVan.TopLevel = false;
            pnl_childForm.Controls.Add(fLuanVan);
            fLuanVan.Dock = DockStyle.Fill;
            fLuanVan.Show();
        }

        private void GetData()
        {

            string sqlStr = string.Format($"select TaiKhoan.MaTK, TaiKhoan.VaiTro, SinhVien.HoTen, SinhVien.MSSV from TaiKhoan inner join SinhVien on SinhVien.MaTK = TaiKhoan.MaTK where TaiKhoan.MaTK = '{this.maTK}'");
            dt = svDAO.Load(sqlStr);
            this.lbl_ten.Text = dt.Rows[0]["HoTen"].ToString();
            this.lbl_chucVu.Text = dt.Rows[0]["VaiTro"].ToString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (dangXuatTrue == true)
            {
                FLogin fLogin = new FLogin();
                fLogin.Show();
                dangXuatTrue = false;
                this.Close();
            }
        }
    }
}
