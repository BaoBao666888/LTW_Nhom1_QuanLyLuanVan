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
            List<TraoDoi> listTD = TraoDoiDAO.GetDataTraoDoi();

            flp_list.Controls.Clear();

            foreach(var item in  listTD)
            {
                if (item.MSSV == sinhVien.MSSV)
                {
                    UCThongBao ucThongBao = new UCThongBao(item);
                    flp_list.Controls.Add(ucThongBao);
                }
            }
        }
    }
}
