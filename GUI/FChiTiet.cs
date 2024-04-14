using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Li_Luan_Van.DTO;
using Quan_Li_Luan_Van.DAO;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class FChiTiet : Form
    {
        private LuanVan lv;
        public FChiTiet(LuanVan lv)
        {
            InitializeComponent();
            this.lv = lv;
        }

        private void FChiTiet_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            GiangVien gv = GiangVienDAO.GetDataByMSGV(lv.MSGV);
            lblTenDeTai.Text = lv.TenDeTai;
            txtTheLoai.Text = lv.TheLoai;
            txtMoTa.Text = lv.MoTa;
            txtCongNghe.Text = lv.CongNghe;
            txtYeuCau.Text = lv.YeuCau;
            txtChucNang.Text = lv.ChucNang;
            txtTenGV.Text = gv.HoTen;
            txtSoLuongSV.Text = lv.SoLuongSV.ToString();
        }
    }
}
