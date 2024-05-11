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
using Quan_Li_Luan_Van.DAO;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class FThemLuanVan : Form
    {
        private GiangVien gv;
        public FThemLuanVan(GiangVien gv)
        {
            InitializeComponent();
            this.gv = gv;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DeTai dt = new DeTai
            {
                MaDT = txtMaDeTai.Text,
                TenDeTai = txtTenDeTai.Text,
                TheLoai = cbTheLoai.Text,
                MoTa = txtMoTa.Text,
                CongNghe = txtCongNghe.Text,
                YeuCau = txtYeuCau.Text,
                ChucNang = txtChucNang.Text,
                MSGV = gv.MSGV,
                SoLuongSV = int.Parse(txtSoLuongSV.Text)
            };
            LuanVanDAO.Them(dt);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtChucNang.Clear();
            txtCongNghe.Clear();
            txtMaDeTai.Clear();
            txtMoTa.Clear();
            txtTenDeTai.Clear();
            txtYeuCau.Clear();
            txtSoLuongSV.Clear();
            cbTheLoai.Text = "";
        }

        private void FThemLuanVan_Load(object sender, EventArgs e)
        {

        }
    }
}
