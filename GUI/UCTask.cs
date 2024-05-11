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
using System.Diagnostics;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class UCTask : UserControl
    {
        Task task;
        string vaiTro;
        public UCTask(Task task, string VaiTro)
        {
            InitializeComponent();
            this.task = task;
            this.vaiTro = VaiTro;
            this.LoadData();
            this.PermissionControl(VaiTro);
        }

        private void PermissionControl(string VaiTro)
        {
            if(VaiTro == "Giảng viên")
            {
                btnTienDo.Hide();
            }    
        }

        private void LoadData()
        {
            lbl_tenTask.Text = task.TenTask;
            DeTai lv = LuanVanDAO.GetDeTaiBYMaDT(task.MaDT);
            txtTenDeTai.Text = lv.TenDeTai;
            lbl_deadline.Text = task.Deadline.ToString("dd/MM/yyyy");
            lbl_tyLeHoanThanh.Text = task.TyLeHoanThanh.ToString() + "%";
            pgb_tyLeHoanThanh.Value = task.TyLeHoanThanh;
        }

        private void UCTask_Click(object sender, EventArgs e)
        {
            FThemTask fThemTask = new FThemTask(task, vaiTro);
            DialogResult res = fThemTask.ShowDialog();
            if(res == DialogResult.OK)
            {
                this.LoadData();
            }
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            if (vaiTro == "Giảng viên")
            {
                DialogResult res = new DialogResult();
                if (task.Deadline > DateTime.Now)
                {
                    res = MessageBox.Show("Task này chưa hết hạn, Bạn có chắc muốn cho điểm", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (res == DialogResult.Yes)
                    {
                        FDanhGiaTask fDanhGiaTask = new FDanhGiaTask(task, vaiTro);
                        fDanhGiaTask.ShowDialog();
                    }
                }
                else
                {
                    FDanhGiaTask fDanhGiaTask = new FDanhGiaTask(task, vaiTro);
                    fDanhGiaTask.ShowDialog();
                }
            }
        }

        private void UCTask_Load(object sender, EventArgs e)
        {

        }
    }
}
