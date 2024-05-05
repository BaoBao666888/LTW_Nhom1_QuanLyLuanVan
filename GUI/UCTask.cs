using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Li_Luan_Van.DTO;
using Quan_Li_Luan_Van.DAO;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class UCTask : UserControl
    {
        DTO.Task task;
        public UCTask(DTO.Task task)
        {
            InitializeComponent();
            this.task = task;
            this.LoadData();
        }

        private void LoadData()
        {
            lbl_tenTask.Text = task.TenTask;
            LuanVan lv = LuanVanDAO.GetLuanVanBYMaDT(task.MaDT);
            txtTenDeTai.Text = lv.TenDeTai;
            lbl_deadline.Text = task.Deadline.ToString("dd/MM/yyyy");
            lbl_tyLeHoanThanh.Text = task.TyLeHoanThanh.ToString() + "%";
            pgb_tyLeHoanThanh.Value = task.TyLeHoanThanh;
        }

        private void UCTask_Click(object sender, EventArgs e)
        {
            FThemTask fThemTask = new FThemTask(task);
            fThemTask.ShowDialog();
        }
    }
}
