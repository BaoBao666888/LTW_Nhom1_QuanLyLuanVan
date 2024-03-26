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
    public partial class FThemluanvan : Form
    {
        public FThemluanvan()
        {
            InitializeComponent();
        }

        private void FThemluanvan_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LuanVanDAO lvDAO = new LuanVanDAO();
            lvDAO.Them(txtMaLuanVan.Text, txtTenLuanVan.Text, cbTheLoai.Text, txtMoTa.Text, txtCongNghe.Text, txtYeuCau.Text, 0, int.Parse(txtSoLuongMaxSV.Text));
        }
    }
}
