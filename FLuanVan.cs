using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FLuanVan : Form
    {
        LuanVanDAO lvDAO = new LuanVanDAO();
        
        public FLuanVan()
        {
            InitializeComponent();
        }

        public void FLuanVan_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        public void AnNutChucNang()
        {
            btn_them.Visible = false;
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

        private void flp_list_Paint(object sender, PaintEventArgs e)
        {

        }
        public FlowLayoutPanel flpList
        {
            get { return flp_list; }
            set { flp_list = value; }
        }
        public void LoadData()
        {
            return;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            FThemluanvan fthemLV = new FThemluanvan();
            fthemLV.Show();
        }
    }
}
