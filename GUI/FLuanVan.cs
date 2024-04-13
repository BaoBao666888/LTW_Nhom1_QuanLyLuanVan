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
        TaiKhoan tk;
        SinhVien sv;
        GiangVien gv;
        public FLuanVan()
        {
            InitializeComponent();
        }

        public FLuanVan(TaiKhoan tk, SinhVien sv)
        {
            InitializeComponent();
            this.tk = tk;
            this.sv = sv;
            if (tk.VaiTro == "Sinh viên")
            {
                btnThem.Visible = false;
            }
        }

        public FLuanVan(TaiKhoan tk, GiangVien gv)
        {
            InitializeComponent();
            this.tk = tk;
            this.gv = gv;
        }

        public void FLuanVan_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        public void LoadData()
        {
            DataTable dt = LuanVanDAO.GetData();

            flp_list.Controls.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LuanVan lv = new LuanVan(dt.Rows[i]["MaDT"].ToString(), dt.Rows[i]["TenDeTai"].ToString(), dt.Rows[i]["TheLoai"].ToString(), dt.Rows[i]["MoTa"].ToString(), dt.Rows[i]["CongNghe"].ToString(), dt.Rows[i]["YeuCau"].ToString(), dt.Rows[i]["ChucNang"].ToString(), dt.Rows[i]["MSGV"].ToString());
                UCLuanVan ucLuanVan = new UCLuanVan(tk, sv, gv, lv);
                ucLuanVan.MaDeTai.Text = lv.MadeTai;
                ucLuanVan.TenDeTai.Text = lv.TenDeTai;
                ucLuanVan.TheLoai.Text = lv.TheLoai;
                flp_list.Controls.Add(ucLuanVan);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FThemLuanVan fThemLuanVan = new FThemLuanVan(gv);
            
             DialogResult res = fThemLuanVan.ShowDialog();

            if (res ==DialogResult.Cancel)
            {
                this.FLuanVan_Load(sender, e);
            }
            
        }
    }
}
