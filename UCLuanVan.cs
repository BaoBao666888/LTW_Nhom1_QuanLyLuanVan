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

        private string id;
        private string name;
        public string ID
        {
            get { return lbl_id.Text; }
            set { lbl_id.Text = value; id = value; }
        }

        public string Ten
        {
            get { return lbl_ten.Text; }
            set { lbl_ten.Text = value; name = value; }
        }

        public UCLuanVan()
        {
            InitializeComponent();
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
