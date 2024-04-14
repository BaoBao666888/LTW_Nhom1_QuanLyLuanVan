using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Quan_Li_Luan_Van.DTO;
using Quan_Li_Luan_Van.DAO;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class FGiangVien : Form
    {
        private bool dangXuatTrue = true;

        private TaiKhoan taiKhoan;
        private GiangVien giangVien;
        public FGiangVien(TaiKhoan tk)
        {
            InitializeComponent();
            this.taiKhoan = tk;
            this.FormClosing += FGiangVien_FormClosing;
        }

        private void FGiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dangXuatTrue == true)
                if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.FormClosed += FGiangVien_FormClosed;
                }
                else
                {
                    e.Cancel = true;
                }
        }

        private void FGiangVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLuanVan_Click(object sender, EventArgs e)
        {
            pnl_childForm.Controls.Clear();
            FLuanVan fLuanVan = new FLuanVan(taiKhoan, giangVien);
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

            this.giangVien = GiangVienDAO.GetDataByMaTK(taiKhoan.MaTK);
            this.lbl_ten.Text = giangVien.HoTen;
            this.lbl_chucVu.Text = taiKhoan.VaiTro;
        }

        private void pnl_infor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            pnl_childForm.Controls.Clear();
            FDSDangKiDeTai fDangKi = new FDSDangKiDeTai(giangVien);
            fDangKi.TopLevel = false;
            pnl_childForm.Controls.Add(fDangKi);
            fDangKi.Dock = DockStyle.Fill;
            fDangKi.Show();

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
