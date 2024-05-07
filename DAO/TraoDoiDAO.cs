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
            string sqlStr = string.Format($"Insert into TraoDoi(MSSV, ChuDe, ThongTin, ThoiGian, MSGV, TTGV, TTSV) values ('{traoDoi.MSSV}', N'{traoDoi.ChuDe}', N'{traoDoi.ThongTin}', '{traoDoi.ThoiGian.ToString("yyyy-MM-dd HH:mm:ss")}', '{traoDoi.MSGV}', 0, 0)");
            DbConnection.ThucThi(sqlStr);
        }
        public static DataTable GetDataTraoDoi()
        {
            string sqlStr = string.Format($"select* from TraoDoi");
            return DbConnection.Load(sqlStr);
        }
    }
}
