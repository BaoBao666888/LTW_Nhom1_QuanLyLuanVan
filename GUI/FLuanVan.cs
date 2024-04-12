using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Li_Luan_Van.DTO;
using Quan_Li_Luan_Van.DAO;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class FLuanVan : Form
    {

        DataTable dtThongTin;
        public FLuanVan()
        {
            InitializeComponent();
        }

        public FLuanVan(DataTable dtThongTin)
        {
            InitializeComponent();
           this.dtThongTin = dtThongTin;
            if (dtThongTin.Rows[0]["VaiTro"].ToString() == "Sinh viên")
            {
                btnThem.Visible = false;
            }
        }

        public void FLuanVan_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        public void LoadData()
        {
            DataTable dt = new DataTable();
            string sqlStr = string.Format("select * from DeTai");
            dt = LuanVanDAO.Load(sqlStr);

            flp_list.Controls.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                UCLuanVan ucLuanVan = new UCLuanVan(dtThongTin);
                ucLuanVan.MaDeTai.Text = dt.Rows[i]["MaDT"].ToString();
                ucLuanVan.TenDeTai.Text = dt.Rows[i]["TenDeTai"].ToString();
                ucLuanVan.TheLoai.Text = dt.Rows[i]["YeuCau"].ToString();
                flp_list.Controls.Add(ucLuanVan);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FThemLuanVan fThemLuanVan = new FThemLuanVan(dtThongTin.Rows[0]["MSGV"].ToString());
            
             DialogResult res = fThemLuanVan.ShowDialog();

            if (res ==DialogResult.Cancel)
            {
                this.FLuanVan_Load(sender, e);
            }
            
        }
    }
}
