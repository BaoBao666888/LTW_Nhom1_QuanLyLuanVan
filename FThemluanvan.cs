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

        private void txtMaluanvan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            LuanVanDAO lvDAO = new LuanVanDAO();

            lvDAO.Them(txtMaluanvan.Text, txtTenluanvan.Text, 'N', rtxtMota.Text);
         

            
        }
    }
}
