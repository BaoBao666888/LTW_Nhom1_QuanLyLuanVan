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
    public partial class FSinhVien : Form
    {
        private bool dangXuatTrue = true;

        private TaiKhoan taiKhoan;
        private SinhVien sinhVien;
        public FSinhVien(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
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
            FLuanVan fLuanVan = new FLuanVan(taiKhoan, sinhVien);
            fLuanVan.TopLevel = false;
            pnl_childForm.Controls.Add(fLuanVan);
            fLuanVan.Dock = DockStyle.Fill;
            fLuanVan.Show();
        }

        private void GetData()
        {
            this.sinhVien = SinhVienDAO.GetSVByMaTK(taiKhoan.MaTK);
            this.lbl_ten.Text = sinhVien.HoTen;
            this.lbl_chucVu.Text = taiKhoan.VaiTro;
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pnl_childForm.Controls.Clear();
            FTienDo fTienDo = new FTienDo(sinhVien);
            fTienDo.TopLevel = false;
            pnl_childForm.Controls.Add(fTienDo);
            fTienDo.Dock = DockStyle.Fill;
            fTienDo.Show();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            pnl_childForm.Controls.Clear();
            FTraoDoiSV fTraoDoiSV = new FTraoDoiSV(sinhVien);
            fTraoDoiSV.TopLevel = false;
            pnl_childForm.Controls.Add(fTraoDoiSV);
            fTraoDoiSV.Dock = DockStyle.Fill;
            fTraoDoiSV.Show();
        }
    }
}
