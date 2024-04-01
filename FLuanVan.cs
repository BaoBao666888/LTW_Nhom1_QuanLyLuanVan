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

namespace Quan_Li_Luan_Van
{
    public partial class FLuanVan : Form
    {
        LuanVanDAO lvDAO = new LuanVanDAO();

        DataTable dtThongTin;
        public FLuanVan()
        {
            InitializeComponent();
        }

        public FLuanVan(DataTable dtThongTin)
        {
            InitializeComponent();
           this.dtThongTin = dtThongTin;
            if (dtThongTin.Rows[0]["VaiTro"].ToString() == "Gi?ng viên")
                guna2Button2.Visible = true;
        }

        public void FLuanVan_Load(object sender, EventArgs e)
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
                UCLuanVan ucLuanVan = new UCLuanVan(dtThongTin.Rows[0]["VaiTro"].ToString());
                ucLuanVan.MaDeTai.Text = dt.Rows[i]["MaDT"].ToString();
                ucLuanVan.TenDeTai.Text = dt.Rows[i]["TenDeTai"].ToString();
                ucLuanVan.TheLoai.Text = dt.Rows[i]["YeuCau"].ToString();
                ucLuanVan.SoLuongConLai.Text = (int.Parse(dt.Rows[i]["SoLuongSVToiDa"].ToString()) - (int.Parse(dt.Rows[i]["SoLuongSV"].ToString()))).ToString();
                flp_list.Controls.Add(ucLuanVan);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FThemLuanVan fThemLuanVan = new FThemLuanVan(dtThongTin.Rows[0]["HoTen"].ToString());
            fThemLuanVan.Show();
        }
    }
}
