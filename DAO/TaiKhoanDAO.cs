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
                using(var db = new QLLuanVanEntities())
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
            catch
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                return null;
            }

            //string sqlStr = string.Format("select * from TaiKhoan where VaiTro = N'Giảng viên'");
            //return DbConnection.Load(sqlStr);
        }

        public static TaiKhoan GetTaiKhoanSV(string taiKhoan, string matKhau)
        {
            try
            {
                using (var db = new QLLuanVanEntities())
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
            catch
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                return null;
            }

            //string sqlStr = string.Format("select * from TaiKhoan where VaiTro = N'Sinh viên'");
            //return DbConnection.Load(sqlStr);
        }
    }
}
