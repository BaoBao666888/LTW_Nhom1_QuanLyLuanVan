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
    public partial class UCLuanVan : UserControl
    {
        DAO dao = new DAO();
        LuanVanDAO lvDAO = new LuanVanDAO();
        private string mSSV;
        public UCLuanVan(DataTable dt)
        {
            InitializeComponent();
            this.KiemTra(dt);
        }
       

        public Guna2HtmlLabel MaDeTai { get => lblMaDeTai; set => lblMaDeTai = value; }

        public Guna2HtmlLabel TenDeTai { get => lblTenDeTai; set => lblTenDeTai = value; }

        public Guna2HtmlLabel TheLoai { get => lblTheLoai; set => lblTheLoai = value; }

        public Guna2HtmlLabel SoLuongConLai { get => lblSoLuongConLai; set => lblSoLuongConLai = value; }

        private void KiemTra(DataTable dt)
        {
            if (dt.Rows[0]["VaiTro"].ToString() == "Gi?ng viên")
                btnDangKi.Visible = false;
            else
            {
                this.mSSV = dt.Rows[0]["MSSV"].ToString();
                btnXoa.Visible = false;
            }
        }    

        private void mouseLeave()
        {
            this.BorderStyle = BorderStyle.None;
        }

        private void mouseEnter()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
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
            FChiTiet fChiTiet = new FChiTiet(this.MaDeTai.Text);
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
                lvDAO.Xoa(this.lblMaDeTai.Text);
                this.Visible = false;
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if ((int.Parse(SoLuongConLai.Text)) <= 0)
            {
                MessageBox.Show("Đề tài đã đủ lượng đăng kí", "WARNING!", MessageBoxButtons.OKCancel);
            }
            else
            {
                var dateTime = DateTime.Now;
                var dateTimeString = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn đăng kí đề tài này?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string sqlStr = string.Format($"INSERT INTO DangKiDeTai (MSSV, MaDT, ThoiGianYeuCau, TrangThai) VALUES ('{this.mSSV}', '{this.MaDeTai.Text}', '{dateTimeString}', N'Chờ duyệt')");
                    dao.ThucThi(sqlStr);
                }
            }
        }

        private void UCLuanVan_Load(object sender, EventArgs e)
        {
        }
    }
}
