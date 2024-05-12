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
    public partial class FThongKe : Form
    {
        GiangVien gv;
        TaiKhoan tk;
        public FThongKe(GiangVien gv, TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
            this.gv = gv;
            this.LoadDataByGV();
        }

        public void LoadDataByGV()
        {
            List<DeTai> ListDT = LuanVanDAO.GetDSDeTaiByMSGV(gv.MSGV);
            flp_list.Controls.Clear();
            foreach(var deTai in ListDT)
            {
                List<DanhGia> dtDiem = LuanVanDAO.GetListTask(deTai.MaDT);
                float res;
                int temp = 0;
                if (dtDiem.Count > 0)
                {
                    foreach (var item in dtDiem)
                    {
                        temp += item.Diem;
                    }
                }
                if (temp == 0)
                {
                    res = 0;
                }
                else
                    res = (float)temp / dtDiem.Count;
                UCLuanVan ucLuanVan = new UCLuanVan(tk, gv, deTai, res);
                flp_list.Controls.Add(ucLuanVan);
            }
        }
    }
}
