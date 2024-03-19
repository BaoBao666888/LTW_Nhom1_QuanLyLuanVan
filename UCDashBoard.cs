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
    public partial class UCDashBoard : UserControl
    {
        public bool logOut = true;
        public Guna2Button btnLogOut
        {
            get { return btn_logOut; }
            set { btn_logOut = value; }
        }
        public UCDashBoard()
        {
            InitializeComponent();
        }

        private void UCDashBoard_Load(object sender, EventArgs e)
        {

        }

        public void btn_logOut_Click(object sender, EventArgs e)
        {
        }
    }
}
