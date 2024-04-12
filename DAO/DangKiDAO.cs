using Quan_Li_Luan_Van.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DAO
{
    public class DangKiDAO
    {
        public static void Them(DangKi dangKi)
        {
            string sqlStr = string.Format("INSERT INTO DangKi(MaNhom, MaDT, ThoiGianYeuCau, TrangThaiDK, LyDoTuChoi) VALUES ('{0}', '{1}', '{2}', N'{3}', N'{4}')", dangKi.MaNhom, dangKi.MaDT, dangKi.ThoiGianYeuCau, dangKi.TrangThaiDK, dangKi.LyDoTuChoi);
            DbConnection.ThucThi(sqlStr);
        }
    }
}
