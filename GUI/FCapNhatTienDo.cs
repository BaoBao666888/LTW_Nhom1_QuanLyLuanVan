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
        public FCapNhatTienDo()
        {
            InitializeComponent();
            this.LoadData(); 
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
            using (Stream stream = File.OpenRead(txtTimKiem.Text))
            {
                document.IdFile = txt_idFile.Text;
                document.MaTask = txt_maTask.Text;
                document.MoTa = txtMoTa.Text;
                document.ThoiGianUp = DateTime.Now;
                document.Data = new Byte[stream.Length];
                stream.Read(document.Data, 0, document.Data.Length);
                document.Extension = new FileInfo(txtTimKiem.Text).Extension;
                DocumentDAO.SaveFile(document);
            }
            this.LoadData();
        }

        private void LoadData()
        {
            if (DocumentDAO.GetDataTable().Rows.Count > 0)
                dgv_documents.DataSource = DocumentDAO.GetDataTable();
        }
    }
}
