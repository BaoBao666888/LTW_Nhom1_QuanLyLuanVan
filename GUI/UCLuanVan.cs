using Guna.UI2.WinForms;
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
    public partial class UCLuanVan : UserControl
    {
        TaiKhoan tk;
        SinhVien sv;
        GiangVien gv;
        LuanVan lv;
        public UCLuanVan(TaiKhoan tk, SinhVien sv, GiangVien gv, LuanVan lv)
        {
            InitializeComponent();
            this.tk = tk;
            this.sv = sv;
            this.gv = gv;
            this.lv = lv;
            this.KiemTra();
        }
       

        public Guna2HtmlLabel MaDeTai { get => lblMaDeTai; set => lblMaDeTai = value; }

        public Guna2HtmlLabel TenDeTai { get => lblTenDeTai; set => lblTenDeTai = value; }

        public Guna2HtmlLabel TheLoai { get => lblTheLoai; set => lblTheLoai = value; }

        public Guna2HtmlLabel NhomThucHien { get => lblNhomThucHien; set => lblNhomThucHien = value; }

        private void KiemTra()
        {
            if (tk.VaiTro == "Giảng viên")
            {
                btnXoa.Visible = true;
                btnSua.Visible = true;
            }
            else
            {
                btnDangKi.Visible = true;
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
            FDangKiDeTai fDangKiDeTai = new FDangKiDeTai(sv, lv);
            fDangKiDeTai.ShowDialog();
            //if (NhomThucHien.Text.Trim() != "")
            //{
            //    MessageBox.Show("Đề tài đã đăng kí", "WARNING!", MessageBoxButtons.OKCancel);
            //}
            //else
            //{
            //    var dateTime = DateTime.Now;
            //    var dateTimeString = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            //    DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn đăng kí đề tài này?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (res == DialogResult.Yes)
            //    {
            //        string sqlStr = string.Format($"INSERT INTO DangKiDeTai (MSSV, MaDT, ThoiGianYeuCau, TrangThai) VALUES ('{this.mSSV}', '{this.MaDeTai.Text}', '{dateTimeString}', N'Chờ duyệt')");
            //        DAOclass.ThucThi(sqlStr);
            //    }
            //}
        }

        private void UCLuanVan_Load(object sender, EventArgs e)
        {
        }
    }
}
