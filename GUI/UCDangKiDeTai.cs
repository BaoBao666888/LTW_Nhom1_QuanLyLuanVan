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
using Quan_Li_Luan_Van.DAO;

namespace Quan_Li_Luan_Van.GUI
{ 
    public partial class UCDangKiDeTai : UserControl
    {
        DangKi dangKi;

        public UCDangKiDeTai()
        {
            InitializeComponent();

        }

        public UCDangKiDeTai(DangKi dangKi)
        {
            InitializeComponent();
            this.dangKi = dangKi;
            this.loadData();
        }

        public void loadData()
        {
            SinhVien sinhVien = SinhVienDAO.ThongTinSVDangKiDeTai(dangKi.MaDT);
            lblMSSV.Text = sinhVien.MSSV;
            lblHoTen.Text = sinhVien.HoTen;
            lblMaDeTai.Text = dangKi.MaDT;
            lblThoiGianYeuCau.Text = dangKi.ThoiGianYeuCau.ToString("yyyy-MM-dd HH:mm:ss");
            lblTrangThai.Text = dangKi.TrangThai;
        }

        private void UCDangKiDeTai_Load(object sender, EventArgs e)
        {
            
        }

        private void UCDangKiDeTai_DoubleClick(object sender, EventArgs e)
        {
            DeTai dt = LuanVanDAO.GetDeTaiBYMaDT(dangKi.MaDT);
            FChiTiet fchiTiet = new FChiTiet(dt);
            fchiTiet.ShowDialog();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn duyệt luận văn này?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                DangKiDAO.DuyetDeTai(dangKi.MaDT);
                this.Visible = false;
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            FInputBox inputBox = new FInputBox();
            if (inputBox.ShowDialog() == DialogResult.OK)
            {
                DangKiDAO.TuChoiDeTai(dangKi.MaDT, inputBox.Text);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Đã hủy tác vụ");
            }

        }
    }
}
