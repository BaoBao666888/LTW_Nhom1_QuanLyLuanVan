using Quan_Li_Luan_Van.DAO;
using Quan_Li_Luan_Van.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class FThemTask : Form
    {
        public FThemTask()
        {
            InitializeComponent();
            this.LoadData();
        }
        public FThemTask(DTO.Task task)
        {
            InitializeComponent();
            this.LoadData(task);
            this.PermissionControlForShowDetail();
        }

        private void PermissionControlForShowDetail()
        {
            btnLuu.Hide();
            txtMaTask.ReadOnly = true;
            txtTenDT.ReadOnly = true;
            txtTenTask.ReadOnly = true;
            txtMoTa.ReadOnly = true;
            txtTyLeHoanThanh.ReadOnly = true;
            cb_maDT.Items.Clear();
        }

        private void LoadData(DTO.Task task) 
        {
            txtMaTask.Text = task.MaTask;
            cb_maDT.Text = task.MaDT;
            txtTenDT.Text = LuanVanDAO.GetLuanVanBYMaDT(task.MaDT).TenDeTai;
            txtTenTask.Text = task.TenTask;
            txtMoTa.Text = task.MoTa;
            dt_deadline.Value = task.Deadline;
            txtTyLeHoanThanh.Text = task.TyLeHoanThanh.ToString();
            pgb_tyLeHoanThanh.Value = task.TyLeHoanThanh;
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt = LuanVanDAO.GetData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb_maDT.Items.Add(dt.Rows[i]["MaDT"]);
            }
        }

        private void cb_maDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            LuanVan lv;
            lv = LuanVanDAO.GetLuanVanBYMaDT(cb_maDT.Text);
            txtTenDT.Text = lv.TenDeTai;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (this.checkData())
            {
                DTO.Task task = new DTO.Task(txtMaTask.Text, cb_maDT.Text, txtTenTask.Text, txtMoTa.Text, 0, dt_deadline.Value);
                TaskDAO.ThemTask(task);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập vào!");

        }

        private bool checkData()
        {
            if (string.IsNullOrEmpty(txtMaTask.Text) || string.IsNullOrEmpty(txtMoTa.Text) || string.IsNullOrEmpty(cb_maDT.Text) || dt_deadline.Value < DateTime.Now)
            {
                return false;
            }
            else
                return true;
        }
    }
}
