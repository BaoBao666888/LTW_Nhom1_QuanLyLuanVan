using System;
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
        public DashBoardGV()
        {
            InitializeComponent();
            ucDashBoard1.btnLogOut.Click += btnLogOut_Click;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login fLogin = new Login();
            fLogin.Show();
            this.Close();
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

    }
}
