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
using Quan_Li_Luan_Van.DTO;
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
            LuanVan lv = new LuanVan(txtMaDeTai.Text, txtTenDeTai.Text, cbTheLoai.Text, txtMoTa.Text, txtCongNghe.Text, txtYeuCau.Text, txtChucNang.Text, gv.MSGV);
            LuanVanDAO.Them(lv);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtChucNang.Clear();
            txtCongNghe.Clear();
            txtMaDeTai.Clear();
            txtMoTa.Clear();
            txtTenDeTai.Clear();
            txtYeuCau.Clear();
            cbTheLoai.Text = "";
        }

        private void FThemLuanVan_Load(object sender, EventArgs e)
        {

        }
    }
}
