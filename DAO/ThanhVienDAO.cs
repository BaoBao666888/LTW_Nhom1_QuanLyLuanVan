using Quan_Li_Luan_Van.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DAO
{
    public class ThanhVienDAO
    {
        public static DataTable GetData()
        {
            string sqlStr = string.Format("select * from ThanhVien");
            return DbConnection.Load(sqlStr);
        }
        public static void Them(ThanhVien thanhVien)
        {
            string sqlStr = string.Format("insert into ThanhVien(MSSV, MaNhom, VaiTro) values ('{0}', '{1}', N'{2}')", thanhVien.MSSV, thanhVien.MaNhom, thanhVien.VaiTro);
            DbConnection.Load(sqlStr);
        }

        public static DataTable GetDataByMSSV(string mSSV)
        {
            string sqlStr = string.Format($"select * from ThanhVien where MSSV = '{mSSV}'");
            return DbConnection.Load(sqlStr);
        }
    }
}
