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
    public partial class FLuanVan : Form
    {
        public FLuanVan()
        {
            InitializeComponent();
        }

        private void FLuanVan_Load(object sender, EventArgs e)
        {
            this.PopulateItems();
        }
        public void AnNutChucNang()
        {
            btn_them.Visible = false;
        }
        private void PopulateItems()
        {
            UCLuanVan[] listUCLuanVan = new UCLuanVan[20];
            for (int i = 0; i < listUCLuanVan.Length; i++)
            {
                listUCLuanVan[i] = new UCLuanVan();
                listUCLuanVan[i].ID = "nhập Đề Tài";
                listUCLuanVan[i].Ten = "nhập Mô tả";
                flp_list.Controls.Add(listUCLuanVan[i]);
                listUCLuanVan[i].Dock = DockStyle.Top;
            }
        }
        private void txt_timKiem_Click(object sender, EventArgs e)
        {
            txt_timKiem.Clear();
        }

        private void txt_timKiem_Leave(object sender, EventArgs e)
        {
            if (txt_timKiem.Text == "")
                txt_timKiem.Text = "Tìm kiếm";
        }
    }
}
