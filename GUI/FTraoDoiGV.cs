using Quan_Li_Luan_Van.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class FTraoDoiGV : Form
    {
        private GiangVien giangVien;
        public FTraoDoiGV(GiangVien giangVien)
        {
            InitializeComponent();
            this.giangVien = giangVien;
        }

        private void FTraoDoiGV_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void LoadData()
        {

            flp_list.Controls.Clear();
            List<SinhVien> ListSV = SinhVienDAO.DSThongTinSVDangKiThanhCong();
            foreach(var sv in ListSV)
            {
                UCSinhVienDK ucSinhVienDK = new UCSinhVienDK(sv);
                flp_list.Controls.Add(ucSinhVienDK);
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            List<string> mssvS = new List<string>();
            foreach (UCSinhVienDK uc in flp_list.Controls)
            {
                if (uc.IsChecked())
                {
                    mssvS.Add(uc.GetMSSV());
                }
            }
            if (!mssvS.Any())
            {
                MessageBox.Show("Vui lòng chọn người gửi!","Thông báo");
            }
            else
            {
                FThongBao fThongBao = new FThongBao(mssvS, giangVien);
                fThongBao.ShowDialog();
            }

        }
    }
}
