using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class FLogin : Form
    {
        DAO dao = new DAO();
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            

            if (rdoGiangVien.Checked == true)
            {
                string sqlStr = string.Format("select * from TaiKhoan where VaiTro = 'Giảng viên'");
                dt = dao.Load(sqlStr);

                for (int i = 0; i < dt.Rows.Count; i++)
                    if (dt.Rows[i]["TenDangNhap"].ToString().Trim() == txtTaiKhoan.Text
                            && dt.Rows[i]["MatKhau"].ToString().Trim() == txtMatKhau.Text)
                    {
                        FGiangVien fGV = new FGiangVien(dt.Rows[i]["MaTK"].ToString());
                        fGV.Show();
                        this.Hide();
                        return;
                    }
            }
        }
    }
}
