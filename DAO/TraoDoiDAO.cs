using Quan_Li_Luan_Van.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DAO
{
    public class TraoDoiDAO
    {
        public static DataTable GetDanhSachDK(string MSGV)
        {
            string sqlStr = string.Format($"select* from FUNC_GetSinhVien('{MSGV}')");
            return DbConnection.Load(sqlStr);
        }
        public static void Them(TraoDoi traoDoi)
        {
            string sqlStr = string.Format("EXEC PROC_InsertIntoTraoDoi @MSSV = '{0}', @ChuDe = N'{1}', @ThongTin = N'{2}', @ThoiGian = '{3}', @MSGV = '{4}'", traoDoi.MSSV, traoDoi.ChuDe, traoDoi.ThongTin, traoDoi.ThoiGian, traoDoi.MSGV);
            DbConnection.ThucThi(sqlStr);
        }
        public static DataTable GetDataTraoDoi()
        {
            string sqlStr = string.Format($"select* from TraoDoi");
            return DbConnection.Load(sqlStr);
        }
    }
}
