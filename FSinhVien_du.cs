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
    public partial class FSinhVien_du : Form
    {
        public FSinhVien_du()
        {
            InitializeComponent();
        }

        private void PopulateItems()
        {
            UCTHongTinSV[] uCTHongTinSVs = new UCTHongTinSV[20];
            for (int i = 0; i < uCTHongTinSVs.Length; i++)
            {
                uCTHongTinSVs[i] = new UCTHongTinSV();
                uCTHongTinSVs[i].Id = $"{i}";
                uCTHongTinSVs[i].Ten = "Ho va Ten";
                uCTHongTinSVs[i].Lop = "CLC";
                flp_listSV.Controls.Add(uCTHongTinSVs[i]);
                uCTHongTinSVs[i].Dock = DockStyle.Top;
            }
        }

        private void FSinhVien_Load(object sender, EventArgs e)
        {
            this.PopulateItems();
        }

        private void flp_listSV_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
