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
    }
}
