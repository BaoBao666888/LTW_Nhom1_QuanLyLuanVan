using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van.DAO
{
    public class TaiKhoanDAO
    {
        public static TaiKhoan GetTaiKhoanGV(string taiKhoan, string matKhau)
        {
            try
            {
                using(var db = new QLLuanVanContext())
                {
                    var tk = (from s in db.TaiKhoans
                              where s.VaiTro == "Giảng viên"
                              && s.TenDangNhap == taiKhoan
                              && s.MatKhau == matKhau
                              select s
                              ).SingleOrDefault();
                    return tk;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static TaiKhoan GetTaiKhoanSV(string taiKhoan, string matKhau)
        {
            try
            {
                using (var db = new QLLuanVanContext())
                {
                    var tk = (from s in db.TaiKhoans
                              where s.VaiTro == "Sinh viên"
                              && s.TenDangNhap == taiKhoan
                              && s.MatKhau == matKhau
                              select s
                              ).SingleOrDefault();
                    return tk;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
