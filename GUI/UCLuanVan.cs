﻿using Guna.UI2.WinForms;
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
    public partial class UCLuanVan : UserControl
    {
        TaiKhoan tk;
        SinhVien sv;
        GiangVien gv;
        DeTai lv;
        float res;
        public UCLuanVan(TaiKhoan tk, SinhVien sv, GiangVien gv, DeTai lv)
        {
            InitializeComponent();
            this.tk = tk;
            this.sv = sv;
            this.gv = gv;
            this.lv = lv;
            this.KiemTra();
            this.LoadData();
        }

        public UCLuanVan(TaiKhoan tk, GiangVien gv, DeTai lv, float res)
        {
            InitializeComponent();
            this.tk = tk;
            this.gv = gv;
            this.lv = lv;
            this.res = res;
            this.KiemTra();
            this.LoadData(res);
        }

        public UCLuanVan(TaiKhoan tk, GiangVien gv, DeTai lv)
        {
            InitializeComponent();
            this.tk = tk;
            this.gv = gv;
            this.lv = lv;
            this.KiemTra();
            this.LoadData();
        }

        private void LoadData(float res)
        {
            lblMaDeTai.Text = lv.MaDT;
            lblTenDeTai.Text = lv.TenDeTai;
            lblTheLoai.Text = lv.TheLoai;
            lblTrangThai.Text = res.ToString();
            btnDangKi.Visible = false;
            btnXoa.Visible = false;
        }

        private void LoadData()
        {
            lblMaDeTai.Text = lv.MaDT;
            lblTenDeTai.Text = lv.TenDeTai;
            lblTheLoai.Text = lv.TheLoai;
            if (!DangKiDAO.ConDangKi(lv.MaDT, lv.SoLuongSV))
            {
                lblTrangThai.Text = "Hết";
            }
            else
                lblTrangThai.Text = "Còn";
        }
        private void KiemTra()
        {
            if (tk.VaiTro == "Giảng viên")
            {
                btnXoa.Visible = true; 
            }
            else
            {
                if (DangKiDAO.SVChuaDangKi(sv.MSSV) && DangKiDAO.ConDangKi(lv.MaDT, lv.SoLuongSV))
                {
                    btnDangKi.Visible = true;
                }
            }
        }    

        private void mouseLeave()
        {
           // this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Transparent;
        }

        private void mouseEnter()
        {
           // this.BorderStyle = BorderStyle.Fixed3D;
            this.BackColor = Color.AntiqueWhite;
        }


        private void UCLuanVan_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeave();
        }

        private void UCLuanVan_MouseEnter(object sender, EventArgs e)
        {
            this.mouseEnter();
        }

        private void UCLuanVan_DoubleClick(object sender, EventArgs e)
        {
            FChiTiet fChiTiet = new FChiTiet(lv);
            fChiTiet.ShowDialog();
        }
        private void btnDangKi_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeave();
        }

        private void btnDangKi_MouseEnter(object sender, EventArgs e)
        {
            this.mouseEnter();
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeave();
        }

        private void btnXoa_MouseEnter(object sender, EventArgs e)
        {
            this.mouseEnter();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa luận văn này?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                LuanVanDAO.Xoa(this.lblMaDeTai.Text);
                this.Visible = false;
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            //FDangKiDeTai fDangKiDeTai = new FDangKiDeTai(sv, lv);
            //fDangKiDeTai.ShowDialog();
            var dateTime = DateTime.Now;
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn đăng kí đề tài này?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                DangKi dk = new DangKi
                {
                    MSSV = sv.MSSV,
                    MaDT = lv.MaDT,
                    ThoiGianYeuCau = dateTime,
                    TrangThai = "Chờ duyệt"
                };
                DangKiDAO.DangKiDeTai(dk);
            }
        }

        private void UCLuanVan_Load(object sender, EventArgs e)
        {
        }
    }
}
