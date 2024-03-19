﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class DashBoardGV : Form
    {
        private bool dangXuatTrue = true;
        public DashBoardGV()
        {
            InitializeComponent();
            ucDashBoard1.btnLogOut.Click += btnLogOut_Click;
            this.FormClosing += DashBoardGV_FormClosing;
        }

        private void DashBoardGV_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (dangXuatTrue == true)
                if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.FormClosed += DashBoardGV_FormClosed;
                }
                else
                {
                    e.Cancel = true;
                }
        }

        private void DashBoardGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (dangXuatTrue == true)
            {
                Login fLogin = new Login();
                fLogin.Show();
                dangXuatTrue = false;
                this.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnl_childForm.Controls.Clear();
            FLuanVan fLuanVan = new FLuanVan();
            fLuanVan.TopLevel = false;
            pnl_childForm.Controls.Add(fLuanVan);
            fLuanVan.Dock = DockStyle.Fill;
            fLuanVan.Show();
        }

        private void DashBoadGV_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pnl_childForm.Controls.Clear();
            FSinhVien fSinhVien = new FSinhVien();
            fSinhVien.TopLevel = false;
            pnl_childForm.Controls.Add(fSinhVien);
            fSinhVien.Dock = DockStyle.Fill;
            fSinhVien.Show();
        }
    }
}