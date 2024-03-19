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
    public partial class UCTHongTinSV : UserControl
    {
        private string id;
        private string ten;
        private string lop;

        public string Id
        {
            get { return id; }
            set { id = value; lbl_id.Text = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; lbl_ten.Text = value; }
        }

        public string Lop
        {
            get { return lop; }
            set { lop = value; lbl_lop.Text = value; }
        }
        public UCTHongTinSV()
        {
            InitializeComponent();
        }

        private void UCTHongTinSV_Load(object sender, EventArgs e)
        {

        }
    }
}
