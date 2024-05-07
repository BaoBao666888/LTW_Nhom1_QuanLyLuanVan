using Quan_Li_Luan_Van.DAO;
using Quan_Li_Luan_Van.DTO;
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
            DataTable dt = TraoDoiDAO.GetDanhSachDK(giangVien.MSGV);

            flp_list.Controls.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SinhVienDK svdk = new SinhVienDK(dt.Rows[i]["MSSV"].ToString(), dt.Rows[i]["HoTen"].ToString());
                UCSinhVienDK uc = new UCSinhVienDK(svdk);
                flp_list.Controls.Add(uc);
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
