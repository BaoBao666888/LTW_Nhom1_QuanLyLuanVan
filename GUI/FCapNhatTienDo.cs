using Quan_Li_Luan_Van.DAO;
using Quan_Li_Luan_Van.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IdentityModel.Selectors;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van.GUI
{
    public partial class FCapNhatTienDo : Form
    {
        public FCapNhatTienDo(DTO.Task task, string VaiTro)
        {
            InitializeComponent();
            this.LoadData(task,VaiTro); 
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.ShowDialog();
            txtTimKiem.Text = openFD.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                using (Stream stream = File.OpenRead(txtTimKiem.Text))
                {
                    document.IdFile = txt_idFile.Text;
                    document.MaTask = txt_maTask.Text;
                    document.MoTa = txt_moTa.Text;
                    document.ThoiGianUp = DateTime.Now;
                    document.Data = new Byte[stream.Length];
                    stream.Read(document.Data, 0, document.Data.Length);
                    document.Extension = new FileInfo(txtTimKiem.Text).Extension;
                    DocumentDAO.SaveFile(document);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Vui lòng tìm kiếm đường dẫn file!");
        }

        private void LoadData(DTO.Task task, string VaiTro)
        {
            txt_maTask.Text = task.MaTask;
            if (VaiTro == "Giảng viên")
            {
                btnSave.Hide();
                btnUpdate.Hide();
            }
            else
                btnDownload.Hide();
            Document doc = DocumentDAO.GetObjectByMaTask(task.MaTask);
            if (doc.IdFile != null)
            {
                btnSave.Hide();

                txt_idFile.Text = doc.IdFile;
                txt_moTa.Text = doc.MoTa;
                txt_thoiGianUp.Text = doc.ThoiGianUp.ToString("dd-MM-yyyy HH-mm-ss");
            }
            else
                btnUpdate.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                using (Stream stream = File.OpenRead(txtTimKiem.Text))
                {
                    document.IdFile = txt_idFile.Text;
                    document.MaTask = txt_maTask.Text;
                    document.MoTa = txt_moTa.Text;
                    document.ThoiGianUp = DateTime.Now;
                    document.Data = new Byte[stream.Length];
                    stream.Read(document.Data, 0, document.Data.Length);
                    document.Extension = new FileInfo(txtTimKiem.Text).Extension;
                    DocumentDAO.UpdateFile(document);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Vui lòng tìm kiếm đường dẫn file!");
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_idFile.Text))
            {
                MessageBox.Show("Chưa có file nào để mở");
            }
            else
            {
                Document doc = DocumentDAO.GetObjectByMaTask(txt_maTask.Text);
                DocumentDAO.ReadFile(doc);
            }
        }
    }
}
