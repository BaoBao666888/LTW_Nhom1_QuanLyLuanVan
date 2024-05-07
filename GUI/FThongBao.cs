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
    public partial class FThongBao : Form
    {
        private GiangVien giangVien;
        List<string> mssvS = new List<string>();
        public FThongBao(List<string> mssvS, GiangVien giangVien)
        {
            InitializeComponent();
            this.mssvS = mssvS;
            this.giangVien = giangVien;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            foreach (string mssv in mssvS)
            {
                TraoDoi traoDoi = new TraoDoi(mssv,txtChuDe.Text,txtThongTin.Text,DateTime.Now,giangVien.MSGV);
                TraoDoiDAO.Them(traoDoi);
            }
        }
    }
}
