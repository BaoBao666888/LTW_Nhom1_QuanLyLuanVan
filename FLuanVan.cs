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
        private void PopulateItems()
        {
            UCLuanVan[] listUCLuanVan = new UCLuanVan[20];
            for (int i = 0; i < listUCLuanVan.Length; i++)
            {
                listUCLuanVan[i] = new UCLuanVan();
                listUCLuanVan[i].ID = "nhập Đề Tài";
                listUCLuanVan[i].Ten = "nhập Mô tả";
                flp_list.Controls.Add(listUCLuanVan[i]);
            }
        }

        private void FLuanVan_Load(object sender, EventArgs e)
        {
            this.PopulateItems();
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
