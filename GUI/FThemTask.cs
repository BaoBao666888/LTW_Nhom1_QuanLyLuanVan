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
        DTO.Task task;
        string VaiTro;
        public FThemTask(GiangVien gv)
        {
            InitializeComponent();
            this.LoadData(gv);
            btn_upload.Hide();
            btnSua.Hide();
            txtTyLeHoanThanh.Hide();
        }

        public FThemTask(SinhVien sv)
        {
            InitializeComponent();
            this.LoadData(sv);
            btn_upload.Hide();
            btnSua.Hide();
            txtTyLeHoanThanh.Hide();
        }

        public FThemTask(DTO.Task task, string VaiTro)
        {
            InitializeComponent();
            this.task = task;
            this.VaiTro = VaiTro;
            this.LoadData(task);
            this.PermissionControlForShowDetail();
        }

        private void PermissionControlForShowDetail()
        {
            if(VaiTro == "Giảng viên")
            {
                btnSua.Hide();
                txtTyLeHoanThanh.ReadOnly = true;
            }    
            btnLuu.Hide();
            txtMaTask.ReadOnly = true;
            txtTenDT.ReadOnly = true;
            txtTenTask.ReadOnly = true;
            txtMoTa.ReadOnly = true;
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

        private void LoadData(GiangVien gv)
        {
            DataTable dt = new DataTable();
            dt = LuanVanDAO.GetDataByMSGV(gv.MSGV);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb_maDT.Items.Add(dt.Rows[i]["MaDT"]);
            }
        }

        private void LoadData(SinhVien sv)
        {
            DataTable dt = new DataTable();
            dt = LuanVanDAO.GetDataByMSSV(sv.MSSV);
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

        private void btn_upload_Click(object sender, EventArgs e)
        {
            FCapNhatTienDo fCapNhatTienDo = new FCapNhatTienDo(task, VaiTro);
            DialogResult res = fCapNhatTienDo.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Tác vụ thành công");
            }
            else
                MessageBox.Show("Đã hủy");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTyLeHoanThanh.Value > 0)
            {
                DTO.Task task = new DTO.Task(txtMaTask.Text, cb_maDT.Text, txtTenTask.Text, txtMoTa.Text, int.Parse(txtTyLeHoanThanh.Value.ToString()), dt_deadline.Value);
                TaskDAO.UpdateTask(task);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("tỷ lệ hoàn thành chưa hợp lệ");
            }
        }

        private void txtTyLeHoanThanh_ValueChanged(object sender, EventArgs e)
        {
            pgb_tyLeHoanThanh.Value = int.Parse(txtTyLeHoanThanh.Value.ToString());
        }
    }
}
