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
    public partial class UCThongBao : UserControl
    {
        private TraoDoi traoDoi;
        public UCThongBao(TraoDoi traoDoi)
        {
            InitializeComponent();
            this.traoDoi = traoDoi;
            this.LoadData();
        }
        private void LoadData()
        {
            GiangVien giangVien = GiangVienDAO.GetGVByMSGV(traoDoi.MSGV);
            lblChuDe.Text = traoDoi.ChuDe;
            lblThoiGian.Text = traoDoi.ThoiGian.ToString();
            lblHoTen.Text = giangVien.HoTen;
        }

        private void UCThongBao_Load(object sender, EventArgs e)
        {

        }

        private void lblChuDe_Click(object sender, EventArgs e)
        {
            this.UCThongBao_Click(sender, e);
        }

        private void lblThoiGian_Click(object sender, EventArgs e)
        {
            this.UCThongBao_Click(sender, e);
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {
            this.UCThongBao_Click(sender, e);
        }

        private void UCThongBao_Click(object sender, EventArgs e)
        {
            FThongBao fThongBao = new FThongBao(traoDoi);
            fThongBao.ShowDialog();
        }
    }
}
