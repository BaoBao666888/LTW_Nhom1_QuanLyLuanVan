using Quan_Li_Luan_Van.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class FTienDo : Form
    {
        GiangVien gv;
        SinhVien sv;
        string vaitro;
        public FTienDo(GiangVien gv)
        {
            InitializeComponent();
            this.gv = gv;
            this.vaitro = "Giảng viên";
            this.LoadData();
        }

        public FTienDo(SinhVien sv)
        {
            InitializeComponent();
            this.sv = sv;
            this.vaitro = "Sinh viên";
            this.LoadData();
        }

        private void LoadData()
        {
            List<Task> ListTask = new List<Task>();
            if (vaitro == "Giảng viên")
            {
                ListTask = TaskDAO.GetDataByMSGV(gv.MSGV, cb_filter.Text);
            }
            else
            {
                ListTask = TaskDAO.GetDataByMSSV(sv.MSSV, cb_filter.Text);
                if (DangKiDAO.GetDeTaiByMSSV(sv.MSSV) != null)
                {
                    lbl_tenDT.Text = DangKiDAO.GetDeTaiByMSSV(sv.MSSV).TenDeTai;
                }
                else
                    lbl_tenDT.Text = "Vui lòng đăng kí đề tài";
            }
            flp_danhSachTask.Controls.Clear();


            foreach (var item in ListTask)
            {
                UCTask ucTask = new UCTask(item, vaitro);
                flp_danhSachTask.Controls.Add(ucTask);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult res = DialogResult.Cancel;
            if (vaitro == "Giảng viên")
            {
                FThemTask fThemTask = new FThemTask(gv);
                res = fThemTask.ShowDialog();
            }
            else
            {
                FThemTask fThemTask = new FThemTask(sv);
                res = fThemTask.ShowDialog();
            }    

            if (res == DialogResult.OK)
            {
                this.LoadData();
            }
            else
                MessageBox.Show("Thêm thất bại!");
                
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }
    }
}
