using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Li_Luan_Van.DAO;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class FDSDangKiDeTai : Form
    {
        GiangVien giangVien;
        public FDSDangKiDeTai()
        {
            InitializeComponent();
        }
        public FDSDangKiDeTai(GiangVien giangVien)
        {
            InitializeComponent();
            this.giangVien = giangVien;
        }

        public void LoadData()
        {
            flp_list.Controls.Clear();
            List<DangKi> ListDK = DangKiDAO.ThongTinDangKiTheoMSGV(giangVien.MSGV);
            foreach (var dk in ListDK)
            {
                UCDangKiDeTai ucDangKiDeTai = new UCDangKiDeTai(dk);
                flp_list.Controls.Add(ucDangKiDeTai);
            }
        }

        private void FDangKiDeTai_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
    }
}
