using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Quan_Li_Luan_Van.DTO;

namespace Quan_Li_Luan_Van.DAO
{
    public class SinhVienDAO
    {
        public static DataTable GetData()
        {
            string sqlStr = string.Format("select * from SinhVien");
            return DbConnection.Load(sqlStr);
        }

        public static SinhVien GetDataByMaTK(string maTK)
        {
            string sqlStr = string.Format($"select * from SinhVien where MaTK = '{maTK}'");
            DataTable dt = DbConnection.Load(sqlStr);
            SinhVien sv = new SinhVien(dt.Rows[0]["MSSV"].ToString(), dt.Rows[0]["HoTen"].ToString(), dt.Rows[0]["Lop"].ToString(), dt.Rows[0]["Email"].ToString(), dt.Rows[0]["SDT"].ToString(), dt.Rows[0]["MaTK"].ToString());
            return sv;
        }
    }
}
