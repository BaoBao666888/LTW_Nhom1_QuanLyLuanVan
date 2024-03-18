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

        public string ID
        {
            get { return lbl_id.Text; }
            set { lbl_id.Text = value; ID = value; }
        }

        public string Ten
        {
            get { return lbl_id.Text; }
            set { lbl_id.Text = value; Ten = value; }
        }

        private void UCLuanVan_Load(object sender, EventArgs e)
        {

        }
    }
}
