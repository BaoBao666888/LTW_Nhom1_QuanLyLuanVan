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

namespace Quan_Li_Luan_Van
{ 
    public partial class UCDangKiDeTai : UserControl
    {
        DAO dao = new DAO();

        public Guna2HtmlLabel MSSV { get => lblMSSV; set => lblMSSV = value; }

        public Guna2HtmlLabel TenSV { get => lblHoTen; set => lblHoTen = value; }

        public Guna2HtmlLabel MaDeTai { get => lblMaDeTai; set => lblMaDeTai = value; }
        public Guna2HtmlLabel TrangThai { get => lblTrangThai; set => lblTrangThai = value; }

        public Guna2HtmlLabel ThoiGianYeuCau { get => lblThoiGianYeuCau; set => lblThoiGianYeuCau = value; }

        public Guna2Button NutDuyet { get => btnTuChoi; set => btnTuChoi = value; }

        public UCDangKiDeTai()
        {
            InitializeComponent();

        }

        private void UCDangKiDeTai_Load(object sender, EventArgs e)
        {
            
        }

        private void UCDangKiDeTai_DoubleClick(object sender, EventArgs e)
        {
            FChiTiet fchiTiet = new FChiTiet(MaDeTai.Text);
            fchiTiet.ShowDialog();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            string sqlStr = string.Format($"update DangKiDeTai set TrangThai = N'Đã duyệt' where MaDT = '{MaDeTai.Text}'");
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn duyệt luận văn này?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                dao.Load(sqlStr);
                string sqlStrUpdate = string.Format($"Update DeTai set SoLuongSV = SoLuongSV + 1 where MaDT = '{MaDeTai.Text}'");
                dao.ThucThi(sqlStr);
                this.Visible = false;
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            FInputBox inputBox = new FInputBox();
            if (inputBox.ShowDialog() == DialogResult.OK)
            {
                string sqlStr = string.Format($"update DangKiDeTai set TrangThai = N'Từ chối', LyDoTuChoi = N'{inputBox.inputBox.Text}' where MaDT = '{MaDeTai.Text}'");
                dao.Load(sqlStr);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Đã hủy tác vụ");
            }
            
        }
    }
}
