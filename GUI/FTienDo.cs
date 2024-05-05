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
        public FTienDo()
        {
            InitializeComponent();
            this.LoadData();
        }

        private void LoadData()
        {
            DataTable dt = TaskDAO.GetData();

            flp_danhSachTask.Controls.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO.Task task = new DTO.Task(dt.Rows[i]["MaTask"].ToString() , dt.Rows[i]["MaDT"].ToString(), dt.Rows[i]["TenTask"].ToString(), dt.Rows[i]["MoTa"].ToString(), int.Parse(dt.Rows[i]["TyLeHoanThanh"].ToString()), DateTime.Parse(dt.Rows[i]["Deadline"].ToString()));
                UCTask ucTask = new UCTask(task);
                flp_danhSachTask.Controls.Add(ucTask);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            FThemTask fThemTask = new FThemTask();
            fThemTask.ShowDialog();
        }
    }
}
