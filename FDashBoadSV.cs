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
    public partial class FDashBoadSV : Form
    {
        public FDashBoadSV()
        {
            InitializeComponent();
        }

        private void btn_LuanVan_Click(object sender, EventArgs e)
        {
            pnl_childForm.Controls.Clear();
            DSLuanVanSV dSLuanVanSV = new DSLuanVanSV();
            dSLuanVanSV.TopLevel = false;
            pnl_childForm.Controls.Add(dSLuanVanSV);
            dSLuanVanSV.Dock = DockStyle.Fill;
            dSLuanVanSV.Show();
        }
    }
}
