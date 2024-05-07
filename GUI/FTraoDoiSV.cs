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
    public partial class FTraoDoiSV : Form
    {
        private SinhVien sinhVien;
        public FTraoDoiSV(SinhVien sinhVien)
        {
            InitializeComponent();
            this.sinhVien = sinhVien;
        }

        private void FTraoDoiSV_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void LoadData()
        {
            DataTable dt = TraoDoiDAO.GetDataTraoDoi();

            flp_list.Controls.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime thoiGian = dt.Rows[i].Field<DateTime>("ThoiGian");
                TraoDoi traoDoi = new TraoDoi(dt.Rows[i]["MSSV"].ToString(), dt.Rows[i]["ChuDe"].ToString(), dt.Rows[i]["ThongTin"].ToString(), thoiGian, dt.Rows[i]["MSGV"].ToString());
                if (sinhVien.MSSV == traoDoi.MSSV)
                {
                    UCThongBao ucThongBao = new UCThongBao(traoDoi);
                    flp_list.Controls.Add(ucThongBao);
                }
            }
        }
    }
}
