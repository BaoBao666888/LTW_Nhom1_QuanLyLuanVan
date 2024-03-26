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
    public partial class FChiTiet : Form
    {

        public FChiTiet(LuanVan luanVan)
        {
            InitializeComponent();
            txtMaLuanVan.Text = luanVan.MadeTai;
            txtTenLuanVan.Text = luanVan.TenDeTai;
            txtTheLoai.Text = luanVan.TheLoai;
            txtMoTa.Text = luanVan.MoTa;
            txtCongNghe.Text = luanVan.CongNghe;
            txtYeuCau.Text = luanVan.YeuCau;
            txtSoLuongSV.Text = luanVan.SoLuongSV.ToString();
            txtSoLuongMaxSV.Text = luanVan.SoLuongMax.ToString();
        }

        private void FChiTiet_Load(object sender, EventArgs e)
        {

        }
    }
}
