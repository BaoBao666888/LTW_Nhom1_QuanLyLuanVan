using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DAO
{
    public class TaiKhoanDAO
    {
        public static DataTable GetDataGV()
        {
            string sqlStr = string.Format("select * from TaiKhoan where VaiTro = N'Giảng viên'");
            return DbConnection.Load(sqlStr);
        }

        public static DataTable GetDataSV()
        {
            string sqlStr = string.Format("select * from TaiKhoan where VaiTro = N'Sinh viên'");
            return DbConnection.Load(sqlStr);
        }
    }
}
