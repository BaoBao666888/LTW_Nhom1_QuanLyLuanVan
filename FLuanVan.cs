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
        UCLuanVan ucLuanVan = new UCLuanVan();
        public FLuanVan()
        {
            InitializeComponent();
        }

        private void FLuanVan_Load(object sender, EventArgs e)
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

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt = lvDAO.Load();
            List<UCLuanVan> listUCLuanVan = new List<UCLuanVan>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                ucLuanVan.Id = dt.Rows[i]["Id"].ToString();
                ucLuanVan.DeTai = dt.Rows[i]["DeTai"].ToString();
                if (dt.Rows[i]["DeTai"].ToString() == "Y")
                    ucLuanVan.cbTrangThai.Checked = true;
                else
                    ucLuanVan.cbTrangThai.Checked = false;
                ucLuanVan.MoTa = dt.Rows[i]["MoTa"].ToString();
                listUCLuanVan.Add(ucLuanVan);
            }
        }
    }
}
