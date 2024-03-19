using Guna.UI2.WinForms;
using System;
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
    public partial class UCLuanVan : UserControl
    {
        public UCLuanVan()
        {
            InitializeComponent();
        }

        public string Id
        {
            get { return lbl_id.Text; }
            set { lbl_id.Text = value; }
        }

        public string DeTai
        {
            get { return lbl_ten.Text; }
            set { lbl_ten.Text = value; }
        }

        public Guna2CustomCheckBox cbTrangThai
        {
            get { return cb_status; }
            set { cb_status = value; }
        }

        public string MoTa
        {
            get { return txt_mota.Text; }
            set { txt_mota.Text = value; }
        }

        private void UCLuanVan_Load(object sender, EventArgs e)
        {

        }

        public void AnNut()
        {
            btn_xoa.Visible = false;
        }
    }
}
