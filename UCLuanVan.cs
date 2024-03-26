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
        LuanVan luanVan;
        public UCLuanVan(LuanVan luanVan)
        {
            InitializeComponent();
            this.luanVan = luanVan;
            lblMaDeTai.Text = luanVan.MadeTai;
            lblTenDeTai.Text = luanVan.TenDeTai;
            lblTheLoai.Text = luanVan.TheLoai;
            lblSoLuong.Text = luanVan.SoLuongMax.ToString();
        }
        private void UCLuanVan_Load(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FChiTiet fChiTiet = new FChiTiet(luanVan);
            fChiTiet.Show();
        }
    }
}
