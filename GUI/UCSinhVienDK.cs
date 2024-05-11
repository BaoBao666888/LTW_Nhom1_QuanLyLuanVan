﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class UCSinhVienDK : UserControl
    {
        SinhVien sv;
        public UCSinhVienDK(SinhVien sv)
        {
            InitializeComponent();
            this.sv = sv;
            this.LoadData();
        }
        public bool IsChecked()
        {
            return cbxChon.Checked;
        }
        public string GetMSSV()
        {
            return lblMSSV.Text;
        }
        private void LoadData()
        {
            lblHoTen.Text = sv.HoTen;
            lblMSSV.Text = sv.MSSV;
        }

        private void UCSinhVienDK_Load(object sender, EventArgs e)
        {

        }
        private void CheckBoxchanged()
        {
            if (cbxChon.Checked == true)
                cbxChon.Checked = false;
            else
                cbxChon.Checked = true;
        }
        private void lblMSSV_Click(object sender, EventArgs e)
        {
            this.CheckBoxchanged();
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {
            this.CheckBoxchanged();
        }

        private void UCSinhVienDK_Click(object sender, EventArgs e)
        {
            this.CheckBoxchanged();
        }
    }
}
