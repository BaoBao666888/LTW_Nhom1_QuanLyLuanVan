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
    public partial class FGiangVien : Form
    {
        DAO gvDAO = new DAO();

        DataTable dt = new DataTable();
        private string maTK;
        public FGiangVien(string maTK)
        {
            InitializeComponent();
            this.maTK = maTK;
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

        private void FGiangVien_Load(object sender, EventArgs e)
        {
            this.GetData();
        }

        private void GetData()
        {

            string sqlStr = string.Format($"select TaiKhoan.MaTK, TaiKhoan.VaiTro, GiangVien.HoTen, GiangVien.MSGV from TaiKhoan inner join GiangVien on GiangVien.MaTK = TaiKhoan.MaTK where TaiKhoan.MaTK = '{this.maTK}'");
            dt = gvDAO.Load(sqlStr);
            this.lbl_ten.Text = dt.Rows[0]["HoTen"].ToString();
            this.lbl_chucVu.Text = "Giảng Viên";
        }

        private void pnl_infor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            pnl_childForm.Controls.Clear();
            FDangKiDeTai fDangKi = new FDangKiDeTai();
            fDangKi.TopLevel = false;
            pnl_childForm.Controls.Add(fDangKi);
            fDangKi.Dock = DockStyle.Fill;
            fDangKi.Show();

        }
    }
}
