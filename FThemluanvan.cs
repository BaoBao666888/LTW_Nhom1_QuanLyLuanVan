﻿using System;
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
    public partial class FThemluanvan : Form
    {
        public FThemluanvan(GiaoVien giaoVien)
        {
            InitializeComponent();
            lblTenGV.Text = giaoVien.HoTen;
        }

        private void FThemluanvan_Load(object sender, EventArgs e)
        {
            FLuanVan fLuanVan = new FLuanVan();
            fLuanVan.FLuanVan_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LuanVanDAO lvDAO = new LuanVanDAO();
            lvDAO.Them(txtMaLuanVan.Text, txtTenLuanVan.Text, cbTheLoai.Text, txtMoTa.Text, txtCongNghe.Text, txtYeuCau.Text, 0, int.Parse(txtSoLuongMaxSV.Text), lblTenGV.Text);
            this.FThemluanvan_Load(sender, e);
            this.Close();
        }
    }
}
