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
    public partial class FGiangVien : Form
    {
        public FGiangVien()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLuanVan_Click(object sender, EventArgs e)
        {
            pnl_childForm.Controls.Clear();
            FLuanVan fLuanVan = new FLuanVan();
            fLuanVan.TopLevel = false;
            pnl_childForm.Controls.Add(fLuanVan);
            fLuanVan.Dock = DockStyle.Fill;
            fLuanVan.Show();
        }
    }
}
