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
    public partial class FDanhGiaTask : Form
    {
        DTO.Task task;
        public FDanhGiaTask()
        {
            InitializeComponent();
        }
        public FDanhGiaTask(DTO.Task task, string VaiTro)
        {
            InitializeComponent();
            this.task = task;
            this.LoadData(task, VaiTro);   
        }

        private void LoadData(DTO.Task task, string VaiTro)
        {
            if(VaiTro == "Sinh viên")
            {
                txtNhanXet.ReadOnly = true;
                txtDiem.ReadOnly = true;
                btnLuu.Visible = false;
            }    


            DanhGia obj = DanhGiaDAO.GetObj(task.MaTask);
            lblDeTai.Text = LuanVanDAO.GetLuanVanBYMaDT(task.MaDT).TenDeTai;
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
                DanhGia obj = new DanhGia(task.MaTask, txtNhanXet.Text, int.Parse(txtDiem.Text));
                DanhGiaDAO.DanhGia(obj);
                this.Close();
        }
    }
}
