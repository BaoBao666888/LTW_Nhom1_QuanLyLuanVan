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
    public partial class FDanhGiaTask : Form
    {
        Task task;
        public FDanhGiaTask()
        {
            InitializeComponent();
        }
        public FDanhGiaTask(Task task, string VaiTro)
        {
            InitializeComponent();
            this.task = task;
            this.LoadData(task, VaiTro);   
        }

        private void LoadData(Task task, string VaiTro)
        {
            if(VaiTro == "Sinh viên")
            {
                btnLuu.Visible = false;
            }    


            DanhGia obj = DanhGiaDAO.GetObj(task.MaTask);
            lblDeTai.Text = LuanVanDAO.GetDeTaiBYMaDT(task.MaDT).TenDeTai;
            lblTenTask.Text = task.TenTask;
            if (!string.IsNullOrEmpty(obj.MaTask))
            {
                btnLuu.Visible = false;
                txtNhanXet.Text = obj.NhanXet;
                txtDiem.Text = obj.Diem.ToString();

                txtNhanXet.ReadOnly = true;
                txtDiem.ReadOnly = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DanhGia obj = new DanhGia()
            {
                MaTask = task.MaTask,
                NhanXet = txtNhanXet.Text,
                Diem = int.Parse(txtDiem.Text)
            };
            DanhGiaDAO.DanhGia(obj);
            this.Close();
        }
    }
}
