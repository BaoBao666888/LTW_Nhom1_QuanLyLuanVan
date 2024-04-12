using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quan_Li_Luan_Van.DTO;

namespace Quan_Li_Luan_Van.DAO
{
    public class LuanVanDAO : DAOclass
    {
        public static void Them(LuanVan luanVan)
        {
            string sqlStr = string.Format("INSERT INTO DeTai(MaDT, TenDeTai, TheLoai, MoTa, CongNghe, YeuCau, ChucNang, MSGV) VALUES ('{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}','{7}')", luanVan.MadeTai, luanVan.TenDeTai, luanVan.TheLoai, luanVan.MoTa, luanVan.CongNghe, luanVan.YeuCau, luanVan.ChucNang, luanVan.MSGV);
            DbConnection.ThucThi(sqlStr);
        }

        // Sua

        public static void Xoa(string maDeTai)
        {
            string sqlStr = string.Format($"DELETE FROM DeTai WHERE MaDT = '{maDeTai}'");
            DbConnection.ThucThi(sqlStr);
        }

        //TimKiem
    }
}
