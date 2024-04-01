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
        LuanVanDAO lvDAO = new LuanVanDAO();
        public FLuanVan()
        {
            InitializeComponent();
        }

        private void FLuanVan_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        public void LoadData()
        {
            DataTable dt = new DataTable();
            string sqlStr = string.Format("Select *from DeTai");
            dt = lvDAO.Load(sqlStr);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                UCLuanVan ucLuanVan = new UCLuanVan();
                ucLuanVan.MaDeTai.Text = dt.Rows[i]["MaDT"].ToString();
                ucLuanVan.TenDeTai.Text = dt.Rows[i]["TenDeTai"].ToString();
                ucLuanVan.TheLoai.Text = dt.Rows[i]["YeuCau"].ToString();
                ucLuanVan.SoLuongConLai.Text = (int.Parse(dt.Rows[i]["SoLuongSVToiDa"].ToString()) - (int.Parse(dt.Rows[i]["SoLuongSV"].ToString()))).ToString();
                flp_list.Controls.Add(ucLuanVan);
            }
        }
    }
}
