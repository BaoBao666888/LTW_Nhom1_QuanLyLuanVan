using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quan_Li_Luan_Van.DTO;

namespace Quan_Li_Luan_Van.DAO
{
    public class GiangVienDAO
    {
        public static DataTable GetData()
        {
            string sqlStr = string.Format("select * from GiangVien");
            return DbConnection.Load(sqlStr);
        }

        public static GiangVien GetDataByMaTK(string maTK)
        {
            string sqlStr = string.Format($"select * from GiangVien where MaTK = '{maTK}'");
            DataTable dt = DbConnection.Load(sqlStr);
            GiangVien gv = new GiangVien(dt.Rows[0]["MSGV"].ToString(), dt.Rows[0]["HoTen"].ToString(), dt.Rows[0]["Email"].ToString(), dt.Rows[0]["SDT"].ToString(), dt.Rows[0]["MaTK"].ToString());
            return gv;
        }
    }
}
