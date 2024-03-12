using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Quan_Li_Luan_Van
{
    public partial class FDashBoard : Form
    {
        public FDashBoard()
        {
            InitializeComponent();
            this.FormClosing += FDashBoard_FormClosing;
        }

        private void FDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.FormClosed += FDashBoard_FormClosed;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FDashBoard_FormClosed1(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_LuanVan_Click(object sender, EventArgs e)
        {
            pnl_childForm.Controls.Clear();
            FLuanVan fLuanVan = new FLuanVan();
            fLuanVan.TopLevel = false;
            pnl_childForm.Controls.Add(fLuanVan);
            fLuanVan.Dock = DockStyle.Fill;
            fLuanVan.Show();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            pnl_childForm.Controls.Clear();
            FThongTinSV fSinhVien = new FThongTinSV();
            fSinhVien.TopLevel = false;
            pnl_childForm.Controls.Add(fSinhVien);
            fSinhVien.Dock = DockStyle.Fill;
            fSinhVien.Show();
        }

        private void FDashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
