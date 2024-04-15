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
            this.LoadData();
        }

        public UCLuanVan(TaiKhoan tk, GiangVien gv, LuanVan lv)
        {
            InitializeComponent();
            this.tk = tk;
            this.gv = gv;
            this.lv = lv;
            this.KiemTra();
            this.LoadData();
        }
       
        private void LoadData()
        {
            lblMaDeTai.Text = lv.MadeTai;
            lblTenDeTai.Text = lv.TenDeTai;
            lblTheLoai.Text = lv.TheLoai;
            if (DangKiDAO.KiemTraDangKi(lv.MadeTai).Rows.Count >= lv.SoLuongSV)
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
                if (DangKiDAO.KiemTraSinhVienDangki(sv.MSSV) == 0 && DangKiDAO.KiemTraDangKi(lv.MadeTai).Rows.Count <= lv.SoLuongSV)
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
            if (DangKiDAO.SoLuongDangKi(lv.MadeTai) >= lv.SoLuongSV)
            {
                MessageBox.Show("Đề tài đã đủ lượng đăng kí", "WARNING!", MessageBoxButtons.OKCancel);
            }
            else
            {
                var dateTime = DateTime.Now;
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn đăng kí đề tài này?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    DangKiDAO.DangKiDeTai(new DangKi(sv.MSSV, lv.MadeTai, dateTime, "Chờ duyệt", ""));
                }
            }
        }

        private void UCLuanVan_Load(object sender, EventArgs e)
        {
        }
    }
}
