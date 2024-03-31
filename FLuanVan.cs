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
        GiaoVien giaoVien;

        SinhVien sinhVien;

        public FLuanVan()
        {
            InitializeComponent();
        }
        public FLuanVan(GiaoVien giaoVien)
        {
            InitializeComponent();
            this.giaoVien = giaoVien;
        }

        public FLuanVan(SinhVien sinhVien)
        {
            InitializeComponent();
            this.sinhVien = sinhVien;
        }

        public void FLuanVan_Load(object sender, EventArgs e)
        {
            this.GenerateDynamicUC();
        }

        public void LoadData(string sqlStr)
        {
            flp_list.Controls.Clear();
            DataTable dt = new DataTable();
            dt = lvDAO.Load(sqlStr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LuanVan luanVan = new LuanVan(dt.Rows[i]["MaDeTai"].ToString(), dt.Rows[i]["TenDeTai"].ToString(), dt.Rows[i]["TheLoai"].ToString(), dt.Rows[i]["MoTa"].ToString(), dt.Rows[i]["CongNghe"].ToString(), dt.Rows[i]["YeuCau"].ToString(), int.Parse(dt.Rows[i]["SoLuongSV"].ToString()), int.Parse(dt.Rows[i]["SoLuongMaxSV"].ToString()), dt.Rows[i]["TenGV"].ToString());
                UCLuanVan ucLuanVan = new UCLuanVan(luanVan);
                flpList.Controls.Add(ucLuanVan);
                ucLuanVan.Click += show;
            }
        }

        private void show(object sender, EventArgs e)
        {
            FDangKi fDangKi = new FDangKi();
            fDangKi.Show();
        }

        public void GenerateDynamicUC()
        {
            string sqlStr = string.Format("Select *from LuanVan");
            this.LoadData(sqlStr);
        }

        void loadDataFind()
        {
            string sqlStr = string.Format("Select *from LuanVan");
            DataTable dt = new DataTable();
            dt = lvDAO.Load(sqlStr);
            if (cbLuaChon.Text == "TheLoai")
            {
                cb_data.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (cb_data.Items.Contains(dt.Rows[i]["TheLoai"].ToString()))
                        continue;
                    cb_data.Items.Add(dt.Rows[i]["TheLoai"].ToString());
                }
            }
            else 
                if( cbLuaChon.Text == "GiaoVien")
                {
                cb_data.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (cb_data.Items.Contains(dt.Rows[i]["TenGV"].ToString()))
                            continue;
                        cb_data.Items.Add(dt.Rows[i]["TenGV"].ToString());
                    }
                }
        }

        public void AnNutDangKi()
        {
            btnDangKi.Visible = false;
        }

        public void AnNutThem()
        {
            btn_them.Visible = false;
        }

        private void flp_list_Paint(object sender, PaintEventArgs e)
        {
        }
        public FlowLayoutPanel flpList
        {
            get { return flp_list; }
            set { flp_list = value; }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            FThemluanvan fthemLV = new FThemluanvan(giaoVien);
            fthemLV.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.GenerateDynamicUC();
            this.loadDataFind();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (cbLuaChon.Text == "GiaoVien")
            {
                flp_list.Controls.Clear();
                string sqlStr = string.Format($"Select *from LuanVan where TenGV like '%{cb_data.Text.Trim()}%'");
                this.LoadData(sqlStr);
            }
            else
                if (cbLuaChon.Text == "TheLoai")
            {
                flp_list.Controls.Clear();
                string sqlStr = string.Format($"Select *from LuanVan where TheLoai like '%{cb_data.Text.Trim()}%'");
                this.LoadData(sqlStr);
            }

        }
    }
}
