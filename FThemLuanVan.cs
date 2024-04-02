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
    public partial class FThemLuanVan : Form
    {
        private string mSGV;
        LuanVanDAO lvDAO = new LuanVanDAO();
        public FThemLuanVan(string mSGV)
        {
            InitializeComponent();
            this.mSGV = mSGV;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lvDAO.Them(txtMaDeTai.Text, txtTenDeTai.Text, cbTheLoai.Text, txtMoTa.Text, txtCongNghe.Text, txtYeuCau.Text, txtChucNang.Text, 0, int.Parse(cbSoLuong.Text), this.mSGV);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtChucNang.Clear();
            txtCongNghe.Clear();
            txtMaDeTai.Clear();
            txtMoTa.Clear();
            txtTenDeTai.Clear();
            txtYeuCau.Clear();
            cbSoLuong.Text = "";
            cbTheLoai.Text = "";
        }
    }
}
