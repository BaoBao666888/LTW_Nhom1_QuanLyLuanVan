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

        public Label lblId
        {
            get { return lbl_id; }
            set { lbl_id = value; }
        }

        public Label lblDeTai
        {
            get { return lbl_ten; }
            set { lbl_ten = value; }
        }

        public Guna2CustomCheckBox cbTrangThai
        {
            get { return cb_status; }
            set { cb_status = value; }
        }

        public RichTextBox txtMoTa
        {
            get { return txt_mota; }
            set { txt_mota = value; }
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
