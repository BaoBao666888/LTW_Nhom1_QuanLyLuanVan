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
        private Timer timer;

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
            this.SetTimeDelay();
        }

        public FLuanVan(TaiKhoan tk, GiangVien gv)
        {
            InitializeComponent();
            this.tk = tk;
            this.gv = gv;

            this.SetTimeDelay();
        }

        public void FLuanVan_Load(object sender, EventArgs e)
        {
            if (txt_timKiem.Text.Trim() == "")
            {
                if (tk.VaiTro == "Sinh viên")
                    this.LoadDataBySV();
                else
                    this.LoadDataByGV();
            }

        }
        
        public void SetTimeDelay()
        {
            timer = new Timer();
            timer.Interval = 350;
            timer.Tick += DataTimKiem;
        }

        public void LoadDataByGV() 
        {
            DataTable dt = LuanVanDAO.GetDataByMSGV(gv.MSGV);
            flp_list.Controls.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LuanVan lv = new LuanVan(dt.Rows[i]["MaDT"].ToString(), dt.Rows[i]["TenDeTai"].ToString(), dt.Rows[i]["TheLoai"].ToString(), dt.Rows[i]["MoTa"].ToString(), dt.Rows[i]["CongNghe"].ToString(), dt.Rows[i]["YeuCau"].ToString(), dt.Rows[i]["ChucNang"].ToString(), dt.Rows[i]["MSGV"].ToString(), int.Parse(dt.Rows[i]["SoLuongSV"].ToString()));
                UCLuanVan ucLuanVan = new UCLuanVan(tk, gv, lv);
                flp_list.Controls.Add(ucLuanVan);
            }
        }

        public void LoadDataBySV()
        {
            DataTable dt = LuanVanDAO.GetData();

            flp_list.Controls.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LuanVan lv = new LuanVan(dt.Rows[i]["MaDT"].ToString(), dt.Rows[i]["TenDeTai"].ToString(), dt.Rows[i]["TheLoai"].ToString(), dt.Rows[i]["MoTa"].ToString(), dt.Rows[i]["CongNghe"].ToString(), dt.Rows[i]["YeuCau"].ToString(), dt.Rows[i]["ChucNang"].ToString(), dt.Rows[i]["MSGV"].ToString(), int.Parse(dt.Rows[i]["SoLuongSV"].ToString()));
                UCLuanVan ucLuanVan = new UCLuanVan(tk, sv, gv, lv);
                flp_list.Controls.Add(ucLuanVan);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FThemLuanVan fThemLuanVan = new FThemLuanVan(gv);
            
            //sau khi tắt form thêm sẽ load lại d
            DialogResult res = fThemLuanVan.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                this.FLuanVan_Load(sender, e);
            }
            
        }

        private void DataTimKiem(object sender, EventArgs e)
        {
            DataTable dt;
            if (tk.VaiTro == "Sinh viên")
                dt = LuanVanDAO.TimKiem(txt_timKiem.Text);
            else
                dt = LuanVanDAO.TimKiem(gv.MSGV, txt_timKiem.Text);
            flp_list.Controls.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LuanVan lv = new LuanVan(dt.Rows[i]["MaDT"].ToString(), dt.Rows[i]["TenDeTai"].ToString(), dt.Rows[i]["TheLoai"].ToString(), dt.Rows[i]["MoTa"].ToString(), dt.Rows[i]["CongNghe"].ToString(), dt.Rows[i]["YeuCau"].ToString(), dt.Rows[i]["ChucNang"].ToString(), dt.Rows[i]["MSGV"].ToString(), int.Parse(dt.Rows[i]["SoLuongSV"].ToString()));
                UCLuanVan ucLuanVan = new UCLuanVan(tk, sv, gv, lv);
                flp_list.Controls.Add(ucLuanVan);
            }
            timer.Stop();  
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }
    }
}
