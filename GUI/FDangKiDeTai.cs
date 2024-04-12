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
    public partial class FDangKiDeTai : Form
    {
        public FDangKiDeTai()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            DataTable dt = new DataTable();
            string sqlStr = string.Format("select * from DangKiDeTai inner join SinhVien on Sinhvien.MSSV = DangKiDeTai.MSSV");
            dt = DAOclass.Load(sqlStr);

            flp_list.Controls.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["TrangThai"].ToString() == "Chờ duyệt")
                {
                    UCDangKiDeTai ucdangki = new UCDangKiDeTai();
                    ucdangki.MSSV.Text = dt.Rows[i]["MSSV"].ToString();
                    ucdangki.TenSV.Text = dt.Rows[i]["HoTen"].ToString();
                    ucdangki.MaDeTai.Text = dt.Rows[i]["MaDT"].ToString();
                    ucdangki.ThoiGianYeuCau.Text = dt.Rows[i]["ThoiGianYeuCau"].ToString();
                    ucdangki.TrangThai.Text = dt.Rows[i]["TrangThai"].ToString();
                    flp_list.Controls.Add(ucdangki);
                }
            }
        }

        private void FDangKiDeTai_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
    }
}
