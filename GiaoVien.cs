using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class GiaoVien : Form
    {
        private bool kTraDangXuat = true;
        Login lg = new Login();
        public GiaoVien()
        {
            InitializeComponent();
            this.FormClosing += GiaoVien_FormClosing;
        }

        private void GiaoVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && kTraDangXuat == true)                
                    Application.Exit();
        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            //ttpGiangVien.SetToolTip(tsmiDangXuat, "Quay về trang đăng nhập");
            //ttpGiangVien.SetToolTip(tsmiDanhSach, "Xem và chỉnh sửa danh sách đề tài");
            //ttpGiangVien.SetToolTip(tsmiSinhVien, "Kiểm tra tiến độ và chấm điểm đề tài");
        }

        private void tsmiDangXuat_Click(object sender, EventArgs e)
        {
            kTraDangXuat = false;
            lg.Show();
            this.Close();
        }
    }
}
