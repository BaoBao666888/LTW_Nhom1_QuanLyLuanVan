using Quan_Li_Luan_Van.DAO;
using Quan_Li_Luan_Van.DTO;
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
            DataTable dt = new DataTable();
            if (vaitro == "Giảng viên")
            {
                dt = TaskDAO.GetDataByMSGV(gv.MSGV, cb_filter.Text);
            }
            else
                dt = TaskDAO.GetDataByMSSV(sv.MSSV, cb_filter.Text);
            flp_danhSachTask.Controls.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO.Task task = new DTO.Task(dt.Rows[i]["MaTask"].ToString() , dt.Rows[i]["MaDT"].ToString(), dt.Rows[i]["TenTask"].ToString(), dt.Rows[i]["MoTa"].ToString(), int.Parse(dt.Rows[i]["TyLeHoanThanh"].ToString()), DateTime.Parse(dt.Rows[i]["Deadline"].ToString()));
                UCTask ucTask = new UCTask(task, vaitro);
                flp_danhSachTask.Controls.Add(ucTask);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            FThemTask fThemTask = new FThemTask();
            DialogResult res = fThemTask.ShowDialog();

            if (res == DialogResult.OK)
            {
                MessageBox.Show("Thêm thành công!");
                this.LoadData();
            }
            else
                MessageBox.Show("Thêm thất bại!");
                
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadData();
        }
    }
}
